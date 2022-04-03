using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBank
{

    public class ContaCorrente
    {
        public string titular;
        public int agencia;
        public int numero;
        public double saldo = 1000;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }

        }//Saque

        public void Deposito(double valor)
        {
            this.saldo += valor;
        }//Deposito

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




    }

}
