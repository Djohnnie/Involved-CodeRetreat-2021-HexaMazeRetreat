namespace HexaMazeRetreat.Editor
{
    public class MazeTile
    {
        public int X { get; set; }
        public int Y { get; set; }
        public TileKind Kind { get; set; }
        public bool IsUsed { get; set; }

        public MazeTile(int x, int y, TileKind kind)
        {
            X = x;
            Y = y;
            Kind = kind;
            IsUsed = true;
        }

    }
}