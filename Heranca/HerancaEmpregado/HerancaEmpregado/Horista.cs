using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HerancaEmpregado
{
    class Horista : Empregado
    {
        public double precoHora=0;
        public double horasTrabalhadas=0;
         
        public double getPrecoHora()
        {
            return precoHora;
        }

        public void setPrecoHora(double precoHora)
        {
            this.precoHora = precoHora;
        }

        public double getHorasTrabalhadas()
        {
            return horasTrabalhadas;
        }

        public void setHorasTrabalhadas(double horasTrabalhadas)
        {
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public override double vencimento()
        {
            return precoHora * horasTrabalhadas;
        }

        public override string ToString()
        {
            return "\n\tHORISTA\nNome: \t\t\t" + getNome() + "\nSobrenome: \t\t" + getSobrenome() + "\nCPF: \t\t\t" + getCpf() + "\nPreço hora: \t\t" + getPrecoHora() + "\nHoras trabalhadas: \t" + getHorasTrabalhadas() + "\nVencimento: \t\t" + vencimento();
        }

    }
}
