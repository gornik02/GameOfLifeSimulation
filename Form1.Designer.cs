namespace GameOfLifeSimulation
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
            this.components = new System.ComponentModel.Container();
            this.gameWindow = new System.Windows.Forms.PictureBox();
            this.generationTimer = new System.Windows.Forms.Timer(this.components);
            this.restartBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.playPauseBtn = new System.Windows.Forms.Button();
            this.generationCount = new System.Windows.Forms.Label();
            this.speedTrackBar = new System.Windows.Forms.TrackBar();
            this.speedTrackBarLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.threadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gameWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameWindow
            // 
            this.gameWindow.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gameWindow.Location = new System.Drawing.Point(12, 35);
            this.gameWindow.Name = "gameWindow";
            this.gameWindow.Size = new System.Drawing.Size(602, 604);
            this.gameWindow.TabIndex = 0;
            this.gameWindow.TabStop = false;
            this.gameWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.gameWindow_Paint);
            // 
            // generationTimer
            // 
            this.generationTimer.Tick += new System.EventHandler(this.generationTimer_Tick);
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.restartBtn.Location = new System.Drawing.Point(12, 654);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(75, 23);
            this.restartBtn.TabIndex = 1;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exitBtn.Location = new System.Drawing.Point(539, 654);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // playPauseBtn
            // 
            this.playPauseBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.playPauseBtn.Location = new System.Drawing.Point(109, 654);
            this.playPauseBtn.Name = "playPauseBtn";
            this.playPauseBtn.Size = new System.Drawing.Size(75, 23);
            this.playPauseBtn.TabIndex = 3;
            this.playPauseBtn.Text = "Play/Pause";
            this.playPauseBtn.UseVisualStyleBackColor = false;
            this.playPauseBtn.Click += new System.EventHandler(this.playPauseBtn_Click);
            // 
            // generationCount
            // 
            this.generationCount.AutoSize = true;
            this.generationCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generationCount.Location = new System.Drawing.Point(205, 654);
            this.generationCount.Margin = new System.Windows.Forms.Padding(0);
            this.generationCount.MinimumSize = new System.Drawing.Size(20, 2);
            this.generationCount.Name = "generationCount";
            this.generationCount.Padding = new System.Windows.Forms.Padding(5);
            this.generationCount.Size = new System.Drawing.Size(83, 25);
            this.generationCount.TabIndex = 4;
            this.generationCount.Text = "Generation: 0";
            this.generationCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedTrackBar
            // 
            this.speedTrackBar.Location = new System.Drawing.Point(372, 654);
            this.speedTrackBar.Minimum = 1;
            this.speedTrackBar.Name = "speedTrackBar";
            this.speedTrackBar.Size = new System.Drawing.Size(151, 45);
            this.speedTrackBar.TabIndex = 5;
            this.speedTrackBar.Value = 1;
            this.speedTrackBar.Scroll += new System.EventHandler(this.speedTrackBar_Scroll);
            // 
            // speedTrackBarLabel
            // 
            this.speedTrackBarLabel.AutoSize = true;
            this.speedTrackBarLabel.Location = new System.Drawing.Point(325, 659);
            this.speedTrackBarLabel.Name = "speedTrackBarLabel";
            this.speedTrackBarLabel.Size = new System.Drawing.Size(41, 13);
            this.speedTrackBarLabel.TabIndex = 6;
            this.speedTrackBarLabel.Text = "Speed:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.threadsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // threadsToolStripMenuItem
            // 
            this.threadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem,
            this.xToolStripMenuItem1});
            this.threadsToolStripMenuItem.Name = "threadsToolStripMenuItem";
            this.threadsToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.threadsToolStripMenuItem.Text = "Threads";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xToolStripMenuItem.Text = "1x";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.threadCount1x);
            // 
            // xToolStripMenuItem1
            // 
            this.xToolStripMenuItem1.Name = "xToolStripMenuItem1";
            this.xToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.xToolStripMenuItem1.Text = "2x";
            this.xToolStripMenuItem1.Click += new System.EventHandler(this.threadCount2x);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(624, 699);
            this.Controls.Add(this.speedTrackBarLabel);
            this.Controls.Add(this.speedTrackBar);
            this.Controls.Add(this.generationCount);
            this.Controls.Add(this.playPauseBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.gameWindow);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Honeydew;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Game Of Life by Gabriel Radzięta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameWindow;
        private System.Windows.Forms.Timer generationTimer;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button playPauseBtn;
        private System.Windows.Forms.Label generationCount;
        private System.Windows.Forms.TrackBar speedTrackBar;
        private System.Windows.Forms.Label speedTrackBarLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem threadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem1;
    }
}

