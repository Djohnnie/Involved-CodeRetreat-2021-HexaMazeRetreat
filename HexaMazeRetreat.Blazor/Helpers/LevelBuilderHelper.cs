using System.Collections.Generic;
using System.Diagnostics;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using HexaMazeRetreat.Domain;

namespace HexaMazeRetreat.Blazor.Helpers
{
    public class LevelBuilderHelper
    {
        private const int TILE_SIZE = 128;

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