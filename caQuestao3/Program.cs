using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestao3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Nome do Aluno: Luis Guilherme Silva Matos


            Carro[] carros = new Carro[100];
            Cliente[] clientes = new Cliente[100];
            int qnt_carros = 0;
            int qnt_clientes = 0;

            int aux = 1;
            while (aux != 0)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opção do menu :\n");
                Console.WriteLine(" [1] - Cadastrar um carro");
                Console.WriteLine(" [2] - Cadastrar uma cliente");
                Console.WriteLine(" [3] - cadastrar um empréstimo");
                Console.WriteLine(" [4] - relatório de empréstimos");
                Console.WriteLine(" [5] - Sair");

                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Carro carro_temp = new Carro();

                        Console.WriteLine("Digite a categoria do carro");
                        carro_temp.Categoria = Console.ReadLine();

                        Console.WriteLine("Digite a marca da empresa do carro");
                        carro_temp.Marca_da_empresa = Console.ReadLine();

                        Console.WriteLine("Digite o modelo do carro");
                        carro_temp.Modelo = Console.ReadLine();

                        Console.WriteLine("Digite o ano de fabricação do carro");
                        carro_temp.Ano_de_fabricação = Convert.ToInt32( Console.ReadLine());

                        carros[qnt_carros] = carro_temp;
                        qnt_carros++;

                        Console.ReadLine();
                        break;

                    case "2":
                        /* Comandos */


                        Console.ReadLine();
                        break;
                    case "3":
                        /* Comandos */
                        Console.ReadLine();
                        break;

                    case "4":
                        /* Comandos */

                        Console.ReadLine();
                        break;

                    case "5":
                        /* Comandos */
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Favor selecionar uma das opções mostradas no menu");
                        Console.ReadLine();
                        break;
                } // fim do switch

            }  // fim do while

        }
    }
}
