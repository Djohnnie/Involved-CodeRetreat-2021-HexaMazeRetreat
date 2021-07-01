using System.Drawing;
using System.Windows.Forms;

namespace HexaMazeRetreat.Editor
{
    public partial class EditorControl : UserControl
    {
        private readonly Bitmap _tileFrame = new Bitmap(Properties.Resources.tile_frame);

        public int MapWidth { get; set; }
        public int MapHeight { get; set; }

        public EditorControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            MapHeight = 10;
            MapWidth = 10;
        }

        private void EditorControl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            for (var x = 0; x < MapWidth; x++)
            {
                for (var y = 0; y < MapHeight; y++)
                {
                    var xOffset = (y % 2 == 0 ? 0 : _tileFrame.Width / 2) + x * (_tileFrame.Width);
                    var yOffset = y * (_tileFrame.Height - _tileFrame.Height / 4);
                    var bounds = new Rectangle(xOffset, yOffset, _tileFrame.Width, _tileFrame.Height);
                    e.Graphics.DrawImage(_tileFrame, bounds);
                }
            }
        }
    }
}