namespace Platrix
{
    partial class Game
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
            this.lblAutor = new System.Windows.Forms.Label();
            this.FixedUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblLvlName = new System.Windows.Forms.Label();
            this.SecondUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblControls = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblJump = new System.Windows.Forms.Label();
            this.lblMasterMix = new System.Windows.Forms.Label();
            this.lblSound = new System.Windows.Forms.Label();
            this.lblMusic = new System.Windows.Forms.Label();
            this.lblBackToMenu = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblSaveSettings = new System.Windows.Forms.Label();
            this.Background = new System.Windows.Forms.PictureBox();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.pboxStartGame = new System.Windows.Forms.PictureBox();
            this.pboxSettings = new System.Windows.Forms.PictureBox();
            this.pboxQuit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLives = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxStartGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAutor.Location = new System.Drawing.Point(745, 691);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(261, 29);
            this.lblAutor.TabIndex = 2;
            this.lblAutor.Text = "Alexey Fedorenko(c)";
            // 
            // FixedUpdate
            // 
            this.FixedUpdate.Interval = 1;
            this.FixedUpdate.Tick += new System.EventHandler(this.FixedUpdate_Tick);
            // 
            // lblLvlName
            // 
            this.lblLvlName.AutoSize = true;
            this.lblLvlName.BackColor = System.Drawing.Color.Transparent;
            this.lblLvlName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLvlName.Location = new System.Drawing.Point(8, 9);
            this.lblLvlName.Name = "lblLvlName";
            this.lblLvlName.Size = new System.Drawing.Size(0, 29);
            this.lblLvlName.TabIndex = 7;
            this.lblLvlName.Visible = false;
            // 
            // SecondUpdate
            // 
            this.SecondUpdate.Interval = 1;
            this.SecondUpdate.Tick += new System.EventHandler(this.SecondUpdate_Tick);
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.BackColor = System.Drawing.Color.Transparent;
            this.lblControls.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblControls.Location = new System.Drawing.Point(60, 440);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(228, 58);
            this.lblControls.TabIndex = 17;
            this.lblControls.Text = "Controls";
            this.lblControls.Visible = false;
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblLeft.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLeft.Location = new System.Drawing.Point(69, 508);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(309, 45);
            this.lblLeft.TabIndex = 18;
            this.lblLeft.Text = "Left : Leftarrow";
            this.lblLeft.Visible = false;
            this.lblLeft.Click += new System.EventHandler(this.LblLeft_Click);
            this.lblLeft.MouseEnter += new System.EventHandler(this.LblLeft_MouseEnter);
            this.lblLeft.MouseLeave += new System.EventHandler(this.LblLeft_MouseLeave);
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.BackColor = System.Drawing.Color.Transparent;
            this.lblRight.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRight.Location = new System.Drawing.Point(69, 563);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(365, 45);
            this.lblRight.TabIndex = 19;
            this.lblRight.Text = "Right : Rightarrow";
            this.lblRight.Visible = false;
            this.lblRight.Click += new System.EventHandler(this.LblRight_Click);
            this.lblRight.MouseEnter += new System.EventHandler(this.LblRight_MouseEnter);
            this.lblRight.MouseLeave += new System.EventHandler(this.LblRight_MouseLeave);
            // 
            // lblJump
            // 
            this.lblJump.AutoSize = true;
            this.lblJump.BackColor = System.Drawing.Color.Transparent;
            this.lblJump.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblJump.Location = new System.Drawing.Point(69, 620);
            this.lblJump.Name = "lblJump";
            this.lblJump.Size = new System.Drawing.Size(266, 45);
            this.lblJump.TabIndex = 20;
            this.lblJump.Text = "Jump : Space";
            this.lblJump.Visible = false;
            this.lblJump.Click += new System.EventHandler(this.LblJump_Click);
            this.lblJump.MouseEnter += new System.EventHandler(this.LblJump_MouseEnter);
            this.lblJump.MouseLeave += new System.EventHandler(this.LblJump_MouseLeave);
            // 
            // lblMasterMix
            // 
            this.lblMasterMix.AutoSize = true;
            this.lblMasterMix.BackColor = System.Drawing.Color.Transparent;
            this.lblMasterMix.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMasterMix.Location = new System.Drawing.Point(60, 255);
            this.lblMasterMix.Name = "lblMasterMix";
            this.lblMasterMix.Size = new System.Drawing.Size(295, 58);
            this.lblMasterMix.TabIndex = 21;
            this.lblMasterMix.Text = "Master mix";
            this.lblMasterMix.Visible = false;
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.BackColor = System.Drawing.Color.Transparent;
            this.lblSound.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSound.Location = new System.Drawing.Point(69, 326);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(137, 45);
            this.lblSound.TabIndex = 22;
            this.lblSound.Text = "Sound";
            this.lblSound.Visible = false;
            // 
            // lblMusic
            // 
            this.lblMusic.AutoSize = true;
            this.lblMusic.BackColor = System.Drawing.Color.Transparent;
            this.lblMusic.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMusic.Location = new System.Drawing.Point(71, 384);
            this.lblMusic.Name = "lblMusic";
            this.lblMusic.Size = new System.Drawing.Size(127, 45);
            this.lblMusic.TabIndex = 23;
            this.lblMusic.Text = "Music";
            this.lblMusic.Visible = false;
            // 
            // lblBackToMenu
            // 
            this.lblBackToMenu.AutoSize = true;
            this.lblBackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblBackToMenu.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBackToMenu.Location = new System.Drawing.Point(725, 675);
            this.lblBackToMenu.Name = "lblBackToMenu";
            this.lblBackToMenu.Size = new System.Drawing.Size(274, 45);
            this.lblBackToMenu.TabIndex = 27;
            this.lblBackToMenu.Text = "Back to menu";
            this.lblBackToMenu.Visible = false;
            this.lblBackToMenu.Click += new System.EventHandler(this.LblBackToMenu_Click);
            this.lblBackToMenu.MouseEnter += new System.EventHandler(this.LblBackToMenu_MouseEnter);
            this.lblBackToMenu.MouseLeave += new System.EventHandler(this.LblBackToMenu_MouseLeave);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("Tahoma", 34F, System.Drawing.FontStyle.Bold);
            this.lblWin.Location = new System.Drawing.Point(560, 443);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(409, 56);
            this.lblWin.TabIndex = 28;
            this.lblWin.Text = "Congratulations!";
            this.lblWin.Visible = false;
            // 
            // lblSaveSettings
            // 
            this.lblSaveSettings.AutoSize = true;
            this.lblSaveSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblSaveSettings.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSaveSettings.Location = new System.Drawing.Point(725, 620);
            this.lblSaveSettings.Name = "lblSaveSettings";
            this.lblSaveSettings.Size = new System.Drawing.Size(267, 45);
            this.lblSaveSettings.TabIndex = 29;
            this.lblSaveSettings.Text = "Save settings";
            this.lblSaveSettings.Visible = false;
            this.lblSaveSettings.Click += new System.EventHandler(this.LblSaveSettings_Click);
            this.lblSaveSettings.MouseEnter += new System.EventHandler(this.LblSaveSettings_MouseEnter);
            this.lblSaveSettings.MouseLeave += new System.EventHandler(this.LblSaveSettings_MouseLeave);
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.Transparent;
            this.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Background.Location = new System.Drawing.Point(-2, 36);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1008, 724);
            this.Background.TabIndex = 4;
            this.Background.TabStop = false;
            this.Background.Visible = false;
            // 
            // pboxLogo
            // 
            this.pboxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxLogo.Location = new System.Drawing.Point(237, 23);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(574, 204);
            this.pboxLogo.TabIndex = 30;
            this.pboxLogo.TabStop = false;
            // 
            // pboxStartGame
            // 
            this.pboxStartGame.BackColor = System.Drawing.Color.Transparent;
            this.pboxStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxStartGame.Location = new System.Drawing.Point(340, 255);
            this.pboxStartGame.Name = "pboxStartGame";
            this.pboxStartGame.Size = new System.Drawing.Size(362, 100);
            this.pboxStartGame.TabIndex = 31;
            this.pboxStartGame.TabStop = false;
            this.pboxStartGame.Click += new System.EventHandler(this.LblStartGame_Click);
            this.pboxStartGame.MouseEnter += new System.EventHandler(this.LblStartGame_MouseEnter);
            this.pboxStartGame.MouseLeave += new System.EventHandler(this.LblStartGame_MouseLeave);
            // 
            // pboxSettings
            // 
            this.pboxSettings.BackColor = System.Drawing.Color.Transparent;
            this.pboxSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxSettings.Location = new System.Drawing.Point(363, 402);
            this.pboxSettings.Name = "pboxSettings";
            this.pboxSettings.Size = new System.Drawing.Size(318, 103);
            this.pboxSettings.TabIndex = 32;
            this.pboxSettings.TabStop = false;
            this.pboxSettings.Click += new System.EventHandler(this.LblSettings_Click);
            this.pboxSettings.MouseEnter += new System.EventHandler(this.LblSettings_MouseEnter);
            this.pboxSettings.MouseLeave += new System.EventHandler(this.LblSettings_MouseLeave);
            // 
            // pboxQuit
            // 
            this.pboxQuit.BackColor = System.Drawing.Color.Transparent;
            this.pboxQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxQuit.Location = new System.Drawing.Point(440, 549);
            this.pboxQuit.Name = "pboxQuit";
            this.pboxQuit.Size = new System.Drawing.Size(170, 100);
            this.pboxQuit.TabIndex = 33;
            this.pboxQuit.TabStop = false;
            this.pboxQuit.Click += new System.EventHandler(this.LblQuit_Click);
            this.pboxQuit.MouseEnter += new System.EventHandler(this.LblQuit_MouseEnter);
            this.pboxQuit.MouseLeave += new System.EventHandler(this.LblQuit_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 36);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLives.Location = new System.Drawing.Point(951, 9);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(18, 20);
            this.lblLives.TabIndex = 35;
            this.lblLives.Text = "2";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 759);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.pboxQuit);
            this.Controls.Add(this.pboxSettings);
            this.Controls.Add(this.pboxStartGame);
            this.Controls.Add(this.pboxLogo);
            this.Controls.Add(this.lblSaveSettings);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblBackToMenu);
            this.Controls.Add(this.lblMusic);
            this.Controls.Add(this.lblSound);
            this.Controls.Add(this.lblMasterMix);
            this.Controls.Add(this.lblJump);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.lblLvlName);
            this.Controls.Add(this.Background);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "Platrix";
            this.Deactivate += new System.EventHandler(this.Game_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxStartGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Timer FixedUpdate;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.Label lblLvlName;
        private System.Windows.Forms.Timer SecondUpdate;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblJump;
        private System.Windows.Forms.Label lblMasterMix;
        private System.Windows.Forms.Label lblSound;
        private System.Windows.Forms.Label lblMusic;
        private System.Windows.Forms.Label lblBackToMenu;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblSaveSettings;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.PictureBox pboxStartGame;
        private System.Windows.Forms.PictureBox pboxSettings;
        private System.Windows.Forms.PictureBox pboxQuit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLives;
    }
}

