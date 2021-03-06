using Cadastro_produtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_produtos
{
    class Menu 
    {
        public static List<Produto> produtos = new List<Produto>();
        public static List<Categoria> categorias = new List<Categoria>();

        int countProduto = 1;

        int countCategorias = 1;
        public void menuOpcaos()
        {

            
            while (true)
            {
                Console.Clear();

                Console.WriteLine("1 - Cadastro de Produtos \n2 - Cadastro de Cateogiras \n3 - Mostrar Dados \n4 - SAIR!!!");

                int opcao = Convert.ToInt16(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Produto.CadastrarProduto(produtos);
                        break;
                    case 2:
                        Console.Clear();
                        Categoria.CadastrarCategorias(categorias);
                        break;
                    case 3:
                        Console.Clear();
                        mostrarDados();
                        break;
                    case 4:
                        return;
                }
            }
        }
        private void mostrarDados()
        {
            Console.Clear();
            Console.WriteLine("*********** MOSTRAR DADOS **************** ");
            Console.WriteLine("\nProdutos\n");

            foreach (Produto prod in produtos)
            {
                Console.WriteLine($"Id: {prod.Id} -- Nome Produto: {prod.Nome} -- Valor Produto: {prod.Valor} -- Categoria: {prod.Categoria.Nome}");
            }

            Console.WriteLine("\nCategorias\n");

            foreach (Categoria categoria in categorias)
            {
                Console.WriteLine($"Id: {categoria.Id} -- Nome Categoria {categoria.Nome} -- Descrição Categoria: {categoria.Descricao}");
            }
            Console.ReadKey();
        }

        //public void Cadastro(BaseModels model)
        //{
        //    if (model.GetType() == typeof(Produto))
        //    {
        //        Console.Write("Digite um Produto: ");
        //        string nome = Console.ReadLine();

        //        Console.Write("Digite o Valor do produto: ");


        //        decimal valor = 0;

        //        try
        //        {
        //            valor = Convert.ToDecimal(Console.ReadLine());
        //        }
        //        catch
        //        {
        //            Console.WriteLine("Valor impossivel!, aperte qualquer tecla para continuar");
        //            Console.ReadKey();
        //            return;
        //        }


        //        Produto produto = new Produto(countProduto, nome, valor);
        //        countProduto++;

        //        produtos.Add(produto);
        //    }
        //    else if (model.GetType() == typeof(Categorias))
        //    {
        //        Console.Write("\nDigite uma categoria: ");
        //        string nome = Console.ReadLine();

        //        Console.Write("Digite a descrição da categoria: ");
        //        string descricao = Console.ReadLine();

        //        Categorias categoria = new Categorias(countCategorias, nome, descricao);
        //        countCategorias++;

        //        categorias.Add(categoria);
        //    }
        //}

    }
}