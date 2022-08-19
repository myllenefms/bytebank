using ByteBank.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH
{
    public class GerenciadorBonificacao
    {
        private double totalBonus;

        public void Registrar (Funcionario funcionario)
        {
            this.totalBonus += funcionario.Bonificar();
        }

        public double getBonus()
        {
            return this.totalBonus;
        }
    }
}
