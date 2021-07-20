using System.Drawing;
using System.Windows.Forms;
using Resources = HexaMazeRetreat.Editor.Properties.Resources;

namespace HexaMazeRetreat.Editor
{
    public partial class EditorControl : UserControl
    {
        private readonly Bitmap _tileFrame = new Bitmap(Resources.tile_frame);
        private readonly Bitmap _tileDirt = new Bitmap(Resources.tile_dirt);
        private readonly Bitmap _tileMars = new Bitmap(Resources.tile_mars);
        private readonly Bitmap _tileSand = new Bitmap(Resources.tile_sand);
        private readonly Bitmap _tileStone = new Bitmap(Resources.tile_stone);
        private readonly Bitmap _tileGrass = new Bitmap(Resources.tile_grass);

        private Point? _cursorLocation;
        private Point? _mapOffset;

        private MazeMap _map;

        public TileKind ActiveEditTile { get; set; }

        public int MapWidth
        {
            get { return _map.Width; }
            set
            {
                _map.Width = value;
                Invalidate();
            }
        }

        public int MapHeight
        {
            get { return _map.Height; }
            set
            {
                _map.Height = value;
                Invalidate();
            }
        }

        public EditorControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            _map = new MazeMap(10, 10);
        }

        private void EditorControl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            foreach (var mazeTile in _map)
            {
                if (mazeTile.IsUsed)
                {
                    var tileBitmap = ResolveTileBitmap(mazeTile.Kind);
                    Rectangle bounds = CalculateBounds(mazeTile.X, mazeTile.Y);

                    if (_cursorLocation.HasValue)
                    {
                        if (bounds.Contains(_cursorLocation.Value))
                        {
                            tileBitmap = ResolveTileBitmap(ActiveEditTile);
                        }
                    }

                    e.Graphics.DrawImage(tileBitmap, bounds);

                    if (mazeTile.Kind == TileKind.Empty)
                    {
                        var format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                        e.Graphics.DrawString($"({mazeTile.X},{mazeTile.Y})", SystemFonts.DefaultFont, Brushes.Black, bounds, format);
                    }
                }
            }
        }

        private Rectangle CalculateBounds(int x, int y)
        {
            var tileWidth = _tileFrame.Width;
            var tileHeight = _tileFrame.Height;

            var xOffset = (y % 2 == 0 ? 0 : tileWidth / 2) + x * tileWidth + (_mapOffset.HasValue ? _mapOffset.Value.X : 0);
            var yOffset = y * (tileHeight - tileHeight / 4) + (_mapOffset.HasValue ? _mapOffset.Value.Y : 0);
            var bounds = new Rectangle(xOffset, yOffset, tileWidth, tileHeight);

            return bounds;
        }

        private Bitmap ResolveTileBitmap(TileKind tileKind)
        {
            return tileKind switch
            {
                TileKind.Dirt => _tileDirt,
                TileKind.Mars => _tileMars,
                TileKind.Sand => _tileSand,
                TileKind.Stone => _tileStone,
                TileKind.Grass => _tileGrass,
                _ => _tileFrame,
            };
        }

        private MazeTile GetMazeTileFromLocation(Point location)
        {
            foreach (var tile in _map)
            {
                var bounds = CalculateBounds(tile.X, tile.Y);

                if (bounds.Contains(location))
                {
                    return tile;
                }
            }

            return null;
        }

        private void EditorControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var mazeTile = GetMazeTileFromLocation(e.Location);

                if (mazeTile != null)
                {
                    mazeTile.Kind = ActiveEditTile;
                }
            }

            if (e.Button == MouseButtons.Right && _cursorLocation.HasValue)
            {
                if (!_mapOffset.HasValue)
                {
                    _mapOffset = new Point(0, 0);
                }

                _mapOffset = new Point(
                    _mapOffset.Value.X + (e.Location.X - _cursorLocation.Value.X),
                    _mapOffset.Value.Y + (e.Location.Y - _cursorLocation.Value.Y));
            }

            _cursorLocation = e.Location;

            Invalidate();
        }

        private void EditorControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var mazeTile = GetMazeTileFromLocation(e.Location);

                if (mazeTile != null)
                {
                    mazeTile.Kind = ActiveEditTile;
                }
            }
        }
    }
}