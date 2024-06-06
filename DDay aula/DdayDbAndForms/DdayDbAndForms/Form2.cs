using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DdayDbAndForms
{
    public partial class Form2 : Form
    {
        Form1 origem;
        public Form2(Form1 origem)
        {
            InitializeComponent();
            this.origem = origem;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // nada
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // nada
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                origem.connee.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                origem.connee.Close();
            }

            /*
            int ProxID = origem.listacontatos.Count + 1;
            Contato aux = new Contato(ProxID, textBox1.Text, textBox2.Text);
            origem.listacontatos.Add(aux);

            origem.dataGridView1.DataSource = null;
            origem.dataGridView1.DataSource = origem.listacontatos;

            this.Close();
            */
        }
    }
}
