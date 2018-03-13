using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Media;
namespace Platrix
{
    public partial class Game : Form
    {
        
        public Game()
        {
            InitializeComponent();
        }
        
        private void Game_Load(object sender, EventArgs e)
        {
        	this.BackgroundImage = Image.FromFile("./data/images/background.png");
        	this.BackgroundImageLayout = ImageLayout.Stretch;
        	ImageSetter(ref Background, "./data/images/background.png");
            ImageSetter(ref pboxLogo, "./data/images/gui/logo.png");
            ImageSetter(ref pboxStartGame, "./data/images/gui/startgame.png");
            ImageSetter(ref pboxSettings, "./data/images/gui/settings.png");
            ImageSetter(ref pboxQuit, "./data/images/gui/quit.png");
            character.Size = new Size(34, 47);
            GameObjectImageSetter(ref character, "./data/images/character_left.png");
            character.Gravity = 10;
            character.BackColor = Color.Transparent;
            character.Name = "oCharacter";
            if (!(File.Exists("settings.txt")))
            {
                File.Create("settings.txt").Close();
                keyleft = Keys.Left;
                keyright = Keys.Right;
                keyjump = Keys.Space;
                if (SaveSettings() == false)
                {
                    logtxt.WriteLine(DateTime.Now + " Settings wasn't saved");
                }
                else
                {
                    logtxt.WriteLine(DateTime.Now + " Settings was loaded without any error");
                }
            }
            else
            {
                if (LoadSettings() == false)
                {
                    logtxt.WriteLine(DateTime.Now + " Settings wasn't loaded");
                    keyleft = Keys.Left;
                    keyright = Keys.Right;
                    keyjump = Keys.Space;
                    clickleft = 1;
                    clickright = 1;
                    clickjump = 1;
                    lblLeft.Text = "Left : Leftarrow";
                    lblRight.Text = "Right : Rightaarow";
                    lblJump.Text = "Jump : Space";
                    logtxt.WriteLine(DateTime.Now + " Using default settings");
                }
                else
                {
                    logtxt.WriteLine(DateTime.Now + " Settings was loaded without any error");
                }
            }
        }
        public void ImageSetter(ref PictureBox pb, string fileroad)
        {
            try
            {
                pb.BackgroundImage = Image.FromFile(fileroad);
                if (pb.BackgroundImageLayout != ImageLayout.Stretch)
                {
                    pb.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            catch
            {
                if (MessageBox.Show(fileroad + " resource missing!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
        public void GameObjectImageSetter(ref GameObject gobj, string fileroad)
        {
            try
            {
                gobj.BackgroundImage = Image.FromFile(fileroad);
                if (gobj.BackgroundImageLayout != ImageLayout.Stretch)
                {
                    gobj.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            catch
            {
                if (MessageBox.Show(fileroad + " resource missing!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
        Keys keyleft, keyright, keyjump;
        bool allowleft, allowright, allowjump, allowfalling, message, messagedeath = false;
        bool onmainmenu = true;
        const int MAXJUMP = 150;
        int clickleft, clickright, clickjump;      
        int moveright, moveleft, jumpsize, rptjump, rptFall;
        int onlevel = 1;
        int lives = 2;
        GameObject character = new GameObject();
        PictureBox menugui = new PictureBox();
        SortedList<string, GameObject> staticObjects = new SortedList<string, GameObject>();
        SortedList<string, GameObject> foregroundObjects = new SortedList<string, GameObject>();
        TextWriter logtxt = new StreamWriter("log"  + ".txt");
        public void PlaceAndSetCharacter(int x, int y)
        {
            character.Location = new Point(x, y);
            this.Controls.Add(character);
        }
        public void RemoveCharacter()
        {
            this.Controls.Remove(character);
        }
        public GameObject Flag()
        {
            GameObject gameobject = new GameObject();
            {
                gameobject.Name = "oFlag";
                gameobject.Touchable = false;
                gameobject.Gravity = 0;
                gameobject.Width = 34;
                gameobject.Height = 55;
                gameobject.BackColor = Color.Transparent;
                GameObjectImageSetter(ref gameobject, "./data/images/flag.png");
            };
            return gameobject;
        }

        public GameObject Block()
        {
            GameObject gameobject = new GameObject();
            {
                gameobject.Name = "oBlock"; //Initial name
                gameobject.Touchable = true;
                gameobject.Gravity = 0;
                gameobject.Width = 150; // Initial width
                gameobject.Height = 50; // Initial height
                gameobject.BackColor = Color.Transparent;
                GameObjectImageSetter(ref gameobject,"./data/images/block.png");         
            };
        return gameobject;
        }
        public GameObject Gr_grass()
        {
            GameObject gameobject = new GameObject();
            {
                gameobject.Name = "oGr_grass";
                gameobject.Touchable = true;
                gameobject.Gravity = 0;
                gameobject.Width = 1008;
                gameobject.Height = 63;
                GameObjectImageSetter(ref gameobject, "./data/images/gr_ground.png");
            };
            return gameobject;
        }
        public bool PlaceObject(GameObject gameobj, int locX, int locY, int width, int height, string name)
        {       
            gameobj.Location = new Point(locX, locY);
            gameobj.Width = width;
            gameobj.Height = height;
            gameobj.Name = name;
            gameobj.Visible = true;
            if ((!staticObjects.ContainsKey(name)))
            {
                this.Controls.Add(gameobj);
                staticObjects.Add(name, gameobj);
            }
            else
            {
                logtxt.WriteLine(DateTime.Now + "GameObject " + name + "exist, object wasn't added");
                return false;
            }
            return true;
        }

        public bool DestroyObject(string name)
        {
            if (staticObjects.ContainsKey(name))
            {
                this.Controls.RemoveByKey(name);
                staticObjects.Remove(name);
            }
            else
            {
                return false;
            }
            return true;
        }
        public void LevelTwo(bool enabling)
        {
            if (enabling == true)
            {
                lblLvlName.Text = "Level " + onlevel + " - The way along pit";
                PlaceObject(Gr_grass(), 588, 696, 420, Gr_grass().Height, "oGround");
                PlaceObject(Block(), 717, 594, 41, 36, "oPadOne");
                PlaceObject(Block(), 623, 484, 44, 36, "oPadTwo");
                PlaceObject(Block(), 728, 379, 40, 36, "oPadThree");
                PlaceObject(Block(), 850, 379, 108, 36, "oPadFour");
                PlaceObject(Block(), 918, 230, 40, 36, "oPadFive");
                PlaceObject(Block(), 775, 113, 68, 36, "oPadSix");
                PlaceObject(Block(), 647, 113, 68, 36, "oPadSeven");
                PlaceObject(Block(), 358, 139, 209, 36, "oPadEight");
                PlaceObject(Block(), 174, 242, 69, 36, "oPadNine");
                PlaceObject(Block(), 13, 721, 132, 36, "oPadTen");
                PlaceAndSetCharacter(588, 638);
                PlaceObject(Flag(), 56, 661, Flag().Width, Flag().Height, Flag().Name);
            }
            if (enabling == false)
            {
                DestroyObject("oGround");
                DestroyObject("oFlag");
                DestroyObject("oPadOne");
                DestroyObject("oPadTwo");
                DestroyObject("oPadThree");
                DestroyObject("oPadFour");
                DestroyObject("oPadFive");
                DestroyObject("oPadSix");
                DestroyObject("oPadSeven");
                DestroyObject("oPadEight");
                DestroyObject("oPadNine");
                DestroyObject("oPadTen");
                DestroyObject("oFlag");
                RemoveCharacter();
            }
        }
        public void LevelOne(bool enabling)
        {
            
            if (enabling == true)
            {
                lblLvlName.Text = "Level " + onlevel + " - Stairs";
                PlaceObject(Gr_grass(), 0, 696, Gr_grass().Width, Gr_grass().Height, "oGround");
                PlaceObject(Block(), 70, 597, 151, 42, "oPadOne");
                PlaceObject(Block(), 466, 517, 74, 42, "oPadTwo");
                PlaceObject(Block(), 321, 517, 74, 42, "oPadThree");
                PlaceObject(Block(), 634, 457, 158, 42, "oPadFour");
                PlaceObject(Block(), 844, 347, 104, 42, "oPadFive");
                PlaceObject(Block(), 567, 227, 173, 42, "oPadSix");
                PlaceObject(Block(), 321, 157, 142, 42, "oPadSeven");
                PlaceObject(Flag(), 374, 108, Flag().Width, Flag().Height, Flag().Name);
                PlaceAndSetCharacter(498, 638);
            }
            if (enabling == false)
            {
                DestroyObject("oGround");
                DestroyObject("oFlag");
                DestroyObject("oPadOne");
                DestroyObject("oPadTwo");
                DestroyObject("oPadThree");
                DestroyObject("oPadFour");
                DestroyObject("oPadFive");
                DestroyObject("oPadSix");
                DestroyObject("oPadSeven");
                RemoveCharacter();
            }
        }

        public void SettingsMenu(bool arg)
        {
            if (arg == true)
            {
                ElementControl(1);
            }
            else if (arg == false)
            {
                ElementControl(2);
            }
            lblSaveSettings.Visible = arg;
            lblBackToMenu.Visible = arg;
            lblControls.Visible = arg;
            lblLeft.Visible = arg;
            lblRight.Visible = arg;
            lblJump.Visible = arg;
        }

        public void ElementControl(int arg)
        {
            if (arg == 0)
            {
                LevelOne(true);
                lblLvlName.Visible = true;
                onmainmenu = false;             
                FixedUpdate.Enabled = true;
                SecondUpdate.Enabled = true;              
            }
            else if (arg == 1)
            {
                pboxSettings.Visible = false;
                pboxStartGame.Visible = false;
                pboxQuit.Visible = false;
                lblAutor.Visible = false;
                pboxLogo.Visible = false;
            }
            else if (arg == 2 || arg == 3)
            {
                pboxSettings.Visible = true;
                pboxStartGame.Visible = true;
                pboxQuit.Visible = true;
                if (arg == 3)
                {
                    lblAutor.Visible = true;
                }
                pboxLogo.Visible = true;
            }
        }

        private void LblQuit_MouseEnter(object sender, EventArgs e)
        {
        	ImageSetter(ref pboxQuit, "./data/images/gui/quit_light.png");
        }

        private void LblQuit_MouseLeave(object sender, EventArgs e)
        {
        	ImageSetter(ref pboxQuit, "./data/images/gui/quit.png");
        }

        private void LblStartGame_MouseEnter(object sender, EventArgs e)
        {
            ImageSetter(ref pboxStartGame, "./data/images/gui/startgame_light.png");
        }

        private void LblStartGame_MouseLeave(object sender, EventArgs e)
        {
            ImageSetter(ref pboxStartGame, "./data/images/gui/startgame.png");
        }

        private void LblSettings_MouseEnter(object sender, EventArgs e)
        {
            ImageSetter(ref pboxSettings, "./data/images/gui/settings_light.png");
        }

        private void LblSettings_MouseLeave(object sender, EventArgs e)
        {
            ImageSetter(ref pboxSettings, "./data/images/gui/settings.png");
        }

        private void LblBackToMenu_MouseEnter(object sender, EventArgs e)
        {
            lblBackToMenu.ForeColor = Color.Red;
        }

        private void LblBackToMenu_MouseLeave(object sender, EventArgs e)
        {
            lblBackToMenu.ForeColor = Color.Black;
        }

        private void LblLeft_MouseEnter(object sender, EventArgs e)
        {
            lblLeft.ForeColor = Color.Red;
        }

        private void LblLeft_MouseLeave(object sender, EventArgs e)
        {
            lblLeft.ForeColor = Color.Black;
        }

        private void LblRight_MouseEnter(object sender, EventArgs e)
        {
            lblRight.ForeColor = Color.Red;
        }

        private void LblRight_MouseLeave(object sender, EventArgs e)
        {
            lblRight.ForeColor = Color.Black;
        }

        private void LblJump_MouseEnter(object sender, EventArgs e)
        {
            lblJump.ForeColor = Color.Red;
        }

        private void LblJump_MouseLeave(object sender, EventArgs e)
        {
            lblJump.ForeColor = Color.Black;
        }

        private void LblSaveSettings_MouseEnter(object sender, EventArgs e)
        {
            lblSaveSettings.ForeColor = Color.Red;
        }

        private void LblSaveSettings_MouseLeave(object sender, EventArgs e)
        {
            lblSaveSettings.ForeColor = Color.Black;
        }

        private void LblQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblSettings_Click(object sender, EventArgs e)
        {
            SettingsMenu(true);
        }

        private void LblBackToMenu_Click(object sender, EventArgs e)
        {
            SettingsMenu(false);
        }

        private void LblStartGame_Click(object sender, EventArgs e)
        {
            ElementControl(1);
            ElementControl(0);
        }

        private void LblLeft_Click(object sender, EventArgs e)
        {
            lblLeft.Text = "Left : ";
            if (clickleft == 0)
            {
                lblLeft.Text += "Left arrow";
                keyleft = Keys.Left;
                ++clickleft;
            }
            else if (clickleft == 1)
            {
                lblLeft.Text += "A";
                keyleft = Keys.A;
                ++clickleft;
            }
            else if (clickleft == 2)
            {
                lblLeft.Text += "NUMPAD 4";
                keyleft = Keys.NumPad4;
                clickleft = 0;
            }
        }
  
        private void LblRight_Click(object sender, EventArgs e)
        {
            lblRight.Text = "Right : ";
            if (clickright == 0)
            {
                lblRight.Text += "Right arrow";
                keyright = Keys.Right;
                ++clickright;
            }
            else if (clickright == 1)
            {
                lblRight.Text += "D";
                keyright = Keys.D;
                ++clickright;
            }
            else if (clickright == 2)
            {
                lblRight.Text += "NUMPAD 6";
                keyright = Keys.NumPad6;
                clickright = 0;
            }
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            logtxt.Close();
        }

        private void LblJump_Click(object sender, EventArgs e)
        {
            lblJump.Text = "Jump : ";
            if (clickjump == 0)
            {
                lblJump.Text += "Space";
                keyjump = Keys.Space;
                ++clickjump;
            }
            else if (clickjump == 1)
            {
                lblJump.Text += "W";
                keyjump = Keys.W;
                ++clickjump;
            }
            else if (clickjump == 2)
            {
                lblJump.Text += "NUMPAD 8";
                keyjump = Keys.NumPad8;
                clickjump = 0;
            }
        }

        private void LblSaveSettings_Click(object sender, EventArgs e)
        {
            if (SaveSettings() == true)
            {
                MessageBox.Show("Settings was saved", "Platrix");
            }
            else
            {
                MessageBox.Show("Settings wasn't saved", "Platrix");
            }           
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == keyleft && allowleft != true && onmainmenu == false)
            {
                allowleft = true;
                Debug.WriteLine("left = " + allowleft.ToString());
            }
            if (e.KeyCode == keyright && allowright != true && onmainmenu == false)
            {
                allowright = true;
                Debug.WriteLine("right = " + allowright.ToString());
            }
            if (e.KeyCode == Keys.Enter && onmainmenu == true)
            {
                ElementControl(1);
                ElementControl(0);
            }
            if (e.KeyCode == keyjump && jumpsize == 0 && allowjump != true && onmainmenu == false)
            {
                allowjump = true;
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == keyleft && onmainmenu == false)
            {
                allowleft = false;
                Debug.WriteLine("left = " + allowleft.ToString());
            }
            else if (e.KeyCode == keyright && onmainmenu == false)
            {
                allowright = false;
                Debug.WriteLine("right = " + allowright.ToString());
            }
        }

        public bool CheckLoc(int a, int b)
        {
            for (int i = 0; i < 10; i++)
            {
                if (a + i == b)
                {
                    return true;
                }
            }
            return false;
        }

        private void SecondUpdate_Tick(object sender, EventArgs e) //Specific tick to control EndPoint
        {
            if (staticObjects.ContainsKey("oFlag"))
            {
            	switch(onlevel)
                	{
                		case 1 :
            				if (character.Bottom <= staticObjects["oPadSeven"].Top && CheckLoc(character.Location.X, staticObjects["oFlag"].Location.X) && message == false)
                			{
                                ++onlevel;
								LevelOne(false);
                				LevelTwo(true);        					
                			}
                			break;
                		case 2 :
                			if (character.Bottom <= staticObjects["oPadTen"].Top && CheckLoc(character.Location.X, staticObjects["oFlag"].Location.X) && message == false)
                			{
                                ++onlevel;
                				LevelTwo(false);
                				MessageBox.Show("Indev test 2 completed");
                			}
                			break;
                		case 3 :
                			{
                				break;
                			}
                	}     
                
            }
            if (character.Top > Background.Bottom)
            {
                RemoveCharacter();
                allowleft = false;
                allowright = false;
                if (lives != 0)
                {
                    if (messagedeath == false)
                    {
                        --lives;
                        lblLives.Text = lives.ToString();
                        messagedeath = true;
                        MessageBox.Show("You died!");
                        PlaceAndSetCharacter(588, 618);
                        messagedeath = false;
                    }

                }
                else
                {
                    RemoveCharacter();
                    LevelTwo(false);
                    if (messagedeath == false)
                    {
                        messagedeath = true;
                        MessageBox.Show("Your lives left");
                        if (MessageBox.Show("Try again?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            onlevel = 1;
                            lives = 2;
                            lblLives.Text = lives.ToString();
                            LevelOne(true);
                            messagedeath = false;
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }
            /*foreach (string gobj in staticObjects.Keys) Will be used in future
            {
                if (staticObjects[gobj].Gravity != 0)
                {
                    string key = gobj;
                    int temprptFall = 0;
                    {
                        while (temprptFall != 10)
                        {
                            foreach (string obj in staticObjects.Keys)
                            {
                                if (obj != key)
                                {
                                    if (staticObjects[obj].Touchable == true)
                                    {
                                        if (staticObjects[key].Bottom == staticObjects[obj].Top && staticObjects[key].Left < staticObjects[obj].Right && staticObjects[key].Right > staticObjects[obj].Left)
                                        {
                                            if (jumpsize > 0)
                                            {
                                                Debug.WriteLine("jumpsize = 0");
                                                jumpsize = 0;
                                            }
                                            rptFall = 9;
                                            staticObjects[key].AllowFalling = false;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        allowfalling = true;
                                    }
                                }
                            }
                            if (allowfalling == false)
                            {
                                break;
                            }
                        }
                        oCharacter.Top += 1;
                        ++rptFall;
                    }
                }
            }
            */
        }

        private void FixedUpdate_Tick(object sender, EventArgs e) //Main tick to control almost everything
        {
            if (jumpsize <= MAXJUMP && allowjump == true)
            {
                while (rptjump != 10)
                {
                    foreach (string obj in staticObjects.Keys)
                    {
                        if (staticObjects[obj].Touchable == true)
                        {
                            if ((character.Top == staticObjects[obj].Bottom && character.Bottom > staticObjects[obj].Top) && (character.Left < staticObjects[obj].Right && character.Right > staticObjects[obj].Left) || jumpsize == MAXJUMP)
                            {
                                Debug.WriteLine("jump false");
                                allowjump = false;
                                allowfalling = true;

                                break;
                            }
                        }
                    }
                    jumpsize += 1;
                    character.Top -= 1;
                    ++rptjump;
                }
                rptjump = 0;
            }
            while (rptFall != 10 && allowjump == false)
            {
                foreach (string obj in staticObjects.Keys)
                {
                    if (staticObjects[obj].Touchable == true)
                    {
                        if (character.Bottom == staticObjects[obj].Top && character.Left < staticObjects[obj].Right && character.Right > staticObjects[obj].Left)
                        {
                            if (jumpsize > 0)
                            {
                                Debug.WriteLine("jumpsize = 0");
                                jumpsize = 0;
                            }
                            rptFall = 9;
                            allowfalling = false;
                            break;
                        }
                    }
                    else
                    {
                        allowfalling = true;
                    }	
                }
                if (allowfalling == false)
                {
                    break;
                }
                character.Top += 1;
                ++rptFall;
            }
            rptFall = 0;
            
            if (allowleft == true)
            {
                character.BackgroundImage = Image.FromFile("./data/images/character_left.png");
                 while ((character.Left > Background.Left))
                {
                    if (moveleft == 5)
                    {
                        break;
                    }
                    character.Left -= 1;
                    ++moveleft;
                }
                moveleft = 0;
            }
            if (allowright == true)
            {
                character.BackgroundImage = Image.FromFile("./data/images/character_right.png");
                while (character.Right < Background.Right)
                {
                    if (moveright == 5)
                    {
                        break;
                    }
                    character.Left += 1;
                    ++moveright;
                }
                moveright = 0;
            }
        }

        public bool SaveSettings() //SavingSetts
        {
            TextWriter txter = null;
            try
            {
                txter = new StreamWriter("settings.txt");
                txter.WriteLine("left: " + keyleft.ToString().ToLower());
                txter.WriteLine("right: " + keyright.ToString().ToLower());
                txter.WriteLine("jump: " + keyjump.ToString().ToLower());
            }
            catch
            {
                return false;
            }
            finally
            {
                if (txter != null) txter.Close();
            }
            return true;
        }

        public bool LoadSettings() //LoadingSetts
        {
            string errorlist = "";
            TextReader reader = null;
            try
            {
                reader = new StreamReader("settings.txt"); 
                string txt = reader.ReadLine().Substring(5).ToLower().Trim();
                if (txt == "left")
                {
                    keyleft = Keys.Left;
                    clickleft = 1;
                    lblLeft.Text = "Left : Leftarrow";
                }
                else if (txt == "a")
                {
                    keyleft = Keys.A;
                    clickleft = 2;
                    lblLeft.Text = "Left : A";
                }
                else if (txt == "numpad4")
                { 
                    keyleft = Keys.NumPad4;
                    clickleft = 0;
                    lblLeft.Text = "Left : Numpad 8";
                }
                else
                {
                    errorlist += "[1]Wrong left keymap ";
                }
                txt = reader.ReadLine().Substring(6).ToLower().Trim();
                if (txt == "right")
                {
                    keyright = Keys.Right;
                    clickright = 1;
                    lblRight.Text = "Right : Rightarrow";
                }
                else if (txt == "d")
                {
                    keyright = Keys.D;
                    clickright = 2;
                    lblRight.Text = "Right : D";
                }
                else if (txt == "numpad6")
                {
                    keyright = Keys.NumPad6;
                    clickright = 0;
                    lblRight.Text = "Right : Numpad 6";

                }
                else
                {
                    errorlist += "[2]Wrong right keymap ";
                }
                txt = reader.ReadLine().Substring(5).ToLower().Trim();
                if (txt == "space")
                {
                    keyjump = Keys.Space;
                    clickjump = 1;
                    lblJump.Text = "Jump : Space";
                }
                else if (txt == "w")
                {
                    keyjump = Keys.W;
                    clickjump = 2;
                    lblJump.Text = "Jump : W";
                }
                else if (txt == "numpad8")
                {
                    keyjump = Keys.NumPad8;
                    clickjump = 0;
                    lblJump.Text = "Jump : Numpad 8";
                }
                else
                {
                    errorlist += "[3]Wrong right keymap ";
                }
                if (errorlist != "") { logtxt.WriteLine(DateTime.Now + " " + errorlist); return false; }
            }
            catch
            {
                return false;
            }
            finally
            {
                if (reader != null) reader.Close();
            }
            return true;
        }

        public class GameObject : PictureBox //Child of PictureBox
        {
            private int gravity;
            private bool touchable;
            private bool objallowfalling;
            public int Gravity { get { return gravity; } set { gravity = value; } }
            public bool AllowFalling { get { return objallowfalling;} set { objallowfalling = value; } }
            public bool Touchable { get { return touchable; } set { touchable = value; } }
        }

        private void Game_Deactivate(object sender, EventArgs e)
        {
            allowleft = false;
            allowright = false;
        }
    }
}
