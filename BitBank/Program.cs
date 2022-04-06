using System;

namespace BitBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ContaCorrente[] contas = new ContaCorrente[2];
            Cliente[] cliente = new Cliente[1];


            cliente[0] = new Cliente();
            contas[0] = new ContaCorrente();
            contas[1] = new ContaCorrente();
            contas[0].Saldo = 10;


            Console.WriteLine("Nome cliente: ");
            cliente[0].nome = Console.ReadLine();
            Console.WriteLine("Cpf cliente: ");
            cliente[0].cpf = Console.ReadLine();
            Console.WriteLine("Saldo: " + contas[0].Saldo);

            Console.WriteLine("Titular: ");
            Console.WriteLine(cliente[0].nome);
            Console.WriteLine("Agência: ");
            contas[0].agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Número da Conta: ");
            contas[0].numero = int.Parse(Console.ReadLine());



            Console.WriteLine("Titular: " + cliente[0].nome);
            Console.WriteLine("Agência: " + contas[0].agencia);
            Console.WriteLine("Número da Conta: " + contas[0].numero);
            Console.WriteLine("Saldo: " + contas[0].Saldo);


            Console.WriteLine("Insira algum valor para saque, zero (0) caso não queira: ");
            bool resultadosaque = contas[0].Sacar(double.Parse(Console.ReadLine()));
            Console.WriteLine("Sacando...");


            Console.WriteLine("Insira algum valor para deposito, zero (0) caso não queira: ");
            contas[0].Deposito(double.Parse(Console.ReadLine()));


            Console.WriteLine("Insira algum valor para transferir, zero (0) caso não queira: ");
            bool transferencia = contas[0].Transferir(double.Parse(Console.ReadLine()), contas[1]);
            Console.WriteLine("Transferido para: " + contas[1]);


            Console.WriteLine("Saldo Atual Contas: ");
            Console.WriteLine("Conta: " + contas[0].Saldo + " Conta: " + contas[1].Saldo);


            Console.WriteLine("Obrigado BitBank agradece. Volte Sempre!");

        }
    }
}
