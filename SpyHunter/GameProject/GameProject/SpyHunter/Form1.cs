using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// MAIN COPY
// Liam Patrick Dancy, the one and only, and Marcus Anthony "MADDOG" David, the one.
// June 16th, 2023
// Spy Hunter, the game where spies hunt you. Dumb name.

// NOTES
// Have everything slowly fall down
// Use asteroid counter from thing to count trees, have them constantly spawn in ramdnow new spots and fall down
// Have the car constantly go down, when it is at the bottom border have the fall down stop until new height is added
// Use collision detector from asteroids to determine if cars hit, have angle of collision be random
// One long road, no turns or edges
// Have current score be used in a for loop, record total high score in that session somehow
// Have a life system

namespace SpyHunter
{
    public partial class Form1 : Form
    {
        //global variables
        bool Started = false;
        int Score = 0;
        bool SpyLeft, SpyRight, SpyUp, SpyDown = false;
        bool ReloadBullet;
        bool GoDown = true;
        int Health = 3;
        int EnemyHealth = 6;

        bool DamageTaken = false;
        bool GoRight = false;
        bool GoLeft = false;


        List<PictureBox> Bullets = new List<PictureBox>();
        List<PictureBox> Bullets2 = new List<PictureBox>();
        List<PictureBox> EnemyBullets = new List<PictureBox>();
        List<Cars> Enemies = new List<Cars>();
        List<TreesLeft> TreesL = new List<TreesLeft>();
        List<TreesRight> TreesR = new List<TreesRight>();
        Random oRandom = new Random();

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (Started)
            {
                if (e.KeyCode == Keys.Up)
                {
                    SpyUp = false;
                }
                if (e.KeyCode == Keys.Left)
                {
                    SpyLeft = false;
                }
                if (e.KeyCode == Keys.Right)
                {
                    SpyRight = false;
                }
                if (e.KeyCode == Keys.Down)
                {
                    SpyDown = false;
                }
                if (e.KeyCode == Keys.Space)
                {
                    ReloadBullet = false;
                }

                if (e.KeyCode == Keys.Back)
                {
                    tmrGame.Enabled = false;
                    tmrEnemySpeed.Enabled = false;
                    tmrFireRate.Enabled = false;
                    tmrDamageCooldown.Enabled = false;
                    tmrDamageTaken.Enabled = false;
                    tmrEnemyRespawn.Enabled = false;
                    lblPausedGame.Visible = true;
                    lblResumeInfo.Visible = true;
                    lblPauseQuitInfo.Visible = true;
                    lblPausedGame.BringToFront();
                    lblResumeInfo.BringToFront();
                    lblPauseQuitInfo.BringToFront();
                }
                else if (e.KeyCode == Keys.Tab && tmrGame.Enabled == false)
                {
                    tmrGame.Enabled = true;
                    tmrGame.Enabled = true;
                    tmrEnemySpeed.Enabled = true;
                    tmrFireRate.Enabled = true;
                    tmrDamageCooldown.Enabled = true;
                    tmrDamageTaken.Enabled = true;
                    tmrEnemyRespawn.Enabled = true;
                    lblPausedGame.Visible = false;
                    lblResumeInfo.Visible = false;
                    lblPauseQuitInfo.Visible = false;

                }
                if (e.KeyCode == Keys.Escape)
                {
                    tmrGame.Enabled = false;
                    if (MessageBox.Show("Are you sure you want to exit the game?", "QUIT GAME?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        tmrGame.Enabled = true;
                    }


                }

                if (lblGameOver.Visible == true)
                {
                    if (e.KeyCode == Keys.P)
                    {
                        picSpy.Location = new Point(366, 392);
                        Score = 0;
                        lblGameOver.Visible = false;
                        tmrGame.Enabled = true;
                        tmrEnemySpeed.Enabled = true;
                        tmrFireRate.Enabled = true;
                        tmrDamageCooldown.Enabled = true;
                        tmrDamageTaken.Enabled = true;
                        tmrEnemyRespawn.Enabled = true;
                        Health = 3;
                        lblPlayAgain.Visible = false;
                    }
                }
            }
        }

        private void tmrGame_Tick_1(object sender, EventArgs e)
        {
            //move the car

            if (SpyUp && picSpy.Top != this.ClientSize.Height && SpyDown == false)
            {
                picSpy.Top -= 20;
                Score += 3;
                do
                {
                    foreach (TreesLeft oTree in TreesL)
                    {
                        oTree.Top += 35;
                    }
                    foreach (TreesRight oTree in TreesR)
                    {
                        oTree.Top += 35;
                    }
                } while (SpyUp == false);

            }

            if (SpyDown && picSpy.Bottom != picScoreBox.Top && SpyUp == false)
            {
                picSpy.Top += 15;
                Score += 1;

                do
                {
                    foreach (TreesLeft oTree in TreesL)
                    {
                        oTree.Top += 25;
                    }
                    foreach (TreesRight oTree in TreesR)
                    {
                        oTree.Top += 25;
                    }
                } while (SpyDown == false);

            }

            if (SpyLeft && picSpy.Left != picGrass2.Right && picSpy.Left != picGrass2.Left && picSpy.Left != picScoreBox.Top && SpyRight == false)
            {
                picSpy.Left -= 15;
            }



            if (SpyRight && picSpy.Right != picGrass1.Right && picSpy.Right != picScoreBox.Top && SpyLeft == false)
            {
                picSpy.Left += 15;
            }

            if (SpyUp == false && picSpy.Bottom != picScoreBox.Top && GoDown == true)
            {
                picSpy.Top += 15;
                Score += 1;
                foreach (TreesLeft oTree in TreesL)
                {
                    oTree.Top += 25;
                }
                foreach (TreesRight oTree in TreesR)
                {
                    oTree.Top += 25;
                }
            }

            if (
                (SpyUp && SpyDown) == true)
            {
                picSpy.Top += 15;
                Score += 1;
                foreach (TreesLeft oTree in TreesL)
                {
                    oTree.Top += 25;
                }
                foreach (TreesRight oTree in TreesR)
                {
                    oTree.Top += 25;
                }
            }


            // Incase player goes off screen
            if (picSpy.Bottom >= picScoreBox.Top + 15)
            {
                picSpy.Top -= 15;
                GoDown = false;

            }
            else
            {
                GoDown = true;
            }
            if (picSpy.Top <= 0)
            {
                picSpy.Top += 35;
            }
            if (picSpy.Right > ClientSize.Width)
            {
                picSpy.Left -= 15;
            }
            if (picSpy.Left <= 0)
            {
                picSpy.Left += 15;
            }

            // Calculate the score
            lblScore.Text = "Score = " + Score;

            // Create Trees
            int MidScreen = ClientSize.Height / 2;
            for (int i = TreesL.Count - 1; i > -1; i--)
            {
                if (TreesL[i].Top == this.picGrass1.Height / 2)
                {
                    CreateTreeLeft();
                }

                if (TreesL[i].Bottom >= this.picScoreBox.Top)
                {
                    // Remove trees from form and list
                    this.Controls.Remove(TreesL[i]);
                    TreesL.RemoveAt(i);
                    CreateTreeLeft();

                }
            }

            for (int i = TreesR.Count - 1; i > -1; i--)
            {
                if (TreesR[i].Top == this.picGrass2.Height / 2)
                {
                    CreateTreeRight();
                }

                if (TreesR[i].Bottom >= this.picScoreBox.Top)
                {
                    // Remove trees from form and list
                    this.Controls.Remove(TreesR[i]);
                    TreesR.RemoveAt(i);
                    CreateTreeRight();

                }
            }

            // Create Bullets
            for (int i = Bullets.Count - 1; i > -1; i--)
            {
                //move bullet
                Bullets[i].Top -= 75;

                if (Bullets[i].Left >= this.ClientSize.Width)
                {
                    //remove bullet from form and list
                    this.Controls.Remove(Bullets[i]);
                    Bullets.RemoveAt(i);
                }
                else
                {
                    for (int j = Enemies.Count - 1; j > -1; j--)
                    {
                        if (Enemies[j].Bounds.IntersectsWith(Bullets[i].Bounds))
                        {
                            //collision is detected
                            this.Controls.Remove(Bullets[i]);
                            Bullets.Remove(Bullets[i]);
                            EnemyHealth--;

                            if (EnemyHealth <= 0)
                            {
                                this.Controls.Remove(Enemies[j]);
                                Enemies.Remove(Enemies[j]);
                            }
                            break;
                        }
                    }
                }
            }
            for (int i = Bullets2.Count - 1; i > -1; i--)
            {
                //move bullet
                Bullets2[i].Top -= 75;

                if (Bullets2[i].Left >= ClientSize.Width)
                {
                    //remove bullet from form and list
                    this.Controls.Remove(Bullets2[i]);
                    Bullets2.RemoveAt(i);
                }
                else
                {
                    for (int j = Enemies.Count - 1; j > -1; j--)
                    {
                        if (Enemies[j].Bounds.IntersectsWith(Bullets2[i].Bounds))
                        {
                            //collision is detected
                            this.Controls.Remove(Bullets2[i]);
                            Bullets.Remove(Bullets2[i]);
                            EnemyHealth--;

                            if (EnemyHealth <= 0)
                            {
                                this.Controls.Remove(Enemies[j]);
                                Enemies.Remove(Enemies[j]);
                                
                            }

                            break;
                        }
                    }
                }
            }

            // Detect damage taken
            if (picSpy.Bounds.IntersectsWith(picGrass1.Bounds) || picSpy.Bounds.IntersectsWith(picGrass2.Bounds) || DamageTaken == true)
            {
                if (Health >= 1 && tmrDamageCooldown.Enabled == false)
                {
                    Health--;
                    tmrDamageTaken.Enabled = true;
                    tmrDamageCooldown.Enabled = true;
                }
            }
            
            if (Health == 0)
            {
                tmrGame.Stop();
                tmrEnemySpeed.Stop();
                tmrFireRate.Stop();
                
                lblGameOver.Visible = true;
                lblGameOver.BringToFront();
                lblPlayAgain.Visible = true;
                lblPlayAgain.BringToFront();
            }
            
            if (tmrDamageTaken.Enabled == true)
            {
                picSpy.BackColor = Color.White;
            }
            if (tmrDamageTaken.Enabled == false)
            {
                picSpy.BackColor = Color.Transparent;
            }

            lblHealthBar.Visible = true;
            lblHealthBar.Text = "Health = " + Health;
            lblHealthBar.BringToFront();
        }

        private void tmrDamageTaken_Tick(object sender, EventArgs e)
        {
            tmrDamageTaken.Enabled = false;
        }

        private void tmrDamageCooldown_Tick(object sender, EventArgs e)
        {

            tmrDamageCooldown.Enabled = false;

        }

        private void tmrEnemySpeed_Tick(object sender, EventArgs e)
        {
            
            // Have cars start from the top, go down till certain range
            
            foreach (Cars oCar in Enemies)
            {
                if (oCar.Top <= 100)
                {
                    oCar.Top += 15;
                }
                { 

                    if (GoLeft == true && GoRight == false)
                    {
                        oCar.Left -= 5;

                        // Detect if car hits right wall
                        if (oCar.Bounds.IntersectsWith(picGrass2.Bounds))
                            {
                            GoLeft = false;
                            GoRight = true;
                   
                        }

                    }

                    else if (GoRight == true && GoLeft == false)
                    {
                        oCar.Left += 5;

                        // Detect if car hits right wall
                        if (oCar.Bounds.IntersectsWith(picGrass1.Bounds))
                        {
                            GoLeft = true;
                            GoRight = false;
                         
                        }

                    } 
                }
            }

            for (int i = EnemyBullets.Count - 1; i > -1; i--)
            {
                EnemyBullets[i].Top += 40;

                if (EnemyBullets[i].Left >= ClientSize.Width)
                {
                    //remove bullet from form and list
                    this.Controls.Remove(EnemyBullets[i]);
                    EnemyBullets.RemoveAt(i);
                }
                else
                {
                    for (int j = Enemies.Count - 1; j > -1; j--)
                    {
                        if (picSpy.Bounds.IntersectsWith(EnemyBullets[i].Bounds))
                        {
                            //collision is detected
                            this.Controls.Remove(EnemyBullets[i]);
                            Bullets.Remove(EnemyBullets[i]);
                            DamageTaken = true;

                            break;
                        }
                    }
                }


            }

        }
        private void tmrFireRate_Tick(object sender, EventArgs e)
        {
            if (Enemies.Count == 1)
            {
                CreateMissile();
            }
        }
        private void tmrEnemyRespawn_Tick(object sender, EventArgs e)
        {
            if (Enemies.Count == 0)
            {
                CreateEnemy();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Started == false)
            {
                // Open Instructions
                if (e.KeyCode == Keys.C)
                {
                    picInfo.Visible = true;
                    lblControlTitle.Visible = true;
                    picControls.Visible = true;
                    picHowToPlay.Visible = false;
                    picYourMission.Visible = false;
                    picInfo.Visible = true;
                    picControls.SizeMode = PictureBoxSizeMode.StretchImage;
                    
                    
                }
                if (e.KeyCode == Keys.H)
                {
                    picInfo.Visible = false;
                    lblControlTitle.Visible = false;
                    picControls.Visible = false;
                    picHowToPlay.Visible = true;
                    picYourMission.Visible = false;
                    picInfo.Visible = true;
                    picHowToPlay.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                if (e.KeyCode == Keys.M)
                {
                    picYourMission.Visible = true;
                    picHowToPlay.Visible = false;
                    picControls.Visible = false;
                    lblControlTitle.Visible = false;
                    picHowToPlay.Visible = false;
                    picInfo.Visible = true;
                    picYourMission.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                if (e.KeyCode == Keys.Return)
                {
                    // Close Menu

                    picBlack.Visible = false;
                    picGuy.Visible = false;
                    picLogo.Visible = false;
                    picInfo.Visible = false;
                    lblEnter.Visible = false;
                    picControls.Visible = false;
                    lblControls.Visible = false;
                    lblControlTitle.Visible = false;
                    lblYourMissionTitle.Visible = false;
                    lblHowToPlayTitle.Visible = false;
                    picHowToPlay.Visible = false;
                    picYourMission.Visible = false;




                    InitializeGame();

                    picSpy.Left = ClientSize.Width / 2 - picSpy.Width / 2;
                    picSpy.Top = ClientSize.Height / 2 - picSpy.Height / 2;
                    picSpy.Visible = true;
                    picSpy.SizeMode = PictureBoxSizeMode.StretchImage;
                    lblScore.Visible = true;
 
                    CreateEnemy();
                    CreateTreeLeft();
                    CreateTreeRight();

                    picScoreBox.Visible = true;
                    tmrGame.Enabled = true;
                    Started = true;
                }
            }
                else
                {
                    // Add shooting capabilities
                    if (e.KeyCode == Keys.Space && ReloadBullet == false)
                    {
                        CreateBullet();
                        ReloadBullet = true;
                    }

                    // Game has  started
                    if (e.KeyCode == Keys.Up)
                    {
                        SpyUp = true;

                       
                    }
                    if (e.KeyCode == Keys.Left)
                    {
                        SpyLeft = true;

                    }
                    if (e.KeyCode == Keys.Right)
                    {
                        SpyRight = true;
                    }
                    if (e.KeyCode == Keys.Down)
                    {
                        SpyDown = true;
                    }
            }
        }




        public void CreateBullet()
        {
            PictureBox Bullet = new PictureBox();
            // Code for one gun
            Bullet.BackColor = Color.Gold;
            Bullet.Width = 2;
            Bullet.Height = 10;
            Bullet.Top = picSpy.Top;
            Bullet.Left = picSpy.Left + (picSpy.Width / 2 - Bullet.Width / 2) + 7;
            Bullet.Visible = true;
            Bullet.BringToFront();
            this.Controls.Add(Bullet);
            Bullets.Add(Bullet);

            // Code for another gun
            PictureBox Bullet2 = new PictureBox();
            Bullet2.BackColor = Color.Gold;
            Bullet2.Width = 2;
            Bullet2.Height = 10;
            Bullet2.Top = picSpy.Top;
            Bullet2.Left = picSpy.Left + (picSpy.Width / 2 - Bullet2.Width / 2) - 7;
            Bullet2.Visible = true;
            Bullet2.BringToFront();
            this.Controls.Add(Bullet2);
            Bullets.Add(Bullet2);
        }

        public void CreateMissile()
        {
            PictureBox EnemyBullet = new PictureBox();
            EnemyBullet.BackColor = Color.Red;
            EnemyBullet.Width = 10;
            EnemyBullet.Height = 20;

            foreach (Cars oCar in Enemies)
            { 
              EnemyBullet.Top = oCar.Bottom;
              EnemyBullet.Left = oCar.Left + (oCar.Width / 2 - EnemyBullet.Width / 2);
            }
            
            EnemyBullet.Visible = true;
            EnemyBullet.BringToFront();
            this.Controls.Add(EnemyBullet);
            EnemyBullets.Add(EnemyBullet);
        }

        public void CreateTreeLeft()
        {
            if (TreesL.Count <= 1)
            {
                int Speed = oRandom.Next(50, 60);
                int Size = 60;
                int X = oRandom.Next(this.picGrass1.Width - Size);
                int Y = 0;

                TreesLeft oTree = new TreesLeft(X, Y, Speed, Size);
                this.Controls.Add(oTree);
                TreesL.Add(oTree);
                oTree.BringToFront();
                oTree.BackColor = Color.LimeGreen;
            }
        }

        

        public void CreateTreeRight()
        {
            if (TreesR.Count <= 1)
            {
                int Speed = oRandom.Next(50, 60);
                int Size = 60;
                int X = oRandom.Next(this.picGrass2.Width - Size) + 454;
                int Y = 0;

                TreesRight oTree = new TreesRight(X, Y, Speed, Size);
                this.Controls.Add(oTree);
                TreesR.Add(oTree);
                oTree.BringToFront();
                oTree.BackColor = Color.LimeGreen;
            }
        }

        public void CreateEnemy()
        {
            // Determine size of enemy
            int Size = picSpy.Width;

            // Find positions
            int Y = (oRandom.Next(10, this.ClientSize.Height - 600)) - 300;
            int X = (ClientSize.Width / 2 - Size);
                //oRandom.Next(10, this.ClientSize.Width + 132 - 132);

            // Useless code
            double Angle = 0;

            //create the car in memory
            Cars oCar = new Cars(X, Y, Angle, Size);

            
            oCar.Width = picSpy.Width;
            oCar.Height = picSpy.Height;

            //add to form
            this.Controls.Add(oCar);
            oCar.BringToFront();
            //add to list
            Enemies.Add(oCar);

        }

        public void InitializeGame()
        {
            SpyLeft = false;
            //reset all variables

            //resets all lists
            Bullets = new List<PictureBox>();
            Enemies = new List<Cars>();
            TreesL = new List<TreesLeft>();
            TreesR = new List<TreesRight>();



            picSpy.Left = ClientSize.Width / 2 - picSpy.Width / 2;
            picSpy.Top = ClientSize.Height / 2 - picSpy.Height / 2;
            picSpy.Visible = true;

            // Create enemies
            
            for (int i = 0; i < 0; i++)
            {
               if (Enemies.Count == 0)
               {
                    CreateEnemy();
               }
                
            }

            // Create trees
            for (int i = 0; i == 1; i++)
            {
                CreateTreeLeft();
                CreateTreeRight();
            }

            GoLeft = true;
            tmrEnemyRespawn.Enabled = true;
            tmrFireRate.Enabled = true;
            tmrGame.Enabled = true;
            tmrEnemySpeed.Enabled = true; 
            Started = true;

        }
    }
    
}
