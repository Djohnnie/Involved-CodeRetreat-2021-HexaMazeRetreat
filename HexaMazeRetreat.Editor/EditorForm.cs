using System;
using System.IO;
using System.Windows.Forms;
using HexaMazeRetreat.Domain;

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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mazeEditor.CreateNew();
        }

        private async void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "HexaMazeRetreat files (*.hexajson)|*.hexajson";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string data = await File.ReadAllTextAsync(openFileDialog.FileName);
                mazeEditor.OpenExisting(data);
            }
        }

        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "HexaMazeRetreat files (*.hexajson)|*.hexajson";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string data = mazeEditor.SaveCurrent();
                await File.WriteAllTextAsync(saveFileDialog.FileName, data);
            }
        }

        private void toolStrip1_Paint(object sender, PaintEventArgs e)
        {
            const int iconSize = 120;
            if (e.ClipRectangle.IntersectsWith(mapHeightToolStripTextBox.Bounds))
            {
                float x = (26 / 2) - (iconSize / 2);
                float y = mapHeightToolStripTextBox.Bounds.Y + ((mapHeightToolStripTextBox.Bounds.Height / 2) - (iconSize / 2));
                e.Graphics.DrawImage(Properties.Resources.tile_dirt, x, y);
            }
        }

        private void grassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveEditTile(TileKind.Grass);
        }

        private void firTreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveEditTile(TileKind.Trees1);
        }

        private void manyFirTreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveEditTile(TileKind.Trees2);
        }

        private void treesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveEditTile(TileKind.Trees3);
        }

        private void manyTreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveEditTile(TileKind.Trees4);
        }

        private void sandRocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveEditTile(TileKind.Rocks1);
        }

        private void littleRocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveEditTile(TileKind.Rocks2);
        }

        private void bigRockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveEditTile(TileKind.Rocks3);
        }

        private void farm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveEditTile(TileKind.Farm1);
        }

        private void farm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveEditTile(TileKind.Farm2);
        }

        private void farm3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveEditTile(TileKind.Farm3);
        }

        private void farm4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveEditTile(TileKind.Farm4);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveEditTile(TileKind.Start);
        }

        private void finishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActiveEditTile(TileKind.Finish);
        }

        private void SetActiveEditTile(TileKind tileKind)
        {
            mazeEditor.ActiveEditTile = tileKind;
        }

        private void EditorForm_Load(object sender, EventArgs e)
        {

        }
    }
}