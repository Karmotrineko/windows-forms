using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula0805
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            if (txbNome.Text == "" || txbSobrenome.Text== "")
            {
                MessageBox.Show("Um dos campos está vazio!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string NomeCompleto = txbNome.Text + " " + txbSobrenome.Text;
            if (!NomeCompleto.Equals(" "))
            {
                cbxNomesAdicionados.Items.Add(txbNome.Text + " " + txbSobrenome.Text);
                txbNomeCompleto.Text = txbNome.Text + " " + txbSobrenome.Text;
            }
            txbNome.Text = null;
            txbSobrenome.Text = null;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbSobrenome.Clear();
            txbNomeCompleto.Clear();
        }

        private void cbxNomesAdicionados_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblVazio.Text = cbxNomesAdicionados.Text;



        }
    }
}
