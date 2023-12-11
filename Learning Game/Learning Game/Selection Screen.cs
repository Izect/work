using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

namespace Learning_Game
{
    public partial class frm_select : Form
    {
        public frm_select()
        {
            InitializeComponent();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

       

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_puzzle_Click_1(object sender, EventArgs e)
        {
            Form Puzzle = new frm_puzzle();
            Puzzle.Show();
            this.Hide();
        }

        private void btn_math_Click_1(object sender, EventArgs e)
        {
            Form Math = new frm_math();
            Math.Show();
            this.Hide();
        }

        private void btn_color_Click_1(object sender, EventArgs e)
        {
            Form colorForm = new frm_color();
            colorForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
