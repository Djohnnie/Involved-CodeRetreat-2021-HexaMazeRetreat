using System.Collections.Generic;
using System.Linq;

namespace HexaMazeRetreat.Domain
{
    public class MazeMap : List<MazeTile>
    {
        public MazeTile this[int x, int y]
        {
            get
            {
                return this.SingleOrDefault(t => t.X == x && t.Y == y);
            }
        }

        public int Width
        {
            get
            {
                return this.Where(t => t.IsUsed).Max(t => t.X) + 1;
            }
            set
            {
                Rebuild(value, Height);
            }
        }

        public int Height
        {
            get
            {
                return this.Where(t => t.IsUsed).Max(t => t.Y) + 1;
            }
            set
            {
                Rebuild(Width, value);
            }
        }

        public MazeMap() { }

        public MazeMap(int width, int height)
        {
            Rebuild(width, height);
        }

        private void Rebuild(int width, int height)
        {
            ForEach(t => t.IsUsed = false);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < (y % 2 == 0 ? width : width - 1); x++)
                {
                    var existingTile = this.SingleOrDefault(t => t.X == x && t.Y == y);

                    if (existingTile == null)
                    {
                        Add(new MazeTile(x, y, TileKind.Grass));
                    }
                    else
                    {
                        existingTile.IsUsed = true;
                    }
                }
            }
        }
    }
}