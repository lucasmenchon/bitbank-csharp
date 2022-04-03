using System;

namespace BitBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* string nomeTitular = Console.ReadLine();
            int numAgencia = int.Parse(Console.ReadLine());
            int numConta = int.Parse( Console.ReadLine());
            int saldo = int.Parse(Console.ReadLine());*/

            Titulares Titulares = new Titulares();
            string xtitular = Titulares.Titular();
            string ztitular = Titulares.Titular();

            

        }
    }
}
