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
            this.gameWindow = new System.Windows.Forms.PictureBox();
            this.restartBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.playPauseBtn = new System.Windows.Forms.Button();
            this.generationCount = new System.Windows.Forms.Label();
            this.threadCountBar = new System.Windows.Forms.TrackBar();
            this.howManyThreadsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadCountBar)).BeginInit();
            this.SuspendLayout();
            // 
            // gameWindow
            // 
            this.gameWindow.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gameWindow.Location = new System.Drawing.Point(12, 12);
            this.gameWindow.Name = "gameWindow";
            this.gameWindow.Size = new System.Drawing.Size(602, 604);
            this.gameWindow.TabIndex = 0;
            this.gameWindow.TabStop = false;
            this.gameWindow.Paint += new System.Windows.Forms.PaintEventHandler(this.gameWindow_Paint);
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.restartBtn.Location = new System.Drawing.Point(12, 637);
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
            this.exitBtn.Location = new System.Drawing.Point(539, 637);
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
            this.playPauseBtn.Location = new System.Drawing.Point(109, 637);
            this.playPauseBtn.Name = "playPauseBtn";
            this.playPauseBtn.Size = new System.Drawing.Size(75, 23);
            this.playPauseBtn.TabIndex = 3;
            this.playPauseBtn.Text = "Play";
            this.playPauseBtn.UseVisualStyleBackColor = false;
            this.playPauseBtn.Click += new System.EventHandler(this.playPauseBtn_Click);
            // 
            // generationCount
            // 
            this.generationCount.AutoSize = true;
            this.generationCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generationCount.Location = new System.Drawing.Point(205, 637);
            this.generationCount.Margin = new System.Windows.Forms.Padding(0);
            this.generationCount.MinimumSize = new System.Drawing.Size(20, 2);
            this.generationCount.Name = "generationCount";
            this.generationCount.Padding = new System.Windows.Forms.Padding(5);
            this.generationCount.Size = new System.Drawing.Size(83, 25);
            this.generationCount.TabIndex = 4;
            this.generationCount.Text = "Generation: 0";
            this.generationCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // threadCountBar
            // 
            this.threadCountBar.LargeChange = 1;
            this.threadCountBar.Location = new System.Drawing.Point(372, 637);
            this.threadCountBar.Maximum = 4;
            this.threadCountBar.Minimum = 1;
            this.threadCountBar.Name = "threadCountBar";
            this.threadCountBar.Size = new System.Drawing.Size(151, 45);
            this.threadCountBar.TabIndex = 5;
            this.threadCountBar.Value = 1;
            this.threadCountBar.Scroll += new System.EventHandler(this.threadCount_Scroll);
            // 
            // howManyThreadsLabel
            // 
            this.howManyThreadsLabel.AutoSize = true;
            this.howManyThreadsLabel.Location = new System.Drawing.Point(325, 642);
            this.howManyThreadsLabel.Name = "howManyThreadsLabel";
            this.howManyThreadsLabel.Size = new System.Drawing.Size(49, 13);
            this.howManyThreadsLabel.TabIndex = 6;
            this.howManyThreadsLabel.Text = "Threads:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(624, 681);
            this.Controls.Add(this.howManyThreadsLabel);
            this.Controls.Add(this.threadCountBar);
            this.Controls.Add(this.generationCount);
            this.Controls.Add(this.playPauseBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.gameWindow);
            this.ForeColor = System.Drawing.Color.Honeydew;
            this.Name = "Form1";
            this.Text = "Game Of Life by Gabriel Radzięta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threadCountBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameWindow;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button playPauseBtn;
        private System.Windows.Forms.Label generationCount;
        private System.Windows.Forms.TrackBar threadCountBar;
        private System.Windows.Forms.Label howManyThreadsLabel;
    }
}

