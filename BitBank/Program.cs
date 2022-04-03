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


            ContaCorrente[] contas = new ContaCorrente[2];
            contas[0] = new ContaCorrente();
            contas[1] = new ContaCorrente();

            Console.WriteLine("Titular: ");
            contas[0].titular = Console.ReadLine();
            Console.WriteLine("Agência: ");
            contas[0].agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Número da Conta: ");
            contas[0].numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Titular: " + contas[0].titular);
            Console.WriteLine("Agência: " + contas[0].agencia);
            Console.WriteLine("Número da Conta: " + contas[0].numero);
            Console.WriteLine("Saldo: " + contas[0].saldo);

            Console.WriteLine("Insira algum valor para saque, zero (0) caso não queira: ");
            bool resultadosaque = contas[0].Sacar(double.Parse(Console.ReadLine()));
            Console.WriteLine("Sacando.. ");
            Console.WriteLine(resultadosaque);

            Console.WriteLine("Insira algum valor para deposito, zero (0) caso não queira: ");
            contas[0].Deposito(double.Parse(Console.ReadLine()));

            Console.WriteLine("Insira algum valor para transferir, zero (0) caso não queira: ");
            bool transferencia = contas[0].Transferir(double.Parse(Console.ReadLine()), contas[1]);
            Console.WriteLine(transferencia);

            Console.WriteLine("Saldo Atual Contas: ");
            Console.WriteLine("Conta: " + contas[0].saldo + " Conta: " + contas[1].saldo);

            Console.WriteLine("Obrigado BitBank agradece. Volte Sempre!");


        }
    }
}
