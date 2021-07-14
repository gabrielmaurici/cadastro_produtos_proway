using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_produtos
{
    class Categoria
    {

        int id = 0;
        
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public Categoria(int id, string nome, string descricao)
        {
            this.id = id;
            this.Nome = nome;
            this.Descricao = descricao;
        }

    }
}
