namespace 그림판
{
    partial class Drawing
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_newfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_savefile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_openfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.도형ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_drawcircle = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_drawrectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_drawline = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_drawpen = new System.Windows.Forms.ToolStripMenuItem();
            this.모두지우기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_color = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_lineheight = new System.Windows.Forms.ToolStripMenuItem();
            this.굵기10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.굵기5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.굵기3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.굵기1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선종류ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashdotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.배경색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도형ToolStripMenuItem,
            this.서식ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(799, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_newfile,
            this.menu_savefile,
            this.menu_openfile,
            this.menu_exit});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // menu_newfile
            // 
            this.menu_newfile.Name = "menu_newfile";
            this.menu_newfile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menu_newfile.Size = new System.Drawing.Size(208, 24);
            this.menu_newfile.Text = "새로만들기";
            this.menu_newfile.Click += new System.EventHandler(this.menu_newfile_Click);
            // 
            // menu_savefile
            // 
            this.menu_savefile.Name = "menu_savefile";
            this.menu_savefile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menu_savefile.Size = new System.Drawing.Size(208, 24);
            this.menu_savefile.Text = "저장";
            this.menu_savefile.Click += new System.EventHandler(this.menu_savefile_Click);
            // 
            // menu_openfile
            // 
            this.menu_openfile.Name = "menu_openfile";
            this.menu_openfile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menu_openfile.Size = new System.Drawing.Size(208, 24);
            this.menu_openfile.Text = "불러오기";
            this.menu_openfile.Click += new System.EventHandler(this.menu_openfile_Click);
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.menu_exit.Size = new System.Drawing.Size(208, 24);
            this.menu_exit.Text = "끝내기";
            this.menu_exit.Click += new System.EventHandler(this.menu_exit_Click);
            // 
            // 도형ToolStripMenuItem
            // 
            this.도형ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_drawcircle,
            this.menu_drawrectangle,
            this.menu_drawline,
            this.menu_drawpen,
            this.모두지우기ToolStripMenuItem});
            this.도형ToolStripMenuItem.Name = "도형ToolStripMenuItem";
            this.도형ToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.도형ToolStripMenuItem.Text = "그리기";
            // 
            // menu_drawcircle
            // 
            this.menu_drawcircle.Name = "menu_drawcircle";
            this.menu_drawcircle.Size = new System.Drawing.Size(158, 24);
            this.menu_drawcircle.Text = "원(ㅇ)";
            this.menu_drawcircle.Click += new System.EventHandler(this.menu_drawcircle_Click);
            // 
            // menu_drawrectangle
            // 
            this.menu_drawrectangle.Name = "menu_drawrectangle";
            this.menu_drawrectangle.Size = new System.Drawing.Size(158, 24);
            this.menu_drawrectangle.Text = "사각형(ㅁ)";
            this.menu_drawrectangle.Click += new System.EventHandler(this.menu_drawrectangle_Click);
            // 
            // menu_drawline
            // 
            this.menu_drawline.Name = "menu_drawline";
            this.menu_drawline.Size = new System.Drawing.Size(158, 24);
            this.menu_drawline.Text = "선(-)";
            this.menu_drawline.Click += new System.EventHandler(this.menu_drawline_Click);
            // 
            // menu_drawpen
            // 
            this.menu_drawpen.Name = "menu_drawpen";
            this.menu_drawpen.Size = new System.Drawing.Size(158, 24);
            this.menu_drawpen.Text = "펜";
            this.menu_drawpen.Click += new System.EventHandler(this.menu_drawpen_Click);
            // 
            // 모두지우기ToolStripMenuItem
            // 
            this.모두지우기ToolStripMenuItem.Name = "모두지우기ToolStripMenuItem";
            this.모두지우기ToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.모두지우기ToolStripMenuItem.Text = "모두 지우기";
            this.모두지우기ToolStripMenuItem.Click += new System.EventHandler(this.모두지우기ToolStripMenuItem_Click);
            // 
            // 서식ToolStripMenuItem
            // 
            this.서식ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_color,
            this.menu_lineheight,
            this.선종류ToolStripMenuItem,
            this.배경색ToolStripMenuItem});
            this.서식ToolStripMenuItem.Name = "서식ToolStripMenuItem";
            this.서식ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.서식ToolStripMenuItem.Text = "서식";
            // 
            // menu_color
            // 
            this.menu_color.Name = "menu_color";
            this.menu_color.Size = new System.Drawing.Size(175, 24);
            this.menu_color.Text = "선 색상";
            this.menu_color.Click += new System.EventHandler(this.menu_color_Click);
            // 
            // menu_lineheight
            // 
            this.menu_lineheight.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.굵기10ToolStripMenuItem,
            this.굵기5ToolStripMenuItem,
            this.굵기3ToolStripMenuItem,
            this.굵기1ToolStripMenuItem});
            this.menu_lineheight.Name = "menu_lineheight";
            this.menu_lineheight.Size = new System.Drawing.Size(128, 24);
            this.menu_lineheight.Text = "선 굵기";
            // 
            // 굵기10ToolStripMenuItem
            // 
            this.굵기10ToolStripMenuItem.Name = "굵기10ToolStripMenuItem";
            this.굵기10ToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.굵기10ToolStripMenuItem.Text = "굵기(10)";
            this.굵기10ToolStripMenuItem.Click += new System.EventHandler(this.굵기10ToolStripMenuItem_Click);
            // 
            // 굵기5ToolStripMenuItem
            // 
            this.굵기5ToolStripMenuItem.Name = "굵기5ToolStripMenuItem";
            this.굵기5ToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.굵기5ToolStripMenuItem.Text = "굵기(5)";
            this.굵기5ToolStripMenuItem.Click += new System.EventHandler(this.굵기5ToolStripMenuItem_Click);
            // 
            // 굵기3ToolStripMenuItem
            // 
            this.굵기3ToolStripMenuItem.Name = "굵기3ToolStripMenuItem";
            this.굵기3ToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.굵기3ToolStripMenuItem.Text = "굵기(3)";
            this.굵기3ToolStripMenuItem.Click += new System.EventHandler(this.굵기3ToolStripMenuItem_Click);
            // 
            // 굵기1ToolStripMenuItem
            // 
            this.굵기1ToolStripMenuItem.Name = "굵기1ToolStripMenuItem";
            this.굵기1ToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.굵기1ToolStripMenuItem.Text = "굵기(1)";
            this.굵기1ToolStripMenuItem.Click += new System.EventHandler(this.굵기1ToolStripMenuItem_Click);
            // 
            // 선종류ToolStripMenuItem
            // 
            this.선종류ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem,
            this.dashdotToolStripMenuItem,
            this.dotToolStripMenuItem});
            this.선종류ToolStripMenuItem.Name = "선종류ToolStripMenuItem";
            this.선종류ToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.선종류ToolStripMenuItem.Text = "선 종류";
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.solidToolStripMenuItem.Text = "solid";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // dashdotToolStripMenuItem
            // 
            this.dashdotToolStripMenuItem.Name = "dashdotToolStripMenuItem";
            this.dashdotToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.dashdotToolStripMenuItem.Text = "dashdot";
            this.dashdotToolStripMenuItem.Click += new System.EventHandler(this.dashdotToolStripMenuItem_Click);
            // 
            // dotToolStripMenuItem
            // 
            this.dotToolStripMenuItem.Name = "dotToolStripMenuItem";
            this.dotToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.dotToolStripMenuItem.Text = "dot";
            this.dotToolStripMenuItem.Click += new System.EventHandler(this.dotToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 390);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // 배경색ToolStripMenuItem
            // 
            this.배경색ToolStripMenuItem.Name = "배경색ToolStripMenuItem";
            this.배경색ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.배경색ToolStripMenuItem.Text = "배경색";
            this.배경색ToolStripMenuItem.Click += new System.EventHandler(this.배경색ToolStripMenuItem_Click);
            // 
            // Drawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(799, 418);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Drawing";
            this.Text = "제목 없음 - 그림판";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_newfile;
        private System.Windows.Forms.ToolStripMenuItem menu_savefile;
        private System.Windows.Forms.ToolStripMenuItem menu_openfile;
        private System.Windows.Forms.ToolStripMenuItem menu_exit;
        private System.Windows.Forms.ToolStripMenuItem 도형ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_drawcircle;
        private System.Windows.Forms.ToolStripMenuItem menu_drawrectangle;
        private System.Windows.Forms.ToolStripMenuItem menu_drawline;
        private System.Windows.Forms.ToolStripMenuItem 서식ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_color;
        private System.Windows.Forms.ToolStripMenuItem menu_lineheight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 굵기10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 굵기1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선종류ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashdotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_drawpen;
        private System.Windows.Forms.ToolStripMenuItem 모두지우기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배경색ToolStripMenuItem;
    }
}

