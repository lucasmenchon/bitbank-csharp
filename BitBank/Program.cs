using System;

namespace BitBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string nomeTitular = Console.ReadLine();
            int numAgencia = int.Parse(Console.ReadLine());
            int numConta = int.Parse( Console.ReadLine());
            int saldo = int.Parse(Console.ReadLine());*/

            /*Titulares Titulares = new Titulares();
            string atitular = Titulares.Titular();
            string btitular = Titulares.Titular();*/

            
            ContaCorrente conta = new ContaCorrente();
            Console.WriteLine("Titular: ");
            conta.titular = Console.ReadLine();
            Console.WriteLine("Agência: ");
            conta.agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Número da Conta: ");
            conta.numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Titular: " +conta.titular);
            Console.WriteLine("Agência: " + conta.agencia);
            Console.WriteLine("Número da Conta: " + conta.numero);
            Console.WriteLine("Saldo: " + conta.saldo);

            Console.WriteLine("Insira valor para saque: ");
            conta.Sacar(double.Parse(Console.ReadLine()));
            Console.WriteLine("Sacando.. ");
            Console.WriteLine("Saldo Atual: ");
            Console.WriteLine(conta.saldo);
            Console.WriteLine("Obrigado. Volte Sempre!");

            Console.ReadKey();
            

        }
    }
}
