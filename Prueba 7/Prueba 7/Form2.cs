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
    public partial class UnoA : Form
    {
        public UnoA()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form UnoA = new UnoB();
            this.Hide();
            UnoA.Show();
        }
    }
}
