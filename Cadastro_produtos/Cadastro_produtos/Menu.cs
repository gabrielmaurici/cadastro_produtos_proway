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
        public void CadastrarProduto()
        {
            Console.Write("Digite um Produto: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o Valor do produto: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            Produto produto = new Produto(countProduto, nome, valor);
            countProduto++;

            produtos.Add(produto);
        }

    }
}
