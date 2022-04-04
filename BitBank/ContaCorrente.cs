using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBank
{

    public class ContaCorrente
    {
        public BitBank.Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 1000;

        //Saque
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




    }

}
