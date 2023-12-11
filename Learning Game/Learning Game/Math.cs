using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Learning_Game
{
    public partial class frm_math : Form
    {

        bool moveleft, moveright, jump, DiamondNotHeld, DiamondHeld;
        bool diamondMissingMessageShown = false;

        int jumpspeed = 5;
        int force = 8;
        int score = 0;

        int playerspeed = 5;
        int bgspd = 6;

        public frm_math()
        {
            InitializeComponent();
            player.Location = new Point(20, 643);
        }

        private void MainGame_Time(object sender, EventArgs e)
        {
            lbl_score.Text = "Score:" + score;
            player.Top += jumpspeed;

            if (moveleft == true && player.Left > 50)
            {
                player.Left -= playerspeed;
            }
            if (moveright == true && player.Left + (player.Width + 60) < this.ClientSize.Width)
            {
                player.Left += playerspeed;
            }

            if (moveleft == true & background.Left < 0)
            {
                background.Left += bgspd;

                MoveGameBG("forward");

            }
            if (moveright == true && background.Left > -1209)
            {

                background.Left -= bgspd;

                MoveGameBG("back");
            }
            if (jump == true)
            {
                jumpspeed = -17;
                force -= 1;
            }
            else
            {
                jumpspeed = 10;
            }
            if (jump == true && force < 0)
            {
                jump = false;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && jump == false)
                    {
                        force = 3;
                        player.Top = x.Top - player.Height;
                        jumpspeed = 1;

                    }
                    x.BringToFront();
                }
                if (x is PictureBox && (string)x.Tag == "coin1")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {

                        x.Visible = false;
                        score += 1;

                    }
                }
                if (x is PictureBox && (string)x.Tag == "coin2")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {

                        x.Visible = false;
                        score += 2;

                    }
                }
                if (x is PictureBox && (string)x.Tag == "diamond")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        DiamondHeld = true;
                    }
                }
                if (player.Top + player.Height > this.ClientSize.Height)
                {
                    GameTime.Stop();
                    MessageBox.Show("You fell down" + Environment.NewLine + "Click OK to restart");
                    RstrtGame();
                }

                if (player.Bounds.IntersectsWith(door.Bounds) && DiamondNotHeld == true && !diamondMissingMessageShown)
                {
                    MessageBox.Show("Missing Diamond can't leave");
                    diamondMissingMessageShown = true;
                }

                if (player.Bounds.IntersectsWith(door.Bounds))
                {
                    if (score < 36 || score > 36)
                    {
                        player.Location = new Point(20, 643);
                        MessageBox.Show("Sorry Wrong Answer");
                        break;
                    }
                    else
                    {
                        player.Location = new Point(20, 643);
                        MessageBox.Show("YEY YOU GOT MATH RIGHT!!");
                        GameTime.Stop();
                    }
                }



            }
        }

        private void KeyNotTouched(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {

                moveleft = false;

            }

            if (e.KeyCode == Keys.Right)
            {

                moveright = false;

            }

            if (jump == true)
            {

                jump = false;

            }
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void KeyIsTouched(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {

                moveleft = true;

            }

            if (e.KeyCode == Keys.Right)
            {

                moveright = true;

            }

            if (e.KeyCode == Keys.Space && !jump)
            {
                jump = true;
            }

            if (e.KeyCode == Keys.R)
            {
                RstrtGame();
            }

            if (e.KeyCode == Keys.E)
            {
                Form Select = new frm_select();
                Select.FormClosed += (s, args) => this.Show();
                Select.Show();
                this.Hide();
                this.Focus();
            }

        }
        private void GameClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void RstrtGame()
        {
            score = 0;
            moveleft = false;
            moveright = false;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && ((string)x.Tag == "coin1" || (string)x.Tag == "coin2" || (string)x.Tag == "diamond"))
                {
                    x.Visible = true;
                }
            }
            player.Location = new Point(20, 643);
            GameTime.Start();
        }

        private void MoveGameBG(string direction)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "ground"
                    || x is PictureBox && (string)x.Tag == "coin1" || x is PictureBox && (string)x.Tag == "coin2"
                    || x is PictureBox && (string)x.Tag == "wall" || x is PictureBox && (string)x.Tag == "door"
                    || x is PictureBox && (string)x.Tag == "diamond" || x is Label && (string)x.Tag == "lbl_guide")
                {
                    if (direction == "back")
                    {
                        x.Left -= bgspd;
                    }
                    if (direction == "forward")
                    {
                        x.Left += bgspd;
                    }
                }             
                if (x is PictureBox && (string)x.Tag == "wall")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            if (moveleft)
                            {
                                moveleft = false;
                                player.Left = x.Right;
                            }
                            if (moveright)
                            {
                                moveright = false;
                                player.Left = x.Left - player.Width;
                            }
                        }
                }

            }
        }
    }
}