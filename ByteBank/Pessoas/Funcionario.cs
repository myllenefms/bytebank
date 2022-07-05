using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Pessoas
{
    public class Funcionario
    {
        public int id = 5;
        public string nome;
        public DateTime dataAdmissao;
        public int tempoDeEmpresa;
        public double salario = 1200;


        public Funcionario ( string nome, DateTime Admissao)
        {
            this.nome = nome;
            this.dataAdmissao = Admissao;

            int tempo = DateTime.Today.Year - this.dataAdmissao.Year;
            if (this.dataAdmissao.Month > DateTime.Today.Month ||
                (this.dataAdmissao.Month == DateTime.Today.Month && this.dataAdmissao.Day < DateTime.Today.Day))
                tempo--;


            this.tempoDeEmpresa = tempo;
            
        }

        public bool Promover( int tempoDeEmpresa)
        {
           if(tempoDeEmpresa < 1)
           {
               return false;
           }
           else if (tempoDeEmpresa >= 20)
           {
                id = 1;
                AjustarSalario();
                return true;
           }
           else if (tempoDeEmpresa >= 10)
           {
                id = 3;
                AjustarSalario();
                return true;
           }
           {
                id--;
                AjustarSalario();
                return true;
           }
        }

        public void Bonificar(int tempoDeEmpresa)
        {
            double bonus = this.salario;
            if (tempoDeEmpresa >= 20)
            {
                bonus *= 0.20;
                this.salario += bonus;
                return;
            }
            else if (tempoDeEmpresa >= 10)
            {
                bonus *= 0.10;
                this.salario += bonus;
                return;
            }
            else return;
        }

        public void AjustarSalario()
        {
            switch (id)
            {
                case 5:
                    salario += 0.05 * salario;
                    break;
                case 4:
                    salario += 0.1 * salario;
                    break;
                case 3:
                    salario += 0.15 * salario;
                    break;
                case 2:
                    salario += 0.2 * salario;
                    break;
                case 1:
                    salario += 0.25 * salario;
                    break;
                default:
                    salario += 0.01 * salario;
                    break;
            }
        }
    }
}
