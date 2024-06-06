using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DdayDbAndForms
{
    public class Contato
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Contato(int id, string nome, string telefone)
        {
            this.id = id;
            this.Nome = nome;
            this.Telefone = telefone;
        }
    }
}
