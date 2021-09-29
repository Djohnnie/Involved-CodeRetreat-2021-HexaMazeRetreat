
namespace HexaMazeRetreat.Editor
{
    partial class EditorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.commonToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mapWidthToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.mapHeightToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.natureTilesToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.grassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firTreesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manyFirTreesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manyTreesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sandRocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.littleRocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigRockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farm1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farm2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farm3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farm4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groundTilesToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.dirtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mazeEditor = new HexaMazeRetreat.Editor.EditorControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mazeEditor, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1997, 1079);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commonToolStripDropDownButton,
            this.toolStripSeparator,
            this.natureTilesToolStripDropDownButton,
            this.groundTilesToolStripDropDownButton,
            this.toolStripDropDownButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(88, 979);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStrip1_Paint);
            // 
            // commonToolStripDropDownButton
            // 
            this.commonToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.commonToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.mapWidthToolStripTextBox,
            this.mapHeightToolStripTextBox});
            this.commonToolStripDropDownButton.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_dirt;
            this.commonToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.commonToolStripDropDownButton.Name = "commonToolStripDropDownButton";
            this.commonToolStripDropDownButton.Size = new System.Drawing.Size(83, 68);
            this.commonToolStripDropDownButton.Text = "toolStripDropDownButton1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_dirt;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(369, 44);
            this.newToolStripMenuItem.Text = "Create new map";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(369, 44);
            this.openToolStripMenuItem.Text = "Open existing map";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(369, 44);
            this.saveToolStripMenuItem.Text = "Save current map";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(366, 6);
            // 
            // mapWidthToolStripTextBox
            // 
            this.mapWidthToolStripTextBox.AutoSize = false;
            this.mapWidthToolStripTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.mapWidthToolStripTextBox.Name = "mapWidthToolStripTextBox";
            this.mapWidthToolStripTextBox.Size = new System.Drawing.Size(250, 39);
            this.mapWidthToolStripTextBox.TextChanged += new System.EventHandler(this.mapWidthToolStripTextBox_TextChanged);
            // 
            // mapHeightToolStripTextBox
            // 
            this.mapHeightToolStripTextBox.AutoSize = false;
            this.mapHeightToolStripTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.mapHeightToolStripTextBox.Name = "mapHeightToolStripTextBox";
            this.mapHeightToolStripTextBox.Size = new System.Drawing.Size(250, 39);
            this.mapHeightToolStripTextBox.TextChanged += new System.EventHandler(this.mapHeightToolStripTextBox_TextChanged);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(83, 6);
            // 
            // natureTilesToolStripDropDownButton
            // 
            this.natureTilesToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.natureTilesToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grassToolStripMenuItem,
            this.firTreesToolStripMenuItem,
            this.manyFirTreesToolStripMenuItem,
            this.treesToolStripMenuItem,
            this.manyTreesToolStripMenuItem,
            this.sandRocksToolStripMenuItem,
            this.littleRocksToolStripMenuItem,
            this.bigRockToolStripMenuItem,
            this.farm1ToolStripMenuItem,
            this.farm2ToolStripMenuItem,
            this.farm3ToolStripMenuItem,
            this.farm4ToolStripMenuItem});
            this.natureTilesToolStripDropDownButton.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_grass;
            this.natureTilesToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.natureTilesToolStripDropDownButton.Name = "natureTilesToolStripDropDownButton";
            this.natureTilesToolStripDropDownButton.Size = new System.Drawing.Size(83, 68);
            this.natureTilesToolStripDropDownButton.Text = "toolStripDropDownButton2";
            // 
            // grassToolStripMenuItem
            // 
            this.grassToolStripMenuItem.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_grass;
            this.grassToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.grassToolStripMenuItem.Name = "grassToolStripMenuItem";
            this.grassToolStripMenuItem.Size = new System.Drawing.Size(515, 152);
            this.grassToolStripMenuItem.Text = "Nature (not a path)";
            this.grassToolStripMenuItem.Click += new System.EventHandler(this.grassToolStripMenuItem_Click);
            // 
            // firTreesToolStripMenuItem
            // 
            this.firTreesToolStripMenuItem.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_nature_1;
            this.firTreesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.firTreesToolStripMenuItem.Name = "firTreesToolStripMenuItem";
            this.firTreesToolStripMenuItem.Size = new System.Drawing.Size(515, 152);
            this.firTreesToolStripMenuItem.Text = "Some fir trees (not a path)";
            this.firTreesToolStripMenuItem.Click += new System.EventHandler(this.firTreesToolStripMenuItem_Click);
            // 
            // manyFirTreesToolStripMenuItem
            // 
            this.manyFirTreesToolStripMenuItem.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_nature_2;
            this.manyFirTreesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manyFirTreesToolStripMenuItem.Name = "manyFirTreesToolStripMenuItem";
            this.manyFirTreesToolStripMenuItem.Size = new System.Drawing.Size(515, 152);
            this.manyFirTreesToolStripMenuItem.Text = "Many fir trees (not a path)";
            this.manyFirTreesToolStripMenuItem.Click += new System.EventHandler(this.manyFirTreesToolStripMenuItem_Click);
            // 
            // treesToolStripMenuItem
            // 
            this.treesToolStripMenuItem.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_nature_3;
            this.treesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.treesToolStripMenuItem.Name = "treesToolStripMenuItem";
            this.treesToolStripMenuItem.Size = new System.Drawing.Size(515, 152);
            this.treesToolStripMenuItem.Text = "Some trees (not a path)";
            this.treesToolStripMenuItem.Click += new System.EventHandler(this.treesToolStripMenuItem_Click);
            // 
            // manyTreesToolStripMenuItem
            // 
            this.manyTreesToolStripMenuItem.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_nature_4;
            this.manyTreesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manyTreesToolStripMenuItem.Name = "manyTreesToolStripMenuItem";
            this.manyTreesToolStripMenuItem.Size = new System.Drawing.Size(515, 152);
            this.manyTreesToolStripMenuItem.Text = "Many trees (not a path)";
            this.manyTreesToolStripMenuItem.Click += new System.EventHandler(this.manyTreesToolStripMenuItem_Click);
            // 
            // sandRocksToolStripMenuItem
            // 
            this.sandRocksToolStripMenuItem.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_nature_5;
            this.sandRocksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sandRocksToolStripMenuItem.Name = "sandRocksToolStripMenuItem";
            this.sandRocksToolStripMenuItem.Size = new System.Drawing.Size(515, 152);
            this.sandRocksToolStripMenuItem.Text = "Sand rocks (not a path)";
            this.sandRocksToolStripMenuItem.Click += new System.EventHandler(this.sandRocksToolStripMenuItem_Click);
            // 
            // littleRocksToolStripMenuItem
            // 
            this.littleRocksToolStripMenuItem.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_nature_6;
            this.littleRocksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.littleRocksToolStripMenuItem.Name = "littleRocksToolStripMenuItem";
            this.littleRocksToolStripMenuItem.Size = new System.Drawing.Size(515, 152);
            this.littleRocksToolStripMenuItem.Text = "Little rocks (not a path)";
            this.littleRocksToolStripMenuItem.Click += new System.EventHandler(this.littleRocksToolStripMenuItem_Click);
            // 
            // bigRockToolStripMenuItem
            // 
            this.bigRockToolStripMenuItem.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_nature_7;
            this.bigRockToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bigRockToolStripMenuItem.Name = "bigRockToolStripMenuItem";
            this.bigRockToolStripMenuItem.Size = new System.Drawing.Size(515, 152);
            this.bigRockToolStripMenuItem.Text = "Big rock (not a path)";
            this.bigRockToolStripMenuItem.Click += new System.EventHandler(this.bigRockToolStripMenuItem_Click);
            // 
            // farm1ToolStripMenuItem
            // 
            this.farm1ToolStripMenuItem.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_farm_1;
            this.farm1ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.farm1ToolStripMenuItem.Name = "farm1ToolStripMenuItem";
            this.farm1ToolStripMenuItem.Size = new System.Drawing.Size(515, 152);
            this.farm1ToolStripMenuItem.Text = "Farm 1 (not a path)";
            this.farm1ToolStripMenuItem.Click += new System.EventHandler(this.farm1ToolStripMenuItem_Click);
            // 
            // farm2ToolStripMenuItem
            // 
            this.farm2ToolStripMenuItem.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_farm_2;
            this.farm2ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.farm2ToolStripMenuItem.Name = "farm2ToolStripMenuItem";
            this.farm2ToolStripMenuItem.Size = new System.Drawing.Size(515, 152);
            this.farm2ToolStripMenuItem.Text = "Farm 2 (not a path)";
            this.farm2ToolStripMenuItem.Click += new System.EventHandler(this.farm2ToolStripMenuItem_Click);
            // 
            // farm3ToolStripMenuItem
            // 
            this.farm3ToolStripMenuItem.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_farm_3;
            this.farm3ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.farm3ToolStripMenuItem.Name = "farm3ToolStripMenuItem";
            this.farm3ToolStripMenuItem.Size = new System.Drawing.Size(515, 152);
            this.farm3ToolStripMenuItem.Text = "Farm 3 (not a path)";
            this.farm3ToolStripMenuItem.Click += new System.EventHandler(this.farm3ToolStripMenuItem_Click);
            // 
            // farm4ToolStripMenuItem
            // 
            this.farm4ToolStripMenuItem.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_farm_4;
            this.farm4ToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.farm4ToolStripMenuItem.Name = "farm4ToolStripMenuItem";
            this.farm4ToolStripMenuItem.Size = new System.Drawing.Size(515, 152);
            this.farm4ToolStripMenuItem.Text = "Farm 4 (not a path)";
            this.farm4ToolStripMenuItem.Click += new System.EventHandler(this.farm4ToolStripMenuItem_Click);
            // 
            // groundTilesToolStripDropDownButton
            // 
            this.groundTilesToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groundTilesToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dirtToolStripMenuItem,
            this.marsToolStripMenuItem,
            this.sandToolStripMenuItem,
            this.stoneToolStripMenuItem});
            this.groundTilesToolStripDropDownButton.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_mars;
            this.groundTilesToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.groundTilesToolStripDropDownButton.Name = "groundTilesToolStripDropDownButton";
            this.groundTilesToolStripDropDownButton.Size = new System.Drawing.Size(83, 68);
            this.groundTilesToolStripDropDownButton.Text = "toolStripDropDownButton3";
            // 
            // dirtToolStripMenuItem
            // 
            this.dirtToolStripMenuItem.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_dirt;
            this.dirtToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dirtToolStripMenuItem.Name = "dirtToolStripMenuItem";
            this.dirtToolStripMenuItem.Size = new System.Drawing.Size(351, 152);
            this.dirtToolStripMenuItem.Text = "Dirt path";
            this.dirtToolStripMenuItem.Click += new System.EventHandler(this.dirtToolStripMenuItem_Click);
            // 
            // marsToolStripMenuItem
            // 
            this.marsToolStripMenuItem.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_mars;
            this.marsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.marsToolStripMenuItem.Name = "marsToolStripMenuItem";
            this.marsToolStripMenuItem.Size = new System.Drawing.Size(351, 152);
            this.marsToolStripMenuItem.Text = "Mars path";
            this.marsToolStripMenuItem.Click += new System.EventHandler(this.marsToolStripMenuItem_Click);
            // 
            // sandToolStripMenuItem
            // 
            this.sandToolStripMenuItem.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_sand;
            this.sandToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sandToolStripMenuItem.Name = "sandToolStripMenuItem";
            this.sandToolStripMenuItem.Size = new System.Drawing.Size(351, 152);
            this.sandToolStripMenuItem.Text = "Sand path";
            this.sandToolStripMenuItem.Click += new System.EventHandler(this.sandToolStripMenuItem_Click);
            // 
            // stoneToolStripMenuItem
            // 
            this.stoneToolStripMenuItem.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_stone;
            this.stoneToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stoneToolStripMenuItem.Name = "stoneToolStripMenuItem";
            this.stoneToolStripMenuItem.Size = new System.Drawing.Size(351, 152);
            this.stoneToolStripMenuItem.Text = "Stone path";
            this.stoneToolStripMenuItem.Click += new System.EventHandler(this.stoneToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(83, 68);
            this.toolStripDropDownButton4.Text = "toolStripDropDownButton4";
            // 
            // mazeEditor
            // 
            this.mazeEditor.ActiveEditTile = HexaMazeRetreat.Editor.TileKind.Empty;
            this.mazeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mazeEditor.Location = new System.Drawing.Point(91, 3);
            this.mazeEditor.MapHeight = 10;
            this.mazeEditor.MapWidth = 10;
            this.mazeEditor.Name = "mazeEditor";
            this.mazeEditor.Size = new System.Drawing.Size(1903, 973);
            this.mazeEditor.TabIndex = 1;
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1997, 1079);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditorForm";
            this.Text = "HexaMazeRetreat - EDITOR";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private EditorControl mazeEditor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton commonToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripDropDownButton natureTilesToolStripDropDownButton;
        private System.Windows.Forms.ToolStripDropDownButton groundTilesToolStripDropDownButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem grassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firTreesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manyFirTreesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manyTreesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sandRocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem littleRocksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigRockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farm1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farm2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farm3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farm4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dirtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox mapWidthToolStripTextBox;
        private System.Windows.Forms.ToolStripTextBox mapHeightToolStripTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

