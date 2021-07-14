using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_produtos
{
    class Produto
    {
        int id = 0
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public Produto(int id, string Nome, decimal Valor)
        {
            this.id = id;
            this.Nome = Nome;
            this.Valor = Valor;
        }
    }
}
