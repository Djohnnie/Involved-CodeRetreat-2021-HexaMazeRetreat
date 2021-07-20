using System;
using System.Windows.Forms;

namespace HexaMazeRetreat.Editor
{
    public partial class EditorForm : Form
    {
        public EditorForm()
        {
            InitializeComponent();
        }

        private void dirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveEditTile(TileKind.Dirt);
        }

        private void marsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveEditTile(TileKind.Mars);
        }

        private void sandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveEditTile(TileKind.Sand);
        }

        private void stoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveEditTile(TileKind.Stone);
        }

        private void SetActiveEditTile(TileKind tileKind)
        {
            mazeEditor.ActiveEditTile = tileKind;
        }

        private void mapWidthToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var width = Convert.ToInt32(mapWidthToolStripTextBox.Text);
                mazeEditor.MapWidth = width;
            }
            catch { /* Ignore formatting exceptions */ }
        }

        private void mapHeightToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var height = Convert.ToInt32(mapHeightToolStripTextBox.Text);
                mazeEditor.MapHeight = height;
            }
            catch { /* Ignore formatting exceptions */ }
        }
    }
}