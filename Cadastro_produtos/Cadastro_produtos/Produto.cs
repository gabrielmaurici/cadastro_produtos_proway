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
        public Categorias Categoria { get; set; }

        public Produto(int Id, string Nome, decimal Valor, Categorias Categoria)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Valor = Valor;
            this.Categoria = Categoria;
        }

        public Produto()
        {

        }

        public static void CadastrarProduto(List<Categorias> categorias, List<Produto> produtos)
        {

            Console.Write("Digite um Produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o Valor do produto: ");
            Console.Clear();

            decimal valor = 0;

            try
            {
                valor = Convert.ToDecimal(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Valor impossivel!, aperte qualquer tecla para continuar");
                Console.ReadKey();
                return;
            }

            Categorias novaCategoria = new Categorias();

            bool deubom = false;
            do
            {
                if (categorias.Count > 0)
                {
                    Console.WriteLine("Categorias disponíveis:");
                    foreach (Categorias categoria2 in categorias)
                    {
                        Console.WriteLine($"\n{categoria2.Nome}");
                    }
                    Console.WriteLine("\nDigite a categoria: ");
                    string categoria = Console.ReadLine();
                    foreach (Categorias categoria1 in categorias)
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
                            if (resposta == "s")
                            {
                                Categorias.CadastrarCategorias(categorias);
                            } else
                            {
                                break;
                            }
                            return;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nenhuma categoria cadastrada, deseja criar uma nova? (s/n)");
                    string resposta = Console.ReadLine();
                    if (resposta == "s")
                    {
                        Categorias.CadastrarCategorias(categorias);
                    }
                }
            } while (!deubom);

            int id = produtos.Count + 1;
            Produto produto = new Produto(id, nome, valor, novaCategoria);

            produtos.Add(produto);

        }
    }
}
