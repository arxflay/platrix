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
            character.BackgroundImage = Platrix.Properties.Resources.character_right;
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
        Keys keyleft, keyright, keyjump;
        bool allowleft, allowright, allowjump, allowfalling, message;
        bool onmenu = true;
        const int MAXJUMP = 150;
        int clickleft, clickright, clickjump;      
        int moveright, moveleft, jumpsize, rptjump, rptFall;
        GameObject character = new GameObject();
        SoundPlayer psound;
        SoundPlayer pmusic;
        SortedList<string, GameObject> staticObjects = new SortedList<string, GameObject>();
        SortedList<string, GameObject> foregroundObjects = new SortedList<string, GameObject>();
        TextWriter logtxt = new StreamWriter("log"  + ".txt");

        public GameObject Flag()
        {
            GameObject gameobject = new GameObject();
            gameobject.Name = "oFlag";
            gameobject.Touchable = false;
            gameobject.Gravity = 0;
            gameobject.Width = 34;
            gameobject.Height = 55;
            gameobject.BackColor = Color.Transparent;
            gameobject.BackgroundImage = Platrix.Properties.Resources.flag_svg;
            gameobject.BackgroundImageLayout = ImageLayout.Stretch;
            return gameobject;
        }

        public GameObject Block()
        {
            GameObject gameobject = new GameObject();
            gameobject.Name = "oBlock"; //Initial name
            gameobject.Touchable = true;
            gameobject.Gravity = 0;
            gameobject.Width = 150; // Initial width
            gameobject.Height = 50; // Initial height
            gameobject.BackgroundImage = Platrix.Properties.Resources.block; //image
            gameobject.BackgroundImageLayout = ImageLayout.Stretch;
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

        public void LevelOne(bool enabling)
        {
            if (enabling == true)
            {
                PlaceObject(Block(), 0, 666, 1008, 63, "oGround");
                PlaceObject(Block(), 70, 566, 151, 42, "oPadOne");
                PlaceObject(Block(), 466, 486, 74, 42, "oPadTwo");
                PlaceObject(Block(), 321, 486, 74, 42, "oPadThree");
                PlaceObject(Block(), 634, 426, 158, 42, "oPadFour");
                PlaceObject(Block(), 844, 316, 104, 42, "oPadFive");
                PlaceObject(Block(), 567, 196, 173, 42, "oPadSix");
                PlaceObject(Block(), 321, 126, 142, 42, "oPadSeven");
                PlaceObject(Flag(), 374, 77, Flag().Width, Flag().Height, Flag().Name);
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
                oCharacter.Visible = true;
                LevelOne(true);
                onmenu = false;             
                FixedUpdate.Enabled = true;
                SecondUpdate.Enabled = true;              
            }
            else if (arg == 1)
            {
                lblSettings.Visible = false;
                lblStartGame.Visible = false;
                lblQuit.Visible = false;
                lblAutor.Visible = false;
                lblLogo.Visible = false;
            }
            else if (arg == 2)
            {
                lblSettings.Visible = true;
                lblStartGame.Visible = true;
                lblQuit.Visible = true;
                lblAutor.Visible = true;
                lblLogo.Visible = true;
            }
        }

        private void lblQuit_MouseEnter(object sender, EventArgs e)
        {
            lblQuit.ForeColor = Color.Red;
        }

        private void lblQuit_MouseLeave(object sender, EventArgs e)
        {
            lblQuit.ForeColor = Color.Black;
        }

        private void lblStartGame_MouseEnter(object sender, EventArgs e)
        {
            lblStartGame.ForeColor = Color.Red;
        }

        private void lblStartGame_MouseLeave(object sender, EventArgs e)
        {
            lblStartGame.ForeColor = Color.Black;
        }

        private void lblSettings_MouseEnter(object sender, EventArgs e)
        {
            lblSettings.ForeColor = Color.Red;
        }

        private void lblSettings_MouseLeave(object sender, EventArgs e)
        {
            lblSettings.ForeColor = Color.Black;
        }

        private void lblBackToMenu_MouseEnter(object sender, EventArgs e)
        {
            lblBackToMenu.ForeColor = Color.Red;
        }

        private void lblBackToMenu_MouseLeave(object sender, EventArgs e)
        {
            lblBackToMenu.ForeColor = Color.Black;
        }

        private void lblLeft_MouseEnter(object sender, EventArgs e)
        {
            lblLeft.ForeColor = Color.Red;
        }

        private void lblLeft_MouseLeave(object sender, EventArgs e)
        {
            lblLeft.ForeColor = Color.Black;
        }

        private void lblRight_MouseEnter(object sender, EventArgs e)
        {
            lblRight.ForeColor = Color.Red;
        }

        private void lblRight_MouseLeave(object sender, EventArgs e)
        {
            lblRight.ForeColor = Color.Black;
        }

        private void lblJump_MouseEnter(object sender, EventArgs e)
        {
            lblJump.ForeColor = Color.Red;
        }

        private void lblJump_MouseLeave(object sender, EventArgs e)
        {
            lblJump.ForeColor = Color.Black;
        }

        private void lblSaveSettings_MouseEnter(object sender, EventArgs e)
        {
            lblSaveSettings.ForeColor = Color.Red;
        }

        private void lblSaveSettings_MouseLeave(object sender, EventArgs e)
        {
            lblSaveSettings.ForeColor = Color.Black;
        }

        private void lblQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSettings_Click(object sender, EventArgs e)
        {
            SettingsMenu(true);
        }

        private void lblBackToMenu_Click(object sender, EventArgs e)
        {
            SettingsMenu(false);
        }

        private void lblStartGame_Click(object sender, EventArgs e)
        {
            ElementControl(1);
            ElementControl(0);
        }

        private void lblLeft_Click(object sender, EventArgs e)
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
  
        private void lblRight_Click(object sender, EventArgs e)
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

        private void lblJump_Click(object sender, EventArgs e)
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

        private void lblSaveSettings_Click(object sender, EventArgs e)
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
            if (e.KeyCode == keyleft && allowleft != true && onmenu == false)
            {
                allowleft = true;
                Debug.WriteLine("left = " + allowleft.ToString());
            }
            if (e.KeyCode == keyright && allowright != true && onmenu == false)
            {
                allowright = true;
                Debug.WriteLine("right = " + allowright.ToString());
            }
            if (e.KeyCode == Keys.Enter && onmenu == true)
            {
                ElementControl(1);
                ElementControl(0);
            }
            if (e.KeyCode == keyjump && jumpsize == 0 && allowjump != true && onmenu == false)
            {
                allowjump = true;
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == keyleft && onmenu == false)
            {
                allowleft = false;
                Debug.WriteLine("left = " + allowleft.ToString());
            }
            else if (e.KeyCode == keyright && onmenu == false)
            {
                allowright = false;
                Debug.WriteLine("right = " + allowright.ToString());
            }
        }

        public bool check(int a, int b)
        {
            for (int i = 0; i < 5; i++)
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
                if (oCharacter.Bottom <= staticObjects["oPadSeven"].Top && check(oCharacter.Location.X, staticObjects["oFlag"].Location.X) && message == false)
                {
                    message = true; //message sended
                    allowleft = false; //move l disabled
                    allowright = false; //move r disabled
                    lblWin.Visible = true; //activated winning lable
                    lblLvlName.Visible = false; //lvlname disabled
                    FixedUpdate.Enabled = false; 
                    SecondUpdate.Enabled = false;
                    oCharacter.Visible = false;
                    LevelOne(false);
                    Background.Visible = false;
                }
            }
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
                            if ((oCharacter.Top == staticObjects[obj].Bottom && oCharacter.Bottom > staticObjects[obj].Top) && (oCharacter.Left < staticObjects[obj].Right && oCharacter.Right > staticObjects[obj].Left) || jumpsize == MAXJUMP)
                            {
                                Debug.WriteLine("jump false");
                                allowjump = false;
                                allowfalling = true;

                                break;
                            }
                        }
                    }
                    jumpsize += 1;
                    oCharacter.Top -= 1;
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
                        if (oCharacter.Bottom == staticObjects[obj].Top && oCharacter.Left < staticObjects[obj].Right && oCharacter.Right > staticObjects[obj].Left)
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
                oCharacter.Top += 1;
                ++rptFall;
            }
            rptFall = 0;
            
            if (allowleft == true)
            {
                oCharacter.BackgroundImage = Platrix.Properties.Resources.character_left;
                 while ((oCharacter.Left > Background.Left))
                {
                    if (moveleft == 5)
                    {
                        break;
                    }
                    oCharacter.Left -= 1;
                    ++moveleft;
                }
                moveleft = 0;
            }
            if (allowright == true)
            {
                oCharacter.BackgroundImage = Platrix.Properties.Resources.character_right;
                while (oCharacter.Right < Background.Right)
                {
                    if (moveright == 5)
                    {
                        break;
                    }
                    oCharacter.Left += 1;
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
                    logtxt.WriteLine(DateTime.Now + " Wrong left keymap");
                    return false;
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
                    logtxt.WriteLine(DateTime.Now + " Wrong right keymap");
                    return false;
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
                    logtxt.WriteLine(DateTime.Now + " Wrong jump keymap:" + txt);
                    return false;
                }
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
            public int Gravity { get { return gravity; } set { gravity = value; } }
            public bool Touchable { get { return touchable; } set { touchable = value; } }
        }

    }
}
