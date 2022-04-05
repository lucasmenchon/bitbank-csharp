using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBank
{

    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo = 1000;

        //Saque
        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                this.saldo += valor;
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }

        }

        //Deposito
        public void Deposito(double valor)
        {
            this.saldo += valor;
        }

        //Transferencia
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                contaDestino.Deposito(valor);
                return true;
            }
        }

        //Metodo ver Saldo
        public double ObterSaldo()
        {
            return saldo;

        }

        //Metodo definir saldo e retirar valores negativos
        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {

                return;
            }
            else
            {

                this.saldo = saldo;
            }



        }





    }

}
