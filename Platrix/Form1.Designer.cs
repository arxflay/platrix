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
            this.lblStartGame = new System.Windows.Forms.Label();
            this.lblQuit = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.FixedUpdate = new System.Windows.Forms.Timer(this.components);
            this.oCharacter = new System.Windows.Forms.PictureBox();
            this.Background = new System.Windows.Forms.PictureBox();
            this.lblLvlName = new System.Windows.Forms.Label();
            this.SecondUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblSettings = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.oCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStartGame
            // 
            this.lblStartGame.AutoSize = true;
            this.lblStartGame.BackColor = System.Drawing.Color.Transparent;
            this.lblStartGame.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStartGame.Location = new System.Drawing.Point(374, 248);
            this.lblStartGame.Name = "lblStartGame";
            this.lblStartGame.Size = new System.Drawing.Size(293, 58);
            this.lblStartGame.TabIndex = 0;
            this.lblStartGame.Text = "Start game";
            this.lblStartGame.Click += new System.EventHandler(this.lblStartGame_Click);
            this.lblStartGame.MouseEnter += new System.EventHandler(this.lblStartGame_MouseEnter);
            this.lblStartGame.MouseLeave += new System.EventHandler(this.lblStartGame_MouseLeave);
            // 
            // lblQuit
            // 
            this.lblQuit.AutoSize = true;
            this.lblQuit.BackColor = System.Drawing.Color.Transparent;
            this.lblQuit.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuit.Location = new System.Drawing.Point(456, 486);
            this.lblQuit.Name = "lblQuit";
            this.lblQuit.Size = new System.Drawing.Size(127, 58);
            this.lblQuit.TabIndex = 1;
            this.lblQuit.Text = "Quit";
            this.lblQuit.Click += new System.EventHandler(this.lblQuit_Click);
            this.lblQuit.MouseEnter += new System.EventHandler(this.lblQuit_MouseEnter);
            this.lblQuit.MouseLeave += new System.EventHandler(this.lblQuit_MouseLeave);
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
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Tahoma", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogo.Location = new System.Drawing.Point(317, 21);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(408, 129);
            this.lblLogo.TabIndex = 3;
            this.lblLogo.Text = "Platrix";
            // 
            // FixedUpdate
            // 
            this.FixedUpdate.Interval = 1;
            this.FixedUpdate.Tick += new System.EventHandler(this.FixedUpdate_Tick);
            // 
            // oCharacter
            // 
            this.oCharacter.BackColor = System.Drawing.Color.Transparent;
            this.oCharacter.BackgroundImage = global::Platrix.Properties.Resources.character_right;
            this.oCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.oCharacter.Location = new System.Drawing.Point(498, 618);
            this.oCharacter.Name = "oCharacter";
            this.oCharacter.Size = new System.Drawing.Size(34, 47);
            this.oCharacter.TabIndex = 1;
            this.oCharacter.TabStop = false;
            this.oCharacter.Visible = false;
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.Transparent;
            this.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1008, 729);
            this.Background.TabIndex = 4;
            this.Background.TabStop = false;
            this.Background.Visible = false;
            // 
            // lblLvlName
            // 
            this.lblLvlName.AutoSize = true;
            this.lblLvlName.BackColor = System.Drawing.Color.Transparent;
            this.lblLvlName.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLvlName.Location = new System.Drawing.Point(8, 9);
            this.lblLvlName.Name = "lblLvlName";
            this.lblLvlName.Size = new System.Drawing.Size(190, 29);
            this.lblLvlName.TabIndex = 7;
            this.lblLvlName.Text = "Level 1 - Stairs";
            this.lblLvlName.Visible = false;
            // 
            // SecondUpdate
            // 
            this.SecondUpdate.Interval = 1;
            this.SecondUpdate.Tick += new System.EventHandler(this.SecondUpdate_Tick);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblSettings.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSettings.Location = new System.Drawing.Point(404, 371);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(224, 58);
            this.lblSettings.TabIndex = 16;
            this.lblSettings.Text = "Settings";
            this.lblSettings.Click += new System.EventHandler(this.lblSettings_Click);
            this.lblSettings.MouseEnter += new System.EventHandler(this.lblSettings_MouseEnter);
            this.lblSettings.MouseLeave += new System.EventHandler(this.lblSettings_MouseLeave);
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
            this.lblLeft.Click += new System.EventHandler(this.lblLeft_Click);
            this.lblLeft.MouseEnter += new System.EventHandler(this.lblLeft_MouseEnter);
            this.lblLeft.MouseLeave += new System.EventHandler(this.lblLeft_MouseLeave);
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
            this.lblRight.Click += new System.EventHandler(this.lblRight_Click);
            this.lblRight.MouseEnter += new System.EventHandler(this.lblRight_MouseEnter);
            this.lblRight.MouseLeave += new System.EventHandler(this.lblRight_MouseLeave);
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
            this.lblJump.Click += new System.EventHandler(this.lblJump_Click);
            this.lblJump.MouseEnter += new System.EventHandler(this.lblJump_MouseEnter);
            this.lblJump.MouseLeave += new System.EventHandler(this.lblJump_MouseLeave);
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
            this.lblBackToMenu.Location = new System.Drawing.Point(732, 675);
            this.lblBackToMenu.Name = "lblBackToMenu";
            this.lblBackToMenu.Size = new System.Drawing.Size(274, 45);
            this.lblBackToMenu.TabIndex = 27;
            this.lblBackToMenu.Text = "Back to menu";
            this.lblBackToMenu.Visible = false;
            this.lblBackToMenu.Click += new System.EventHandler(this.lblBackToMenu_Click);
            this.lblBackToMenu.MouseEnter += new System.EventHandler(this.lblBackToMenu_MouseEnter);
            this.lblBackToMenu.MouseLeave += new System.EventHandler(this.lblBackToMenu_MouseLeave);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("Tahoma", 34F, System.Drawing.FontStyle.Bold);
            this.lblWin.Location = new System.Drawing.Point(316, 297);
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
            this.lblSaveSettings.Location = new System.Drawing.Point(732, 620);
            this.lblSaveSettings.Name = "lblSaveSettings";
            this.lblSaveSettings.Size = new System.Drawing.Size(267, 45);
            this.lblSaveSettings.TabIndex = 29;
            this.lblSaveSettings.Text = "Save settings";
            this.lblSaveSettings.Visible = false;
            this.lblSaveSettings.Click += new System.EventHandler(this.lblSaveSettings_Click);
            this.lblSaveSettings.MouseEnter += new System.EventHandler(this.lblSaveSettings_MouseEnter);
            this.lblSaveSettings.MouseLeave += new System.EventHandler(this.lblSaveSettings_MouseLeave);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Platrix.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lblSaveSettings);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.oCharacter);
            this.Controls.Add(this.lblBackToMenu);
            this.Controls.Add(this.lblMusic);
            this.Controls.Add(this.lblSound);
            this.Controls.Add(this.lblMasterMix);
            this.Controls.Add(this.lblJump);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.lblLvlName);
            this.Controls.Add(this.Background);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblQuit);
            this.Controls.Add(this.lblStartGame);
            this.Controls.Add(this.lblLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.Text = "Platrix";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.oCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartGame;
        private System.Windows.Forms.Label lblQuit;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Timer FixedUpdate;
        private System.Windows.Forms.PictureBox oCharacter;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.Label lblLvlName;
        private System.Windows.Forms.Timer SecondUpdate;
        private System.Windows.Forms.Label lblSettings;
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
    }
}

