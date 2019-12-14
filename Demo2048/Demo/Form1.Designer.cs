namespace Demo
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
            this.lb_bestScore = new System.Windows.Forms.Label();
            this.lb_diem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.tabUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tabExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gameOverPanel = new System.Windows.Forms.Panel();
            this.lbBestScore_ = new System.Windows.Forms.Label();
            this.lbDiem_ = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbBestScore_GameOver = new System.Windows.Forms.Label();
            this.lbDiem_GameOver = new System.Windows.Forms.Label();
            this.gameOverText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gameOverPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_bestScore
            // 
            this.lb_bestScore.BackColor = System.Drawing.Color.Transparent;
            this.lb_bestScore.Font = new System.Drawing.Font("FC BARCELONA", 15.75F, System.Drawing.FontStyle.Bold);
            this.lb_bestScore.ForeColor = System.Drawing.Color.White;
            this.lb_bestScore.Location = new System.Drawing.Point(26, 32);
            this.lb_bestScore.Name = "lb_bestScore";
            this.lb_bestScore.Size = new System.Drawing.Size(89, 38);
            this.lb_bestScore.TabIndex = 7;
            this.lb_bestScore.Text = "0";
            this.lb_bestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_diem
            // 
            this.lb_diem.BackColor = System.Drawing.Color.Transparent;
            this.lb_diem.Font = new System.Drawing.Font("FC BARCELONA", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diem.ForeColor = System.Drawing.Color.Snow;
            this.lb_diem.Location = new System.Drawing.Point(16, 30);
            this.lb_diem.Name = "lb_diem";
            this.lb_diem.Size = new System.Drawing.Size(95, 38);
            this.lb_diem.TabIndex = 8;
            this.lb_diem.Text = "0";
            this.lb_diem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("FC BARCELONA", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "BEST SCORE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("FC BARCELONA", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "SCORE";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabNewGame,
            this.tabUndo,
            this.tabExit});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tabNewGame
            // 
            this.tabNewGame.Name = "tabNewGame";
            this.tabNewGame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tabNewGame.Size = new System.Drawing.Size(180, 22);
            this.tabNewGame.Text = "New Game";
            this.tabNewGame.Click += new System.EventHandler(this.tabNewGame_Click);
            // 
            // tabUndo
            // 
            this.tabUndo.Name = "tabUndo";
            this.tabUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tabUndo.Size = new System.Drawing.Size(180, 22);
            this.tabUndo.Text = "Undo";
            this.tabUndo.Click += new System.EventHandler(this.tabUndo_Click);
            // 
            // tabExit
            // 
            this.tabExit.Name = "tabExit";
            this.tabExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tabExit.Size = new System.Drawing.Size(180, 22);
            this.tabExit.Text = "Quit";
            this.tabExit.Click += new System.EventHandler(this.tabExit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // gameOverPanel
            // 
            this.gameOverPanel.BackColor = System.Drawing.Color.Indigo;
            this.gameOverPanel.Controls.Add(this.lbBestScore_);
            this.gameOverPanel.Controls.Add(this.lbDiem_);
            this.gameOverPanel.Controls.Add(this.btnNewGame);
            this.gameOverPanel.Controls.Add(this.btnExit);
            this.gameOverPanel.Controls.Add(this.lbBestScore_GameOver);
            this.gameOverPanel.Controls.Add(this.lbDiem_GameOver);
            this.gameOverPanel.Controls.Add(this.gameOverText);
            this.gameOverPanel.Location = new System.Drawing.Point(0, 213);
            this.gameOverPanel.Name = "gameOverPanel";
            this.gameOverPanel.Size = new System.Drawing.Size(469, 267);
            this.gameOverPanel.TabIndex = 10;
            // 
            // lbBestScore_
            // 
            this.lbBestScore_.AutoSize = true;
            this.lbBestScore_.Font = new System.Drawing.Font("FC BARCELONA", 24F, System.Drawing.FontStyle.Bold);
            this.lbBestScore_.ForeColor = System.Drawing.Color.Yellow;
            this.lbBestScore_.Location = new System.Drawing.Point(262, 123);
            this.lbBestScore_.Name = "lbBestScore_";
            this.lbBestScore_.Size = new System.Drawing.Size(35, 40);
            this.lbBestScore_.TabIndex = 6;
            this.lbBestScore_.Text = "0";
            // 
            // lbDiem_
            // 
            this.lbDiem_.AutoSize = true;
            this.lbDiem_.Font = new System.Drawing.Font("FC BARCELONA", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem_.ForeColor = System.Drawing.Color.Yellow;
            this.lbDiem_.Location = new System.Drawing.Point(133, 89);
            this.lbDiem_.Name = "lbDiem_";
            this.lbDiem_.Size = new System.Drawing.Size(35, 40);
            this.lbDiem_.TabIndex = 5;
            this.lbDiem_.Text = "0";
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.DarkViolet;
            this.btnNewGame.Font = new System.Drawing.Font("iCiel Gotham Medium", 14F);
            this.btnNewGame.ForeColor = System.Drawing.Color.Yellow;
            this.btnNewGame.Location = new System.Drawing.Point(58, 197);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(110, 53);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "Ván Mới";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.tabNewGame_Click);
            this.btnNewGame.Enter += new System.EventHandler(this.changeToRed);
            this.btnNewGame.Leave += new System.EventHandler(this.changToDarkViolet1);
            this.btnNewGame.MouseEnter += new System.EventHandler(this.changeToRed);
            this.btnNewGame.MouseLeave += new System.EventHandler(this.changToDarkViolet1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkViolet;
            this.btnExit.Font = new System.Drawing.Font("iCiel Gotham Medium", 14F);
            this.btnExit.ForeColor = System.Drawing.Color.Yellow;
            this.btnExit.Location = new System.Drawing.Point(293, 197);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 53);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.tabExit_Click);
            this.btnExit.Enter += new System.EventHandler(this.changeToGreen);
            this.btnExit.Leave += new System.EventHandler(this.changToDarkViolet2);
            this.btnExit.MouseEnter += new System.EventHandler(this.changeToGreen);
            this.btnExit.MouseLeave += new System.EventHandler(this.changToDarkViolet2);
            // 
            // lbBestScore_GameOver
            // 
            this.lbBestScore_GameOver.AutoSize = true;
            this.lbBestScore_GameOver.Font = new System.Drawing.Font("iCiel Gotham Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBestScore_GameOver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbBestScore_GameOver.Location = new System.Drawing.Point(35, 138);
            this.lbBestScore_GameOver.Name = "lbBestScore_GameOver";
            this.lbBestScore_GameOver.Size = new System.Drawing.Size(176, 23);
            this.lbBestScore_GameOver.TabIndex = 2;
            this.lbBestScore_GameOver.Text = "ĐIỂM CAO NHẤT:";
            // 
            // lbDiem_GameOver
            // 
            this.lbDiem_GameOver.AutoSize = true;
            this.lbDiem_GameOver.Font = new System.Drawing.Font("iCiel Gotham Medium", 14F);
            this.lbDiem_GameOver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDiem_GameOver.Location = new System.Drawing.Point(35, 104);
            this.lbDiem_GameOver.Name = "lbDiem_GameOver";
            this.lbDiem_GameOver.Size = new System.Drawing.Size(65, 23);
            this.lbDiem_GameOver.TabIndex = 1;
            this.lbDiem_GameOver.Text = "ĐIỂM:";
            // 
            // gameOverText
            // 
            this.gameOverText.AutoSize = true;
            this.gameOverText.Font = new System.Drawing.Font("iCiel Cadena", 40F, System.Drawing.FontStyle.Bold);
            this.gameOverText.ForeColor = System.Drawing.Color.Yellow;
            this.gameOverText.Location = new System.Drawing.Point(75, 0);
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.Size = new System.Drawing.Size(342, 75);
            this.gameOverText.TabIndex = 0;
            this.gameOverText.Text = "GAME OVER !";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lb_bestScore);
            this.panel1.Location = new System.Drawing.Point(315, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 68);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lb_diem);
            this.panel2.Location = new System.Drawing.Point(12, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 65);
            this.panel2.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.groupBox1.Location = new System.Drawing.Point(22, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 425);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(249, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.tabUndo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("FC BARCELONA", 12F);
            this.label1.Location = new System.Drawing.Point(253, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "UNDO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(167, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.tabNewGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("FC BARCELONA", 12F);
            this.label2.Location = new System.Drawing.Point(153, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "NEW GAME";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(469, 638);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gameOverPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gameOverPanel.ResumeLayout(false);
            this.gameOverPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_bestScore;
        private System.Windows.Forms.Label lb_diem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabNewGame;
        private System.Windows.Forms.ToolStripMenuItem tabUndo;
        private System.Windows.Forms.ToolStripMenuItem tabExit;
        private System.Windows.Forms.Panel gameOverPanel;
        private System.Windows.Forms.Label lbBestScore_;
        private System.Windows.Forms.Label lbDiem_;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbBestScore_GameOver;
        private System.Windows.Forms.Label lbDiem_GameOver;
        private System.Windows.Forms.Label gameOverText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}

