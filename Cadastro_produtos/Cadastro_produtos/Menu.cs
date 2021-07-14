using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_produtos
{
    class Menu
    {
        List<Produto> produtos = new List<Produto>();
        List<Categorias> categorias = new List<Categorias>();

        int countProduto = 1;

        int countCategorias = 1;
        public void menuOpcaos()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("1 - Cadastro de Produtos \n2 - Cadastro de Cateogiras \n3 - SAIR!!!");

                int opcao = Convert.ToInt16(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarProduto();
                        break;
                    case 2:
                        CadastrarCategorias();
                        break;
                    case 3:
                        return;
                }
            }
        }
        private void CadastrarProduto()
        {
            Console.Write("Digite um Produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o Valor do produto: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            Produto produto = new Produto(countProduto, nome, valor);
            countProduto++;

            produtos.Add(produto);

        }

        private void CadastrarCategorias()
        {
            Console.Write("\nDigite uma categoria: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a descrição da categoria: ");
            string descricao = Console.ReadLine();

            Categorias categoria = new Categorias(countCategorias, nome, descricao);
            countCategorias++;

            categorias.Add(categoria);
        }

    }
}
