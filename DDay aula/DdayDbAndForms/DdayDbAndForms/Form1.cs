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
    public partial class Form1 : Form
    {
        public SqlConnection connee;
        public List<Contato> listacontatos;
        
        public Form1()
        {
            InitializeComponent();
            listacontatos = new List<Contato>();

            connee = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aulaDDay;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            try
            {
                connee.Open();
                var selectCmd = connee.CreateCommand();
                selectCmd.CommandText = "SELECT * FROM Contato";
                

                SqlDataReader leitorDados = selectCmd.ExecuteReader();

                while (leitorDados.Read())
                {
                    listacontatos.Add(new Contato((int)leitorDados["id"], leitorDados["Nome"].ToString(), leitorDados["Telefone"].ToString()));
                }
                if (listacontatos != null)
                dataGridView1.DataSource = listacontatos;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connee.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // nada
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }
    }
}
