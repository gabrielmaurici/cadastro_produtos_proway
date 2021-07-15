using Cadastro_produtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_produtos
{
    public class Categorias : BaseModels
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public Categorias(int id, string nome, string descricao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
        }

        public Categorias()
        {
        }

        public static void CadastrarCategorias(List<Categorias> categorias)
        {
            Console.Write("\nDigite uma categoria: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a descrição da categoria: ");
            string descricao = Console.ReadLine();

            int id = categorias.Count + 1;
            Categorias categoria = new Categorias(id, nome, descricao);

            categorias.Add(categoria);
        }
    }
}
