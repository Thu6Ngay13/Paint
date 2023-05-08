namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblColorFill = new System.Windows.Forms.Label();
            this.cbbColorFill = new System.Windows.Forms.ComboBox();
            this.nmrSizeOutline = new System.Windows.Forms.NumericUpDown();
            this.cbbColorOutline = new System.Windows.Forms.ComboBox();
            this.rdbPullDrop = new System.Windows.Forms.RadioButton();
            this.rdbSelectPoint = new System.Windows.Forms.RadioButton();
            this.pnlPaper = new System.Windows.Forms.Panel();
            this.pnlSelect = new System.Windows.Forms.Panel();
            this.rdbSelectShape = new System.Windows.Forms.RadioButton();
            this.lblSizeOutline = new System.Windows.Forms.Label();
            this.lblColorOutline = new System.Windows.Forms.Label();
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnArc = new System.Windows.Forms.Button();
            this.btnPentagon = new System.Windows.Forms.Button();
            this.btnUnGroup = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnElipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSizeOutline)).BeginInit();
            this.pnlSelect.SuspendLayout();
            this.mnuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblColorFill
            // 
            this.lblColorFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblColorFill.Location = new System.Drawing.Point(159, 14);
            this.lblColorFill.Name = "lblColorFill";
            this.lblColorFill.Size = new System.Drawing.Size(86, 20);
            this.lblColorFill.TabIndex = 14;
            this.lblColorFill.Text = "Color Fill";
            // 
            // cbbColorFill
            // 
            this.cbbColorFill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbbColorFill.FormattingEnabled = true;
            this.cbbColorFill.Items.AddRange(new object[] {
            "None",
            System.Drawing.Color.Blue,
            System.Drawing.Color.Green,
            System.Drawing.Color.Red,
            System.Drawing.Color.Purple,
            System.Drawing.Color.Yellow,
            System.Drawing.Color.Black,
            System.Drawing.Color.Brown});
            this.cbbColorFill.Location = new System.Drawing.Point(279, 14);
            this.cbbColorFill.Name = "cbbColorFill";
            this.cbbColorFill.Size = new System.Drawing.Size(86, 24);
            this.cbbColorFill.TabIndex = 12;
            this.cbbColorFill.Text = "None";
            this.cbbColorFill.SelectedIndexChanged += new System.EventHandler(this.cbbColorFill_SelectedIndexChanged);
            // 
            // nmrSizeOutline
            // 
            this.nmrSizeOutline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.nmrSizeOutline.Location = new System.Drawing.Point(279, 70);
            this.nmrSizeOutline.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrSizeOutline.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSizeOutline.Name = "nmrSizeOutline";
            this.nmrSizeOutline.Size = new System.Drawing.Size(86, 22);
            this.nmrSizeOutline.TabIndex = 9;
            this.nmrSizeOutline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrSizeOutline.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrSizeOutline.ValueChanged += new System.EventHandler(this.nmrSizeOutline_ValueChanged);
            // 
            // cbbColorOutline
            // 
            this.cbbColorOutline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbbColorOutline.FormattingEnabled = true;
            this.cbbColorOutline.Items.AddRange(new object[] {
            System.Drawing.Color.Blue,
            System.Drawing.Color.Green,
            System.Drawing.Color.Red,
            System.Drawing.Color.Purple,
            System.Drawing.Color.Yellow,
            System.Drawing.Color.Black,
            System.Drawing.Color.Brown});
            this.cbbColorOutline.Location = new System.Drawing.Point(279, 42);
            this.cbbColorOutline.Name = "cbbColorOutline";
            this.cbbColorOutline.Size = new System.Drawing.Size(86, 24);
            this.cbbColorOutline.TabIndex = 8;
            this.cbbColorOutline.Text = "Blue";
            this.cbbColorOutline.SelectedIndexChanged += new System.EventHandler(this.cbbColorOutline_SelectedIndexChanged);
            // 
            // rdbPullDrop
            // 
            this.rdbPullDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rdbPullDrop.Location = new System.Drawing.Point(10, 70);
            this.rdbPullDrop.Name = "rdbPullDrop";
            this.rdbPullDrop.Size = new System.Drawing.Size(110, 20);
            this.rdbPullDrop.TabIndex = 7;
            this.rdbPullDrop.Text = "Kéo thả vẽ";
            this.rdbPullDrop.UseVisualStyleBackColor = false;
            this.rdbPullDrop.CheckedChanged += new System.EventHandler(this.rdbSelectShape_CheckedChanged);
            // 
            // rdbSelectPoint
            // 
            this.rdbSelectPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rdbSelectPoint.Location = new System.Drawing.Point(10, 42);
            this.rdbSelectPoint.Name = "rdbSelectPoint";
            this.rdbSelectPoint.Size = new System.Drawing.Size(110, 20);
            this.rdbSelectPoint.TabIndex = 6;
            this.rdbSelectPoint.Text = "Chọn điểm vẽ";
            this.rdbSelectPoint.UseVisualStyleBackColor = false;
            this.rdbSelectPoint.CheckedChanged += new System.EventHandler(this.rdbSelectShape_CheckedChanged);
            // 
            // pnlPaper
            // 
            this.pnlPaper.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlPaper.Location = new System.Drawing.Point(12, 155);
            this.pnlPaper.Name = "pnlPaper";
            this.pnlPaper.Size = new System.Drawing.Size(1337, 582);
            this.pnlPaper.TabIndex = 4;
            this.pnlPaper.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPaper_Paint);
            this.pnlPaper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlPaper_MouseClick);
            this.pnlPaper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlPaper_MouseDown);
            this.pnlPaper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlPaper_MouseMove);
            this.pnlPaper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlPaper_MouseUp);
            // 
            // pnlSelect
            // 
            this.pnlSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlSelect.Controls.Add(this.btnDelete);
            this.pnlSelect.Controls.Add(this.btnPolygon);
            this.pnlSelect.Controls.Add(this.btnArc);
            this.pnlSelect.Controls.Add(this.btnPentagon);
            this.pnlSelect.Controls.Add(this.btnUnGroup);
            this.pnlSelect.Controls.Add(this.btnGroup);
            this.pnlSelect.Controls.Add(this.rdbSelectShape);
            this.pnlSelect.Controls.Add(this.lblColorFill);
            this.pnlSelect.Controls.Add(this.cbbColorFill);
            this.pnlSelect.Controls.Add(this.lblSizeOutline);
            this.pnlSelect.Controls.Add(this.lblColorOutline);
            this.pnlSelect.Controls.Add(this.nmrSizeOutline);
            this.pnlSelect.Controls.Add(this.cbbColorOutline);
            this.pnlSelect.Controls.Add(this.rdbPullDrop);
            this.pnlSelect.Controls.Add(this.btnElipse);
            this.pnlSelect.Controls.Add(this.rdbSelectPoint);
            this.pnlSelect.Controls.Add(this.btnRectangle);
            this.pnlSelect.Controls.Add(this.btnLine);
            this.pnlSelect.Location = new System.Drawing.Point(12, 41);
            this.pnlSelect.Name = "pnlSelect";
            this.pnlSelect.Size = new System.Drawing.Size(1337, 108);
            this.pnlSelect.TabIndex = 3;
            // 
            // rdbSelectShape
            // 
            this.rdbSelectShape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.rdbSelectShape.Checked = true;
            this.rdbSelectShape.Location = new System.Drawing.Point(10, 14);
            this.rdbSelectShape.Name = "rdbSelectShape";
            this.rdbSelectShape.Size = new System.Drawing.Size(110, 20);
            this.rdbSelectShape.TabIndex = 15;
            this.rdbSelectShape.TabStop = true;
            this.rdbSelectShape.Text = "Chọn hình";
            this.rdbSelectShape.UseVisualStyleBackColor = false;
            this.rdbSelectShape.CheckedChanged += new System.EventHandler(this.rdbSelectShape_CheckedChanged);
            // 
            // lblSizeOutline
            // 
            this.lblSizeOutline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblSizeOutline.Location = new System.Drawing.Point(159, 70);
            this.lblSizeOutline.Name = "lblSizeOutline";
            this.lblSizeOutline.Size = new System.Drawing.Size(86, 20);
            this.lblSizeOutline.TabIndex = 11;
            this.lblSizeOutline.Text = "Size Outline";
            // 
            // lblColorOutline
            // 
            this.lblColorOutline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblColorOutline.Location = new System.Drawing.Point(159, 42);
            this.lblColorOutline.Name = "lblColorOutline";
            this.lblColorOutline.Size = new System.Drawing.Size(86, 20);
            this.lblColorOutline.TabIndex = 10;
            this.lblColorOutline.Text = "Color Outline ";
            // 
            // mnuFile
            // 
            this.mnuFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(1361, 28);
            this.mnuFile.TabIndex = 5;
            this.mnuFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newFileToolStripMenuItem.Text = "New file";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDelete.BackgroundImage = global::Paint.Properties.Resources.ic_delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(493, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(41, 43);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPolygon.BackgroundImage = global::Paint.Properties.Resources.ic_polygon;
            this.btnPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPolygon.Location = new System.Drawing.Point(587, 9);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(41, 43);
            this.btnPolygon.TabIndex = 21;
            this.btnPolygon.UseVisualStyleBackColor = false;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // btnArc
            // 
            this.btnArc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnArc.BackgroundImage = global::Paint.Properties.Resources.ic_arc;
            this.btnArc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArc.Location = new System.Drawing.Point(634, 9);
            this.btnArc.Name = "btnArc";
            this.btnArc.Size = new System.Drawing.Size(41, 43);
            this.btnArc.TabIndex = 19;
            this.btnArc.UseVisualStyleBackColor = false;
            this.btnArc.Click += new System.EventHandler(this.btnArc_Click);
            // 
            // btnPentagon
            // 
            this.btnPentagon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPentagon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPentagon.BackgroundImage")));
            this.btnPentagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPentagon.Location = new System.Drawing.Point(540, 9);
            this.btnPentagon.Name = "btnPentagon";
            this.btnPentagon.Size = new System.Drawing.Size(41, 43);
            this.btnPentagon.TabIndex = 18;
            this.btnPentagon.UseVisualStyleBackColor = false;
            this.btnPentagon.Click += new System.EventHandler(this.btnPentagon_Click);
            // 
            // btnUnGroup
            // 
            this.btnUnGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUnGroup.BackgroundImage = global::Paint.Properties.Resources.ic_ungroup;
            this.btnUnGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnGroup.Location = new System.Drawing.Point(446, 58);
            this.btnUnGroup.Name = "btnUnGroup";
            this.btnUnGroup.Size = new System.Drawing.Size(41, 43);
            this.btnUnGroup.TabIndex = 17;
            this.btnUnGroup.UseVisualStyleBackColor = false;
            this.btnUnGroup.Click += new System.EventHandler(this.btnUnGroup_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGroup.BackgroundImage = global::Paint.Properties.Resources.ic_group;
            this.btnGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGroup.Location = new System.Drawing.Point(399, 57);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(41, 43);
            this.btnGroup.TabIndex = 16;
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnElipse
            // 
            this.btnElipse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnElipse.BackgroundImage = global::Paint.Properties.Resources.ic_ellipse;
            this.btnElipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnElipse.Location = new System.Drawing.Point(493, 9);
            this.btnElipse.Name = "btnElipse";
            this.btnElipse.Size = new System.Drawing.Size(41, 43);
            this.btnElipse.TabIndex = 4;
            this.btnElipse.UseVisualStyleBackColor = false;
            this.btnElipse.Click += new System.EventHandler(this.btnElipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnRectangle.BackgroundImage = global::Paint.Properties.Resources.ic_rectangle;
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRectangle.Location = new System.Drawing.Point(446, 9);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(41, 43);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLine.BackgroundImage = global::Paint.Properties.Resources.ic_line;
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLine.Location = new System.Drawing.Point(399, 9);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(41, 43);
            this.btnLine.TabIndex = 0;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1361, 749);
            this.Controls.Add(this.pnlPaper);
            this.Controls.Add(this.pnlSelect);
            this.Controls.Add(this.mnuFile);
            this.MainMenuStrip = this.mnuFile;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmrSizeOutline)).EndInit();
            this.pnlSelect.ResumeLayout(false);
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbColorFill;
        private System.Windows.Forms.ComboBox cbbColorOutline;
        private System.Windows.Forms.RadioButton rdbPullDrop;
        private System.Windows.Forms.RadioButton rdbSelectPoint;
        private System.Windows.Forms.RadioButton rdbSelectShape;
        private System.Windows.Forms.NumericUpDown nmrSizeOutline;
        private System.Windows.Forms.Button btnElipse;
        private System.Windows.Forms.Button btnUnGroup;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnPentagon;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Panel pnlPaper;
        private System.Windows.Forms.Panel pnlSelect;
        private System.Windows.Forms.Label lblSizeOutline;
        private System.Windows.Forms.Label lblColorOutline;
        private System.Windows.Forms.Label lblColorFill;
        private System.Windows.Forms.Button btnArc;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    }
}

