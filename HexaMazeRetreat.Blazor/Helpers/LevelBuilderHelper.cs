using HexaMazeRetreat.Domain;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using HexaMazeRetreat.Domain.Contracts;
using SixLabors.ImageSharp.Formats.Jpeg;

namespace HexaMazeRetreat.Blazor.Helpers
{
    public class LevelBuilderHelper
    {
        private const int TILE_SIZE = 128;

        private readonly Random _randomGenerator = new();
        private readonly PlaysHelper _playsHelper;
        private readonly GraphicsCacheHelper _graphicsCacheHelper;

        public LevelBuilderHelper(
            PlaysHelper playsHelper,
            GraphicsCacheHelper graphicsCacheHelper)
        {
            _playsHelper = playsHelper;
            _graphicsCacheHelper = graphicsCacheHelper;
        }

        public async Task<byte[]> BuildLevel(string levelName)
        {
            var sw = Stopwatch.StartNew();

            var levelResourceName = BuildLevelResourceName(levelName);
            var levelJson = EmbeddedResourceHelper.GetLevelByResourceName(levelResourceName);
            var level = JsonSerializer.Deserialize<MazeMap>(levelJson);
            var plays = await _playsHelper.GetLastPlaysByLevel(levelName);

            var (width, height) = (level.Width * TILE_SIZE, level.Height * TILE_SIZE);

            var levelImage = _graphicsCacheHelper.GetLevelByName(levelName, () =>
            {
                var levelImage = new Image<Rgba32>(width, height);

                levelImage.Mutate(imageContext =>
                {
                    var backgroundColor = Rgba32.ParseHex("#ffffff");
                    imageContext.BackgroundColor(backgroundColor);

                    foreach (var tile in level)
                    {
                        if (tile.IsUsed)
                        {
                            var tileBitmap = _graphicsCacheHelper.GetImageByTileKind(tile.Kind, TILE_SIZE);
                            var tileLocation = CalculateBounds(tile.X, tile.Y);

                            imageContext.DrawImage(tileBitmap, tileLocation, new GraphicsOptions
                            {
                                AlphaCompositionMode = PixelAlphaCompositionMode.SrcOver,
                                Antialias = false,
                                AntialiasSubpixelDepth = 16,
                                BlendPercentage = 1,
                                ColorBlendingMode = PixelColorBlendingMode.Normal
                            });
                        }
                    }
                });

                return levelImage;
            });

            levelImage = levelImage.Clone(imageContext =>
            {
                if (levelName == "level-0")
                {
                    GeneratePathsForLevel0(imageContext);
                }
                else
                {
                    GeneratePathsForLevel(imageContext, level, plays);
                }
            });

            await using var levelImageStream = new MemoryStream();
            await levelImage.SaveAsJpegAsync(levelImageStream, new JpegEncoder { Quality = 90 });
            var buffer = levelImageStream.GetBuffer();

            sw.Stop();
            Debug.WriteLine($"{sw.ElapsedMilliseconds}ms");

            return buffer;
        }

        private void GeneratePathsForLevel0(IImageProcessingContext imageContext)
        {
            var points = new List<Point>
            {
                new(1, 3), new(2, 3), new(3, 3),
                new(4, 3), new(5, 3), new(6, 3),
                new(7, 3), new(8, 3), new(9, 3),
                new(10, 3), new(11, 3)
            };

            for (int i = 0; i < 5; i++)
            {
                var actualPoints = new List<PointF>();

                foreach (var point in points)
                {
                    var tileLocation = CalculateBounds(point.X, point.Y);
                    var offsetX = _randomGenerator.Next(TILE_SIZE / 6, TILE_SIZE - TILE_SIZE / 6);
                    var offsetY = _randomGenerator.Next(TILE_SIZE / 6, TILE_SIZE - TILE_SIZE / 6);
                    actualPoints.Add(new PointF(tileLocation.X + offsetX, tileLocation.Y + offsetY));
                }

                var color = GenerateColorByIndex(i + 1);
                imageContext.DrawLines(Color.White, 6f, actualPoints.ToArray());
                imageContext.DrawLines(color, 2f, actualPoints.ToArray());
            }
        }

        private void GeneratePathsForLevel(IImageProcessingContext imageContext, MazeMap level, GetLastPlaysByLevelResponse plays)
        {
            foreach (var play in plays)
            {
                var color = GenerateColorByIndex(play.Index);
                var actualPoints = new List<PointF>();
                var start = level.Single(x => x.Kind == TileKind.Start);
                var lastPoint = new Point(start.X, start.Y);

                var tileLocation = CalculateBounds(lastPoint.X, lastPoint.Y);
                var offsetX = _randomGenerator.Next(TILE_SIZE / 6, TILE_SIZE - TILE_SIZE / 6);
                var offsetY = _randomGenerator.Next(TILE_SIZE / 6, TILE_SIZE - TILE_SIZE / 6);
                actualPoints.Add(new PointF(tileLocation.X + offsetX, tileLocation.Y + offsetY));

                foreach (var step in play.SubmittedSolution.Steps)
                {
                    switch (step)
                    {
                        case SolutionStep.NorthEast:
                            if (lastPoint.Y % 2 == 0)
                            {
                                lastPoint = new Point(lastPoint.X, lastPoint.Y - 1);
                            }
                            else
                            {
                                lastPoint = new Point(lastPoint.X + 1, lastPoint.Y - 1);
                            }
                            break;
                        case SolutionStep.East:
                            lastPoint = new Point(lastPoint.X + 1, lastPoint.Y);
                            break;
                        case SolutionStep.SouthEast:
                            if (lastPoint.Y % 2 == 0)
                            {
                                lastPoint = new Point(lastPoint.X, lastPoint.Y + 1);
                            }
                            else
                            {
                                lastPoint = new Point(lastPoint.X + 1, lastPoint.Y + 1);
                            }
                            break;
                        case SolutionStep.SouthWest:
                            if (lastPoint.Y % 2 == 0)
                            {
                                lastPoint = new Point(lastPoint.X, lastPoint.Y + 1);
                            }
                            else
                            {
                                lastPoint = new Point(lastPoint.X - 1, lastPoint.Y + 1);
                            }
                            break;
                        case SolutionStep.West:
                            lastPoint = new Point(lastPoint.X - 1, lastPoint.Y);
                            break;
                        case SolutionStep.NorthWest:
                            if (lastPoint.Y % 2 == 0)
                            {
                                lastPoint = new Point(lastPoint.X, lastPoint.Y - 1);
                            }
                            else
                            {
                                lastPoint = new Point(lastPoint.X - 1, lastPoint.Y - 1);
                            }
                            break;
                    }

                    tileLocation = CalculateBounds(lastPoint.X, lastPoint.Y);
                    offsetX = _randomGenerator.Next(TILE_SIZE / 6, TILE_SIZE - TILE_SIZE / 6);
                    offsetY = _randomGenerator.Next(TILE_SIZE / 6, TILE_SIZE - TILE_SIZE / 6);
                    actualPoints.Add(new PointF(tileLocation.X + offsetX, tileLocation.Y + offsetY));
                }

                imageContext.DrawLines(Color.White, 6f, actualPoints.ToArray());
                imageContext.DrawLines(color, 2f, actualPoints.ToArray());
            }
        }

        private Color GenerateColorByIndex(int index)
        {
            return index switch
            {
                1 => Color.Blue,
                2 => Color.Red,
                3 => Color.Yellow,
                4 => Color.Purple,
                5 => Color.Green,
                6 => Color.Bisque,
                7 => Color.Brown,
                8 => Color.Cyan,
                9 => Color.Magenta,
                _ => Color.Black
            };
        }

        private string BuildLevelResourceName(string levelName)
        {
            return $"HexaMazeRetreat.Blazor.Levels.{levelName}.hexajson";
        }

        private Point CalculateBounds(int x, int y)
        {
            var tileWidth = TILE_SIZE;
            var tileHeight = TILE_SIZE;

            var xOffset = (y % 2 == 0 ? 0 : tileWidth / 2) + x * tileWidth;
            var yOffset = y * (tileHeight - tileHeight / 4);

            return new Point(xOffset, yOffset);
        }
    }
}