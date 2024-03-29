﻿using System;

namespace BitBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ContaCorrente[] contas = new ContaCorrente[2];
            Cliente[] cliente = new Cliente[1];

            contas[0] = new ContaCorrente();
            contas[1] = new ContaCorrente();

            cliente[0] = new Cliente();

            contas[0].Saldo = 10;
            contas[0].Titular = cliente[0]; // juncao de classes c/c com cliente
            //contas[0].Saque = bool.Parse(Console.ReadLine());

            Console.WriteLine("Nome cliente: ");
            contas[0].Titular.Nome = Console.ReadLine();
            Console.WriteLine("Cpf cliente: ");
            contas[0].Titular.CPF = Console.ReadLine();

            Console.WriteLine("Titular: ");
            Console.WriteLine(contas[0].Titular.Nome);
            Console.WriteLine("Agência: ");
            contas[0].Agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Número da Conta: ");
            contas[0].Numero = int.Parse(Console.ReadLine());


            Console.WriteLine("Titular: " + contas[0].Titular.Nome);
            Console.WriteLine("Agência: " + contas[0].Agencia);
            Console.WriteLine("Número da Conta: " + contas[0].Numero);
            Console.WriteLine("Saldo: " + contas[0].Saldo);


            Console.WriteLine("Insira algum valor para saque, zero (0) caso não queira: ");
            bool resultadosaque = contas[0].Sacar(double.Parse(Console.ReadLine()));
            Console.WriteLine("Sacando...");


            Console.WriteLine("Insira algum valor para deposito, zero (0) caso não queira: ");
            contas[0].Deposito(double.Parse(Console.ReadLine()));


            Console.WriteLine("Insira algum valor para transferir, zero (0) caso não queira: ");
           // bool transferencia = contas[0].Transferir(double.Parse(Console.ReadLine()), contas[1]);
            bool transferencia = contas[0].Transferir(double.Parse(Console.ReadLine()), contas[1]);
            Console.WriteLine("Transferido para: " + contas[1]);


            Console.WriteLine("Saldo Atual Contas: ");
            Console.WriteLine("Conta: " + contas[0].Saldo + " Conta: " + contas[1].Saldo);


            Console.WriteLine("Obrigado BitBank agradece. Volte Sempre!");

        }
    }
}
