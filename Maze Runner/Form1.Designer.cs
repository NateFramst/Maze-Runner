namespace Maze_Runner
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
            this.StartButton = new System.Windows.Forms.Button();
            this.gameTick = new System.Windows.Forms.Timer(this.components);
            this.mouseX = new System.Windows.Forms.Label();
            this.mouseY = new System.Windows.Forms.Label();
            this.mmouseY = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.M = new System.Windows.Forms.PictureBox();
            this.A = new System.Windows.Forms.PictureBox();
            this.Z = new System.Windows.Forms.PictureBox();
            this.E = new System.Windows.Forms.PictureBox();
            this.R = new System.Windows.Forms.PictureBox();
            this.U = new System.Windows.Forms.PictureBox();
            this.N = new System.Windows.Forms.PictureBox();
            this.N2 = new System.Windows.Forms.PictureBox();
            this.E2 = new System.Windows.Forms.PictureBox();
            this.R2 = new System.Windows.Forms.PictureBox();
            this.Grass = new System.Windows.Forms.PictureBox();
            this.HighScores = new System.Windows.Forms.Label();
            this.HighScoreTitle = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Label();
            this.ScoreTitle = new System.Windows.Forms.Label();
            this.HS1 = new System.Windows.Forms.Label();
            this.HS2 = new System.Windows.Forms.Label();
            this.HS3 = new System.Windows.Forms.Label();
            this.HS4 = new System.Windows.Forms.Label();
            this.HS5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.U)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grass)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Viner Hand ITC", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(136, 364);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(212, 99);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            this.StartButton.MouseEnter += new System.EventHandler(this.StartButton_MouseEnter);
            this.StartButton.MouseLeave += new System.EventHandler(this.StartButton_MouseLeave);
            // 
            // gameTick
            // 
            this.gameTick.Interval = 20;
            this.gameTick.Tick += new System.EventHandler(this.gameTick_Tick_1);
            // 
            // mouseX
            // 
            this.mouseX.AutoSize = true;
            this.mouseX.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mouseX.Location = new System.Drawing.Point(12, 58);
            this.mouseX.Name = "mouseX";
            this.mouseX.Size = new System.Drawing.Size(35, 13);
            this.mouseX.TabIndex = 1;
            this.mouseX.Text = "label1";
            this.mouseX.Visible = false;
            // 
            // mouseY
            // 
            this.mouseY.AutoSize = true;
            this.mouseY.Location = new System.Drawing.Point(12, 32);
            this.mouseY.Name = "mouseY";
            this.mouseY.Size = new System.Drawing.Size(0, 13);
            this.mouseY.TabIndex = 2;
            // 
            // mmouseY
            // 
            this.mmouseY.AutoSize = true;
            this.mmouseY.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.mmouseY.Location = new System.Drawing.Point(12, 86);
            this.mmouseY.Name = "mmouseY";
            this.mmouseY.Size = new System.Drawing.Size(35, 13);
            this.mmouseY.TabIndex = 3;
            this.mmouseY.Text = "label1";
            this.mmouseY.Visible = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.score.Location = new System.Drawing.Point(6, 22);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(35, 13);
            this.score.TabIndex = 4;
            this.score.Text = "label1";
            this.score.Visible = false;
            // 
            // M
            // 
            this.M.BackColor = System.Drawing.Color.Transparent;
            this.M.BackgroundImage = global::Maze_Runner.Properties.Resources.M_com_final_removebg_preview;
            this.M.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.M.Location = new System.Drawing.Point(97, 47);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(56, 52);
            this.M.TabIndex = 5;
            this.M.TabStop = false;
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.Color.Transparent;
            this.A.BackgroundImage = global::Maze_Runner.Properties.Resources.A_com_final_removebg_preview;
            this.A.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.A.Location = new System.Drawing.Point(159, 32);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(56, 52);
            this.A.TabIndex = 6;
            this.A.TabStop = false;
            // 
            // Z
            // 
            this.Z.BackColor = System.Drawing.Color.Transparent;
            this.Z.BackgroundImage = global::Maze_Runner.Properties.Resources.Z_com_final_removebg_preview;
            this.Z.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Z.Location = new System.Drawing.Point(221, 19);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(56, 52);
            this.Z.TabIndex = 7;
            this.Z.TabStop = false;
            // 
            // E
            // 
            this.E.BackColor = System.Drawing.Color.Transparent;
            this.E.BackgroundImage = global::Maze_Runner.Properties.Resources.E_com_final_removebg_preview;
            this.E.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.E.Location = new System.Drawing.Point(283, 9);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(56, 52);
            this.E.TabIndex = 8;
            this.E.TabStop = false;
            // 
            // R
            // 
            this.R.BackColor = System.Drawing.Color.Transparent;
            this.R.BackgroundImage = global::Maze_Runner.Properties.Resources.R_com_final_removebg_preview;
            this.R.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.R.Location = new System.Drawing.Point(62, 123);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(56, 52);
            this.R.TabIndex = 9;
            this.R.TabStop = false;
            // 
            // U
            // 
            this.U.BackColor = System.Drawing.Color.Transparent;
            this.U.BackgroundImage = global::Maze_Runner.Properties.Resources.U_com_final_removebg_preview;
            this.U.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.U.Location = new System.Drawing.Point(124, 105);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(56, 52);
            this.U.TabIndex = 10;
            this.U.TabStop = false;
            // 
            // N
            // 
            this.N.BackColor = System.Drawing.Color.Transparent;
            this.N.BackgroundImage = global::Maze_Runner.Properties.Resources.N_com_final_removebg_preview;
            this.N.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.N.Location = new System.Drawing.Point(186, 90);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(56, 52);
            this.N.TabIndex = 11;
            this.N.TabStop = false;
            // 
            // N2
            // 
            this.N2.BackColor = System.Drawing.Color.Transparent;
            this.N2.BackgroundImage = global::Maze_Runner.Properties.Resources.N_com_final_removebg_preview;
            this.N2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.N2.Location = new System.Drawing.Point(248, 77);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(56, 52);
            this.N2.TabIndex = 12;
            this.N2.TabStop = false;
            // 
            // E2
            // 
            this.E2.BackColor = System.Drawing.Color.Transparent;
            this.E2.BackgroundImage = global::Maze_Runner.Properties.Resources.E_com_final_removebg_preview;
            this.E2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.E2.Location = new System.Drawing.Point(308, 58);
            this.E2.Name = "E2";
            this.E2.Size = new System.Drawing.Size(56, 52);
            this.E2.TabIndex = 13;
            this.E2.TabStop = false;
            // 
            // R2
            // 
            this.R2.BackColor = System.Drawing.Color.Transparent;
            this.R2.BackgroundImage = global::Maze_Runner.Properties.Resources.R_com_final_removebg_preview;
            this.R2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.R2.Location = new System.Drawing.Point(370, 47);
            this.R2.Name = "R2";
            this.R2.Size = new System.Drawing.Size(56, 52);
            this.R2.TabIndex = 14;
            this.R2.TabStop = false;
            // 
            // Grass
            // 
            this.Grass.BackColor = System.Drawing.Color.Transparent;
            this.Grass.BackgroundImage = global::Maze_Runner.Properties.Resources.Grass_com_final_removebg_preview;
            this.Grass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Grass.Location = new System.Drawing.Point(432, 65);
            this.Grass.Name = "Grass";
            this.Grass.Size = new System.Drawing.Size(18, 34);
            this.Grass.TabIndex = 15;
            this.Grass.TabStop = false;
            // 
            // HighScores
            // 
            this.HighScores.BackColor = System.Drawing.Color.Transparent;
            this.HighScores.ForeColor = System.Drawing.Color.White;
            this.HighScores.Location = new System.Drawing.Point(132, 228);
            this.HighScores.Name = "HighScores";
            this.HighScores.Size = new System.Drawing.Size(216, 123);
            this.HighScores.TabIndex = 16;
            this.HighScores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HighScoreTitle
            // 
            this.HighScoreTitle.BackColor = System.Drawing.Color.Transparent;
            this.HighScoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreTitle.ForeColor = System.Drawing.Color.White;
            this.HighScoreTitle.Location = new System.Drawing.Point(92, 182);
            this.HighScoreTitle.Name = "HighScoreTitle";
            this.HighScoreTitle.Size = new System.Drawing.Size(302, 46);
            this.HighScoreTitle.TabIndex = 17;
            this.HighScoreTitle.Text = "HIGHSCORES";
            this.HighScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(83, 231);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(320, 20);
            this.usernameInput.TabIndex = 18;
            this.usernameInput.Visible = false;
            // 
            // timer
            // 
            this.timer.BackColor = System.Drawing.Color.LimeGreen;
            this.timer.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.timer.Location = new System.Drawing.Point(80, 6);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(335, 10);
            this.timer.TabIndex = 19;
            this.timer.Visible = false;
            // 
            // ScoreTitle
            // 
            this.ScoreTitle.AutoSize = true;
            this.ScoreTitle.BackColor = System.Drawing.Color.Transparent;
            this.ScoreTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ScoreTitle.Location = new System.Drawing.Point(3, 6);
            this.ScoreTitle.Name = "ScoreTitle";
            this.ScoreTitle.Size = new System.Drawing.Size(44, 13);
            this.ScoreTitle.TabIndex = 20;
            this.ScoreTitle.Text = "SCORE";
            this.ScoreTitle.Visible = false;
            // 
            // HS1
            // 
            this.HS1.BackColor = System.Drawing.Color.Transparent;
            this.HS1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.HS1.Location = new System.Drawing.Point(91, 231);
            this.HS1.Name = "HS1";
            this.HS1.Size = new System.Drawing.Size(62, 23);
            this.HS1.TabIndex = 21;
            this.HS1.Text = "NATE";
            this.HS1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HS1.Visible = false;
            // 
            // HS2
            // 
            this.HS2.AutoSize = true;
            this.HS2.BackColor = System.Drawing.Color.Transparent;
            this.HS2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.HS2.Location = new System.Drawing.Point(91, 269);
            this.HS2.Name = "HS2";
            this.HS2.Size = new System.Drawing.Size(0, 13);
            this.HS2.TabIndex = 22;
            this.HS2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HS2.Visible = false;
            // 
            // HS3
            // 
            this.HS3.AutoSize = true;
            this.HS3.BackColor = System.Drawing.Color.Transparent;
            this.HS3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.HS3.Location = new System.Drawing.Point(91, 292);
            this.HS3.Name = "HS3";
            this.HS3.Size = new System.Drawing.Size(0, 13);
            this.HS3.TabIndex = 23;
            this.HS3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HS3.Visible = false;
            // 
            // HS4
            // 
            this.HS4.AutoSize = true;
            this.HS4.BackColor = System.Drawing.Color.Transparent;
            this.HS4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.HS4.Location = new System.Drawing.Point(91, 315);
            this.HS4.Name = "HS4";
            this.HS4.Size = new System.Drawing.Size(0, 13);
            this.HS4.TabIndex = 24;
            this.HS4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HS4.Visible = false;
            // 
            // HS5
            // 
            this.HS5.AutoSize = true;
            this.HS5.BackColor = System.Drawing.Color.Transparent;
            this.HS5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.HS5.Location = new System.Drawing.Point(91, 338);
            this.HS5.Name = "HS5";
            this.HS5.Size = new System.Drawing.Size(0, 13);
            this.HS5.TabIndex = 25;
            this.HS5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HS5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Maze_Runner.Properties.Resources.Web_capture_12_1_2023_23532_www_google_ca;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(485, 500);
            this.Controls.Add(this.HS5);
            this.Controls.Add(this.HS4);
            this.Controls.Add(this.HS3);
            this.Controls.Add(this.HS2);
            this.Controls.Add(this.HS1);
            this.Controls.Add(this.ScoreTitle);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.HighScoreTitle);
            this.Controls.Add(this.HighScores);
            this.Controls.Add(this.E2);
            this.Controls.Add(this.N2);
            this.Controls.Add(this.N);
            this.Controls.Add(this.U);
            this.Controls.Add(this.R);
            this.Controls.Add(this.E);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.A);
            this.Controls.Add(this.M);
            this.Controls.Add(this.score);
            this.Controls.Add(this.mmouseY);
            this.Controls.Add(this.mouseY);
            this.Controls.Add(this.mouseX);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Grass);
            this.Controls.Add(this.R2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maze Runner";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.U)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer gameTick;
        private System.Windows.Forms.Label mouseX;
        private System.Windows.Forms.Label mouseY;
        private System.Windows.Forms.Label mmouseY;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox M;
        private System.Windows.Forms.PictureBox A;
        private System.Windows.Forms.PictureBox Z;
        private System.Windows.Forms.PictureBox E;
        private System.Windows.Forms.PictureBox R;
        private System.Windows.Forms.PictureBox U;
        private System.Windows.Forms.PictureBox N;
        private System.Windows.Forms.PictureBox N2;
        private System.Windows.Forms.PictureBox E2;
        private System.Windows.Forms.PictureBox R2;
        private System.Windows.Forms.PictureBox Grass;
        private System.Windows.Forms.Label HighScores;
        private System.Windows.Forms.Label HighScoreTitle;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label ScoreTitle;
        private System.Windows.Forms.Label HS1;
        private System.Windows.Forms.Label HS2;
        private System.Windows.Forms.Label HS3;
        private System.Windows.Forms.Label HS4;
        private System.Windows.Forms.Label HS5;
    }
}

