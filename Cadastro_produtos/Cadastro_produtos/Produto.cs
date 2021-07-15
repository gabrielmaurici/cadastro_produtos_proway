using Cadastro_produtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_produtos
{
    public class Produto : BaseModels
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public Categoria Categoria { get; set; }

        public Produto(int Id, string Nome, decimal Valor, Categoria Categoria)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Valor = Valor;
            this.Categoria = Categoria;
        }

        public Produto()
        {

        }

        public static void CadastrarProduto(List<Categoria> categorias, List<Produto> produtos)
        {

            Console.Write("Digite um Produto: ");
            string nome = Validacao.ValidaString();

            Console.Write("Digite o Valor do produto: ");

            decimal valor = 0;

            valor = Validacao.ValidaDecimal();
            Console.Clear();
            Categoria novaCategoria = new Categoria();

            bool deubom = false;
            do
            {
                if (categorias.Count > 0)
                {
                    Console.WriteLine("Categorias disponíveis:");
                    foreach (Categoria categoria2 in categorias)
                    {
                        Console.WriteLine($"\n{categoria2.Nome}");
                    }
                    Console.WriteLine("\n--------------" +
                        $"\nDigite a categoria para o {nome}: ");
                    string categoria = Console.ReadLine();
                    foreach (Categoria categoria1 in categorias)
                    {
                        if (categoria1.Nome == categoria)
                        {
                            novaCategoria = categoria1;
                            deubom = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Categoria inválida");
                            Console.WriteLine("\nDeseja cadastras uma nova categoria? (s/n)");
                            string resposta = Console.ReadLine();
                            Console.Clear();
                            if (resposta == "s")
                            {
                                Categoria.CadastrarCategorias(categorias);
                            }
                            break;
                        }
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Nenhuma categoria cadastrada, aperte qualquer tecla para criar uma nova categoria");
                    Console.ReadLine();
                    Console.Clear();
                    Categoria.CadastrarCategorias(categorias);
                }
            } while (!deubom);

            int id = produtos.Count + 1;
            Produto produto = new Produto(id, nome, valor, novaCategoria);

            produtos.Add(produto);

        }
    }
}
