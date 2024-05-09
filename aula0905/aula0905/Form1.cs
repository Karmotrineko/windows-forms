using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula0905
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txbEscrita.Text != "")
            {
                cbxEstados.Items.Add(txbEscrita.Text.ToString().ToUpper());
                txbEscrita.Clear();
            }

        }
        private void btnCopiar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbxEstados.Items.Count; i++)
            {
                lbxEstados.Items.Add(cbxEstados.Items[i].ToString());
            }
        }

        private void btnCopiarSelecionado_Click(object sender, EventArgs e)
        {
            foreach(string s in lbxEstados.SelectedItems)
            {
                lbxSelecionados.Items.Add(s);
            }
        }
    }
}
