
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
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mapWidthToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.mapHeightToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
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
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(88, 979);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.mapWidthToolStripTextBox,
            this.mapHeightToolStripTextBox});
            this.toolStripDropDownButton1.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_dirt;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(83, 68);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_dirt;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(401, 76);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(401, 76);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(401, 76);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(401, 76);
            this.toolStripMenuItem4.Text = "toolStripMenuItem4";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(401, 76);
            this.toolStripMenuItem5.Text = "toolStripMenuItem5";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(83, 6);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17});
            this.toolStripDropDownButton2.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_grass;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(83, 68);
            this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_grass;
            this.toolStripMenuItem6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(515, 152);
            this.toolStripMenuItem6.Text = "Nature (not a path)";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_nature_1;
            this.toolStripMenuItem7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(515, 152);
            this.toolStripMenuItem7.Text = "Some fir trees (not a path)";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_nature_2;
            this.toolStripMenuItem8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(515, 152);
            this.toolStripMenuItem8.Text = "Many fir trees (not a path)";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_nature_3;
            this.toolStripMenuItem9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(515, 152);
            this.toolStripMenuItem9.Text = "Some trees (not a path)";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_nature_4;
            this.toolStripMenuItem10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(515, 152);
            this.toolStripMenuItem10.Text = "Many trees (not a path)";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_nature_5;
            this.toolStripMenuItem11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(515, 152);
            this.toolStripMenuItem11.Text = "Sand rocks (not a path)";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_nature_6;
            this.toolStripMenuItem12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(515, 152);
            this.toolStripMenuItem12.Text = "Little rocks (not a path)";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_nature_7;
            this.toolStripMenuItem13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(515, 152);
            this.toolStripMenuItem13.Text = "Big rock (not a path)";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_farm_1;
            this.toolStripMenuItem14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(515, 152);
            this.toolStripMenuItem14.Text = "Farm 1 (not a path)";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_farm_2;
            this.toolStripMenuItem15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(515, 152);
            this.toolStripMenuItem15.Text = "Farm 2 (not a path)";
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_farm_3;
            this.toolStripMenuItem16.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(515, 152);
            this.toolStripMenuItem16.Text = "Farm 3 (not a path)";
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_farm_4;
            this.toolStripMenuItem17.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(515, 152);
            this.toolStripMenuItem17.Text = "Farm 4 (not a path)";
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dirtToolStripMenuItem,
            this.marsToolStripMenuItem,
            this.sandToolStripMenuItem,
            this.stoneToolStripMenuItem});
            this.toolStripDropDownButton3.Image = global::HexaMazeRetreat.Editor.Properties.Resources.tile_mars;
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(83, 68);
            this.toolStripDropDownButton3.Text = "toolStripDropDownButton3";
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
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem dirtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox mapWidthToolStripTextBox;
        private System.Windows.Forms.ToolStripTextBox mapHeightToolStripTextBox;
    }
}

