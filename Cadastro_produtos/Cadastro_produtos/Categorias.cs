using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_produtos
{
    struct Categorias
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public Categorias(int id, string nome, string descricao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
        }
    }
}
