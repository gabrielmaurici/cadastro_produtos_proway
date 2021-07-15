using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_produtos
{
    public class Validacao
    {
        public static string ValidaString()
        {
            string variavel = String.Empty;
            while (true)
            {
                variavel = Console.ReadLine();
                if (variavel.Trim().Equals(""))
                {
                    Console.WriteLine("Digite um caracter valido");
                }
                else
                {
                    break;
                }
            }
            return variavel;
        }

        public static decimal ValidaDecimal()
        {
            decimal variavel = 0;

            while (variavel == 0)
            {
                try
                {
                    variavel = Convert.ToDecimal(Console.ReadLine());

                }
                catch (Exception)
                {

                    Console.WriteLine("Digite um caracter valido");

                }
            }
            return variavel;
        }

    }
}
