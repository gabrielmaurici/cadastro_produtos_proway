using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_produtos
{
    struct Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public Produto(int Id, string Nome, decimal Valor)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Valor = Valor;
        }
    }
}
