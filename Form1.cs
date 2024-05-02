using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula0205
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = int.Parse(lblCounter.Text);
            count++;

            lblCounter.Text = count.ToString();
        }

        private void btnNegativo_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = int.Parse(lblCounter.Text);
            count--;

            lblCounter.Text = count.ToString();
        }

        private void btnCorPreto_Click(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }

        private void btnCorLaranja_Click(object sender, EventArgs e)
        {
            BackColor = Color.Orange;
        }

        private void btnCorRosa_Click(object sender, EventArgs e)
        {
            BackColor = Color.LightPink;
        }

    }
}
