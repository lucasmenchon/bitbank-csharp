using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBank
{

    public class ContaCorrente
    {
        //
        public Cliente Titular { get; set; }

        public int agencia;
        public int numero;
        private double _saldo = 10;

        //
        public double Saldo
        {
            get
            {
                return _saldo;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        //Saque
        public bool Sacar(double valor)
        {
            if (this._saldo < valor | this._saldo < 0)
            {
                this._saldo += valor;
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }

        }

        //Deposito
        public void Deposito(double valor)
        {
            this._saldo += valor;
        }

        //Transferencia
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {

            if (this._saldo < valor | this._saldo < 0) //(this._saldo < valor | this._saldo  <= 0)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Deposito(valor);
                return true;

            }

                        
        }

        //Metodo ver Saldo - codigo aprimorado > Saldo/get/set
        /*public double ObterSaldo()
        {
            return saldo;

        }*/

        //Metodo definir saldo e retirar valores negativos - codigo aprimorado > Saldo/get/set
        /*public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {

                return;
            }
            else
            {

                this.saldo = saldo;
            }



        }*/





    }

}
