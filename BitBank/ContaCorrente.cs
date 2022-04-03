


using System;

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
    }


}

