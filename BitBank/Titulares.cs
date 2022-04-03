using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBank
{
    class Titulares
    {
        public string Titular()

        {

            Console.WriteLine("");

            Console.WriteLine("Digite seu nome: ");

            string nomeTitular = Console.ReadLine();

            Console.WriteLine("Digite o número de sua agência: ");

            double numAgencia = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de sua conta: ");

            double numConta = double.Parse(Console.ReadLine());

            /*Console.WriteLine("");

            double saldo = double.Parse(Console.ReadLine());*/

            return nomeTitular + numAgencia + numConta;
        }// Titular

    }
}
