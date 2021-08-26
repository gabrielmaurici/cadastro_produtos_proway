using Cadastro_produtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_produtos
{
    public class Categoria : BaseModels
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public Categoria(int id, string nome, string descricao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
        }

        public Categoria()
        {
        }

        public static void CadastrarCategorias(List<Categoria> categorias)
        {
            Console.Write("Digite um nome para a categoria: ");
            string nome = Validacao.ValidaString();
            Console.Write("Digite a descrição da categoria: ");
            string descricao = Validacao.ValidaString(); 
            Console.Clear();
            int id = categorias.Count + 1;
            Categoria categoria = new Categoria(id, nome, descricao);
            Console.WriteLine("Categoria cadastrada com sucesso!");
            Menu.categorias.Add(categoria);
        }

        public static void ValidaCategoria()
        {

        }
    }
}
