using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_7
{
    public partial class Cero : Form
    {
        public Cero()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form Cero = new UnoA();
            this.Hide();
            Cero.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form Cero = new UnoB();
            this.Hide();
            Cero.Show();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Form Cero = new UnoA();
            this.Hide();
            Cero.Show();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Size = new Size (1380, 750);
        }

        private void Cero_Load(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            Form Cero = new UnoA();
            this.Hide();
            Cero.Show();
        }
        //private void PictureBox1_Enter_1(object sender, EventArgs e)
        //{
        //    pictureBox5.Visible = true;
        //}



        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Form Cero = new UnoB();
            this.Hide();
            Cero.Show();
        }
    }
}
