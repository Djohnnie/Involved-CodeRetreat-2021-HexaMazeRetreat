using System;
using HexaMazeRetreat.Domain;
using SixLabors.ImageSharp;
using System.Collections.Concurrent;
using SixLabors.ImageSharp.Processing;

namespace HexaMazeRetreat.Blazor.Helpers
{
    public class GraphicsCacheHelper
    {
        private readonly ConcurrentDictionary<TileKind, Image> _graphicsCache = new();
        private readonly ConcurrentDictionary<string, Image> _levelCache = new();

        public Image GetImageByTileKind(TileKind tileKind, int tileSize)
        {
            if (_graphicsCache.ContainsKey(tileKind))
            {
                return _graphicsCache[tileKind];
            }

            var resourceName = GetResourceNameByTileKind(tileKind);
            var tileImageStream = EmbeddedResourceHelper.GetGraphicsByResourceName(resourceName);
            var tileImage = Image.Load(tileImageStream);
            tileImage.Mutate(x => x.Resize(tileSize, tileSize));
            _graphicsCache.TryAdd(tileKind, tileImage);

            return tileImage;
        }

        public Image GetLevelByName(string levelName, Func<Image> levelFactory)
        {
            if (_levelCache.ContainsKey(levelName))
            {
                return _levelCache[levelName];
            }

            var levelImage = levelFactory();
            _levelCache.TryAdd(levelName, levelImage);
            return levelImage;
        }

        private string GetResourceNameByTileKind(TileKind tileKind)
        {
            var fileName = tileKind switch
            {
                TileKind.Empty => "tile_frame",
                TileKind.Grass => "tile_grass",
                TileKind.Dirt => "tile_dirt",
                TileKind.Stone => "tile_stone",
                TileKind.Sand => "tile_sand",
                TileKind.Mars => "tile_mars",
                TileKind.Trees1 => "tile_nature_1",
                TileKind.Trees2 => "tile_nature_2",
                TileKind.Trees3 => "tile_nature_3",
                TileKind.Trees4 => "tile_nature_4",
                TileKind.Rocks1 => "tile_nature_5",
                TileKind.Rocks2 => "tile_nature_6",
                TileKind.Rocks3 => "tile_nature_7",
                TileKind.Farm1 => "tile_farm_1",
                TileKind.Farm2 => "tile_farm_2",
                TileKind.Farm3 => "tile_farm_3",
                TileKind.Farm4 => "tile_farm_4",
                TileKind.Start => "tile_start",
                TileKind.Finish => "tile_finish",
                _ => "tile_frame"
            };

            return $"HexaMazeRetreat.Blazor.Graphics.{fileName}.png";
        }
    }
}