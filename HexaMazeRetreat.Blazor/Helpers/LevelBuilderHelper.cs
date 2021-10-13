using System;
using System.Collections.Generic;
using System.Diagnostics;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Drawing;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using HexaMazeRetreat.Domain;
using SixLabors.ImageSharp.Drawing.Processing;

namespace HexaMazeRetreat.Blazor.Helpers
{
    public class LevelBuilderHelper
    {
        private const int TILE_SIZE = 128;

        private readonly Random _randomGenerator = new();
        private readonly GraphicsCacheHelper _graphicsCacheHelper;

        public LevelBuilderHelper(
            GraphicsCacheHelper graphicsCacheHelper)
        {
            _graphicsCacheHelper = graphicsCacheHelper;
        }

        public async Task<byte[]> BuildLevel(string levelId)
        {
            var sw = Stopwatch.StartNew();

            var levelName = BuildLevelName(levelId);
            var levelJson = EmbeddedResourceHelper.GetLevelByResourceName(levelName);
            var level = JsonSerializer.Deserialize<MazeMap>(levelJson);

            var (width, height) = (level.Width * TILE_SIZE, level.Height * TILE_SIZE);
            using var levelImage = new Image<Rgba32>(width, height);

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

                var points1 = new List<Point>
                {
                    new(0, 0), new(1, 1), new(2, 1), new(3, 1), new(3, 2),
                    new(3, 3), new(3, 4), new(4, 4), new(5, 3), new(6, 3)
                };

                var points2 = new List<PointF>();

                foreach (var point in points1)
                {
                    var tileLocation = CalculateBounds((int)point.X, (int)point.Y);
                    var offsetX = _randomGenerator.Next(TILE_SIZE / 4, TILE_SIZE - TILE_SIZE / 4);
                    var offsetY = _randomGenerator.Next(TILE_SIZE / 4, TILE_SIZE - TILE_SIZE / 4);
                    points2.Add(new PointF(tileLocation.X + offsetX, tileLocation.Y + offsetY));
                }

                var points3 = new List<PointF>();

                foreach (var point in points1)
                {
                    var tileLocation = CalculateBounds((int)point.X, (int)point.Y);
                    var offsetX = _randomGenerator.Next(TILE_SIZE / 4, TILE_SIZE - TILE_SIZE / 4);
                    var offsetY = _randomGenerator.Next(TILE_SIZE / 4, TILE_SIZE - TILE_SIZE / 4);
                    points3.Add(new PointF(tileLocation.X + offsetX, tileLocation.Y + offsetY));
                }

                var points4 = new List<PointF>();

                foreach (var point in points1)
                {
                    var tileLocation = CalculateBounds((int)point.X, (int)point.Y);
                    var offsetX = _randomGenerator.Next(TILE_SIZE / 4, TILE_SIZE - TILE_SIZE / 4);
                    var offsetY = _randomGenerator.Next(TILE_SIZE / 4, TILE_SIZE - TILE_SIZE / 4);
                    points4.Add(new PointF(tileLocation.X + offsetX, tileLocation.Y + offsetY));
                }
                
                imageContext.DrawLines(Color.White, 10f, points2.ToArray());
                imageContext.DrawLines(Color.Yellow, 5f, points2.ToArray());
                imageContext.DrawLines(Color.White, 10f, points3.ToArray());
                imageContext.DrawLines(Color.Red, 5f, points3.ToArray());
                imageContext.DrawLines(Color.White, 10f, points4.ToArray());
                imageContext.DrawLines(Color.Blue, 5f, points4.ToArray());
            });

            await using var levelImageStream = new MemoryStream();
            await levelImage.SaveAsPngAsync(levelImageStream);
            var buffer = levelImageStream.GetBuffer();

            sw.Stop();
            Debug.WriteLine($"{sw.ElapsedMilliseconds}ms");

            return buffer;
        }

        private string BuildLevelName(string levelId)
        {
            return $"HexaMazeRetreat.Blazor.Levels.{levelId}.hexajson";
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