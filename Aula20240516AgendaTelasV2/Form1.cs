using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula20240515Agenda
{
    public partial class FormHome : Form
    {
        public List<Contato> listaContatos;
        public Contato selecionado;
        public FormHome()
        {
            InitializeComponent();            
            listaContatos = new List<Contato>();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            listaContatos.Remove(selecionado);
            dgvContatos.DataSource = null;
            dgvContatos.DataSource = listaContatos;
            dgvContatos.Refresh();

        }

        private void dgvContatos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int x = e.RowIndex;
            selecionado = listaContatos[e.RowIndex];
        }

    }
}
