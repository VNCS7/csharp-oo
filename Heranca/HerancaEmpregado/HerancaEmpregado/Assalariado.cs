using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HerancaEmpregado
{
    class Assalariado : Empregado
    {
        private double salario;
        private float horasAtraso;

        public double getSalario()
        {
            return salario;
        }

        public void setSalario(double salario)
        {
            this.salario = salario;
        }
      
        public override double vencimento()
        {
            return salario;
        }

        public void atraso(float horas)
        {
            horasAtraso = horas;
        }

        public void atraso(bool atraso)
        {

            if (atraso == true)
            {
                Console.WriteLine("Funcionário Atrasou!");
                salario = salario - (horasAtraso * 2);
            }
            else
                Console.WriteLine("Funcionário não atrasou!");
        }

        public void atraso(string dia)
        {
            Console.WriteLine("Funcionário teve R${0} descontados de seu salario devido atraso no dia: {1}" ,horasAtraso*2,dia);

        }






        public override string ToString()
        {
            return "\n\tASSALARIADO \nNome: \t\t" + getNome() + "\nSobrenome: \t" + getSobrenome() + "\nCPF: \t\t" + getCpf()+"\nSalario: \t"+getSalario()+"\nVencimento: \t"+vencimento();
        }

    }
}
