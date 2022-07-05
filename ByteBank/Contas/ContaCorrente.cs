using ByteBank.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Contas
{
    internal class ContaCorrente
    {
        public Cliente titular;
        public double saldo;
        public string agencia;
        public string numConta;

        public void Depositar( double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                saldo += valor;
                return;
            }
        }

        public bool Sacar (double valor)
        {
            if (valor > saldo || valor <0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (valor > this.saldo || valor <0)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                destino.Depositar(valor);
                return true;
            }
        }




    }
}
