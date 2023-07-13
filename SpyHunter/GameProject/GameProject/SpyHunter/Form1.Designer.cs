namespace SpyHunter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblControlTitle = new System.Windows.Forms.Label();
            this.lblControls = new System.Windows.Forms.Label();
            this.tmrEnemySpeed = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblYourMissionTitle = new System.Windows.Forms.Label();
            this.lblHowToPlayTitle = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblPausedGame = new System.Windows.Forms.Label();
            this.lblResumeInfo = new System.Windows.Forms.Label();
            this.tmrDamageCooldown = new System.Windows.Forms.Timer(this.components);
            this.lblPauseQuitInfo = new System.Windows.Forms.Label();
            this.picYourMission = new System.Windows.Forms.PictureBox();
            this.picHowToPlay = new System.Windows.Forms.PictureBox();
            this.picControls = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picScoreBox = new System.Windows.Forms.PictureBox();
            this.picGuy = new System.Windows.Forms.PictureBox();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.picBlack = new System.Windows.Forms.PictureBox();
            this.picSpy = new System.Windows.Forms.PictureBox();
            this.picGrass2 = new System.Windows.Forms.PictureBox();
            this.picGrass1 = new System.Windows.Forms.PictureBox();
            this.tmrDamageTaken = new System.Windows.Forms.Timer(this.components);
            this.lblHealthBar = new System.Windows.Forms.Label();
            this.tmrFireRate = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemyRespawn = new System.Windows.Forms.Timer(this.components);
            this.lblPlayAgain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picYourMission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHowToPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picControls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScoreBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrass1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 35;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick_1);
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.BackColor = System.Drawing.Color.Black;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.ForeColor = System.Drawing.Color.White;
            this.lblEnter.Location = new System.Drawing.Point(120, 422);
            this.lblEnter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(390, 36);
            this.lblEnter.TabIndex = 4;
            this.lblEnter.Text = "PRESS ENTER TO START!";
            // 
            // lblControlTitle
            // 
            this.lblControlTitle.AutoSize = true;
            this.lblControlTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlTitle.ForeColor = System.Drawing.Color.White;
            this.lblControlTitle.Location = new System.Drawing.Point(443, 641);
            this.lblControlTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControlTitle.Name = "lblControlTitle";
            this.lblControlTitle.Size = new System.Drawing.Size(112, 32);
            this.lblControlTitle.TabIndex = 6;
            this.lblControlTitle.Text = "Controls";
            this.lblControlTitle.Visible = false;
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.BackColor = System.Drawing.Color.Black;
            this.lblControls.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControls.ForeColor = System.Drawing.Color.White;
            this.lblControls.Location = new System.Drawing.Point(30, 458);
            this.lblControls.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(160, 21);
            this.lblControls.TabIndex = 7;
            this.lblControls.Text = "Press \"C\" for Controls";
            // 
            // tmrEnemySpeed
            // 
            this.tmrEnemySpeed.Interval = 75;
            this.tmrEnemySpeed.Tick += new System.EventHandler(this.tmrEnemySpeed_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Black;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(454, 724);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(66, 24);
            this.lblScore.TabIndex = 11;
            this.lblScore.Text = "label1";
            this.lblScore.Visible = false;
            // 
            // lblYourMissionTitle
            // 
            this.lblYourMissionTitle.AutoSize = true;
            this.lblYourMissionTitle.BackColor = System.Drawing.Color.Black;
            this.lblYourMissionTitle.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourMissionTitle.ForeColor = System.Drawing.Color.White;
            this.lblYourMissionTitle.Location = new System.Drawing.Point(393, 458);
            this.lblYourMissionTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYourMissionTitle.Name = "lblYourMissionTitle";
            this.lblYourMissionTitle.Size = new System.Drawing.Size(193, 21);
            this.lblYourMissionTitle.TabIndex = 20;
            this.lblYourMissionTitle.Text = "Press \"M\" for Your Mission";
            // 
            // lblHowToPlayTitle
            // 
            this.lblHowToPlayTitle.AutoSize = true;
            this.lblHowToPlayTitle.BackColor = System.Drawing.Color.Black;
            this.lblHowToPlayTitle.Font = new System.Drawing.Font("Impact", 10F);
            this.lblHowToPlayTitle.ForeColor = System.Drawing.Color.White;
            this.lblHowToPlayTitle.Location = new System.Drawing.Point(202, 458);
            this.lblHowToPlayTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHowToPlayTitle.Name = "lblHowToPlayTitle";
            this.lblHowToPlayTitle.Size = new System.Drawing.Size(183, 21);
            this.lblHowToPlayTitle.TabIndex = 21;
            this.lblHowToPlayTitle.Text = "Press \"H\" for How To Play";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.Black;
            this.lblGameOver.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Red;
            this.lblGameOver.Location = new System.Drawing.Point(79, 224);
            this.lblGameOver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(458, 85);
            this.lblGameOver.TabIndex = 23;
            this.lblGameOver.Text = "GAME OVER!";
            this.lblGameOver.Visible = false;
            // 
            // lblPausedGame
            // 
            this.lblPausedGame.AutoSize = true;
            this.lblPausedGame.BackColor = System.Drawing.Color.Black;
            this.lblPausedGame.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPausedGame.ForeColor = System.Drawing.Color.Blue;
            this.lblPausedGame.Location = new System.Drawing.Point(34, 212);
            this.lblPausedGame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPausedGame.Name = "lblPausedGame";
            this.lblPausedGame.Size = new System.Drawing.Size(540, 85);
            this.lblPausedGame.TabIndex = 24;
            this.lblPausedGame.Text = "PAUSED GAME!";
            this.lblPausedGame.Visible = false;
            // 
            // lblResumeInfo
            // 
            this.lblResumeInfo.AutoSize = true;
            this.lblResumeInfo.BackColor = System.Drawing.Color.Black;
            this.lblResumeInfo.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumeInfo.ForeColor = System.Drawing.Color.Blue;
            this.lblResumeInfo.Location = new System.Drawing.Point(51, 284);
            this.lblResumeInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumeInfo.Name = "lblResumeInfo";
            this.lblResumeInfo.Size = new System.Drawing.Size(487, 56);
            this.lblResumeInfo.TabIndex = 25;
            this.lblResumeInfo.Text = "Press Tab to Resume";
            this.lblResumeInfo.Visible = false;
            // 
            // tmrDamageCooldown
            // 
            this.tmrDamageCooldown.Interval = 3000;
            this.tmrDamageCooldown.Tick += new System.EventHandler(this.tmrDamageCooldown_Tick);
            // 
            // lblPauseQuitInfo
            // 
            this.lblPauseQuitInfo.AutoSize = true;
            this.lblPauseQuitInfo.BackColor = System.Drawing.Color.Black;
            this.lblPauseQuitInfo.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPauseQuitInfo.ForeColor = System.Drawing.Color.Blue;
            this.lblPauseQuitInfo.Location = new System.Drawing.Point(84, 330);
            this.lblPauseQuitInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPauseQuitInfo.Name = "lblPauseQuitInfo";
            this.lblPauseQuitInfo.Size = new System.Drawing.Size(402, 56);
            this.lblPauseQuitInfo.TabIndex = 26;
            this.lblPauseQuitInfo.Text = "Press Esc to Quit";
            this.lblPauseQuitInfo.Visible = false;
            // 
            // picYourMission
            // 
            this.picYourMission.Image = ((System.Drawing.Image)(resources.GetObject("picYourMission.Image")));
            this.picYourMission.Location = new System.Drawing.Point(34, 495);
            this.picYourMission.Margin = new System.Windows.Forms.Padding(4);
            this.picYourMission.Name = "picYourMission";
            this.picYourMission.Size = new System.Drawing.Size(526, 230);
            this.picYourMission.TabIndex = 19;
            this.picYourMission.TabStop = false;
            this.picYourMission.Visible = false;
            // 
            // picHowToPlay
            // 
            this.picHowToPlay.Image = ((System.Drawing.Image)(resources.GetObject("picHowToPlay.Image")));
            this.picHowToPlay.Location = new System.Drawing.Point(34, 495);
            this.picHowToPlay.Margin = new System.Windows.Forms.Padding(4);
            this.picHowToPlay.Name = "picHowToPlay";
            this.picHowToPlay.Size = new System.Drawing.Size(526, 230);
            this.picHowToPlay.TabIndex = 18;
            this.picHowToPlay.TabStop = false;
            this.picHowToPlay.Visible = false;
            // 
            // picControls
            // 
            this.picControls.Image = ((System.Drawing.Image)(resources.GetObject("picControls.Image")));
            this.picControls.Location = new System.Drawing.Point(34, 495);
            this.picControls.Margin = new System.Windows.Forms.Padding(4);
            this.picControls.Name = "picControls";
            this.picControls.Size = new System.Drawing.Size(526, 230);
            this.picControls.TabIndex = 12;
            this.picControls.TabStop = false;
            this.picControls.Visible = false;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
            this.picLogo.Location = new System.Drawing.Point(49, 13);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(488, 195);
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // picScoreBox
            // 
            this.picScoreBox.BackColor = System.Drawing.Color.Black;
            this.picScoreBox.Location = new System.Drawing.Point(0, 716);
            this.picScoreBox.Margin = new System.Windows.Forms.Padding(4);
            this.picScoreBox.Name = "picScoreBox";
            this.picScoreBox.Size = new System.Drawing.Size(586, 42);
            this.picScoreBox.TabIndex = 10;
            this.picScoreBox.TabStop = false;
            this.picScoreBox.Visible = false;
            // 
            // picGuy
            // 
            this.picGuy.BackColor = System.Drawing.Color.Black;
            this.picGuy.Image = ((System.Drawing.Image)(resources.GetObject("picGuy.Image")));
            this.picGuy.Location = new System.Drawing.Point(151, 212);
            this.picGuy.Margin = new System.Windows.Forms.Padding(4);
            this.picGuy.Name = "picGuy";
            this.picGuy.Size = new System.Drawing.Size(273, 206);
            this.picGuy.TabIndex = 9;
            this.picGuy.TabStop = false;
            // 
            // picInfo
            // 
            this.picInfo.Location = new System.Drawing.Point(24, 483);
            this.picInfo.Margin = new System.Windows.Forms.Padding(4);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(545, 257);
            this.picInfo.TabIndex = 5;
            this.picInfo.TabStop = false;
            this.picInfo.Visible = false;
            // 
            // picBlack
            // 
            this.picBlack.BackColor = System.Drawing.Color.Black;
            this.picBlack.Location = new System.Drawing.Point(0, 0);
            this.picBlack.Margin = new System.Windows.Forms.Padding(4);
            this.picBlack.Name = "picBlack";
            this.picBlack.Size = new System.Drawing.Size(586, 1189);
            this.picBlack.TabIndex = 3;
            this.picBlack.TabStop = false;
            // 
            // picSpy
            // 
            this.picSpy.BackColor = System.Drawing.Color.Transparent;
            this.picSpy.Image = ((System.Drawing.Image)(resources.GetObject("picSpy.Image")));
            this.picSpy.Location = new System.Drawing.Point(488, 482);
            this.picSpy.Margin = new System.Windows.Forms.Padding(4);
            this.picSpy.Name = "picSpy";
            this.picSpy.Size = new System.Drawing.Size(50, 100);
            this.picSpy.TabIndex = 2;
            this.picSpy.TabStop = false;
            // 
            // picGrass2
            // 
            this.picGrass2.BackColor = System.Drawing.Color.LimeGreen;
            this.picGrass2.Location = new System.Drawing.Point(0, 0);
            this.picGrass2.Margin = new System.Windows.Forms.Padding(4);
            this.picGrass2.Name = "picGrass2";
            this.picGrass2.Size = new System.Drawing.Size(132, 800);
            this.picGrass2.TabIndex = 1;
            this.picGrass2.TabStop = false;
            // 
            // picGrass1
            // 
            this.picGrass1.BackColor = System.Drawing.Color.LimeGreen;
            this.picGrass1.Location = new System.Drawing.Point(454, 0);
            this.picGrass1.Margin = new System.Windows.Forms.Padding(4);
            this.picGrass1.Name = "picGrass1";
            this.picGrass1.Size = new System.Drawing.Size(132, 800);
            this.picGrass1.TabIndex = 0;
            this.picGrass1.TabStop = false;
            // 
            // tmrDamageTaken
            // 
            this.tmrDamageTaken.Interval = 500;
            this.tmrDamageTaken.Tick += new System.EventHandler(this.tmrDamageTaken_Tick);
            // 
            // lblHealthBar
            // 
            this.lblHealthBar.AutoSize = true;
            this.lblHealthBar.BackColor = System.Drawing.Color.Black;
            this.lblHealthBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealthBar.ForeColor = System.Drawing.Color.White;
            this.lblHealthBar.Location = new System.Drawing.Point(30, 724);
            this.lblHealthBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHealthBar.Name = "lblHealthBar";
            this.lblHealthBar.Size = new System.Drawing.Size(66, 24);
            this.lblHealthBar.TabIndex = 27;
            this.lblHealthBar.Text = "label1";
            this.lblHealthBar.Visible = false;
            // 
            // tmrFireRate
            // 
            this.tmrFireRate.Interval = 750;
            this.tmrFireRate.Tick += new System.EventHandler(this.tmrFireRate_Tick);
            // 
            // tmrEnemyRespawn
            // 
            this.tmrEnemyRespawn.Interval = 3000;
            this.tmrEnemyRespawn.Tick += new System.EventHandler(this.tmrEnemyRespawn_Tick);
            // 
            // lblPlayAgain
            // 
            this.lblPlayAgain.AccessibleName = "lblPlayAgain";
            this.lblPlayAgain.AutoSize = true;
            this.lblPlayAgain.BackColor = System.Drawing.Color.Black;
            this.lblPlayAgain.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayAgain.ForeColor = System.Drawing.Color.Blue;
            this.lblPlayAgain.Location = new System.Drawing.Point(30, 284);
            this.lblPlayAgain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayAgain.Name = "lblPlayAgain";
            this.lblPlayAgain.Size = new System.Drawing.Size(539, 56);
            this.lblPlayAgain.TabIndex = 29;
            this.lblPlayAgain.Text = "Press \"P\" To Play Again";
            this.lblPlayAgain.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(582, 753);
            this.Controls.Add(this.lblPlayAgain);
            this.Controls.Add(this.lblHealthBar);
            this.Controls.Add(this.lblPauseQuitInfo);
            this.Controls.Add(this.lblResumeInfo);
            this.Controls.Add(this.lblPausedGame);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblHowToPlayTitle);
            this.Controls.Add(this.lblYourMissionTitle);
            this.Controls.Add(this.picYourMission);
            this.Controls.Add(this.picHowToPlay);
            this.Controls.Add(this.picControls);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picScoreBox);
            this.Controls.Add(this.lblControlTitle);
            this.Controls.Add(this.picGuy);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.picInfo);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.picBlack);
            this.Controls.Add(this.picSpy);
            this.Controls.Add(this.picGrass2);
            this.Controls.Add(this.picGrass1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spy Hunter";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picYourMission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHowToPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picControls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScoreBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrass1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGrass1;
        private System.Windows.Forms.PictureBox picGrass2;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.PictureBox picSpy;
        private System.Windows.Forms.PictureBox picBlack;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.Label lblControlTitle;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picGuy;
        private System.Windows.Forms.Timer tmrEnemySpeed;
        private System.Windows.Forms.PictureBox picScoreBox;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picControls;
        private System.Windows.Forms.PictureBox picHowToPlay;
        private System.Windows.Forms.PictureBox picYourMission;
        private System.Windows.Forms.Label lblYourMissionTitle;
        private System.Windows.Forms.Label lblHowToPlayTitle;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblPausedGame;
        private System.Windows.Forms.Label lblResumeInfo;
        private System.Windows.Forms.Timer tmrDamageCooldown;
        private System.Windows.Forms.Label lblPauseQuitInfo;
        private System.Windows.Forms.Timer tmrDamageTaken;
        private System.Windows.Forms.Label lblHealthBar;
        private System.Windows.Forms.Timer tmrFireRate;
        private System.Windows.Forms.Timer tmrEnemyRespawn;
        private System.Windows.Forms.Label lblPlayAgain;
    }
}

