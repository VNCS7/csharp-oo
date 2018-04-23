using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HerancaEmpregado
{
    class Empregado
    {
        private string nome;
        private string sobrenome;
        private string cpf;

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getSobrenome()
        {
            return sobrenome;
        }

        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public string getCpf()
        {
            return cpf;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public virtual double vencimento()
        {
            return 1000;
        }

        public override string ToString()
        {
            return "\n\tEMPREGADO\nNome: \t\t" + getNome() + "\nSobrenome: \t" + getSobrenome() + "\nCPF: \t\t" + getCpf() + "\nVencimento: \t" + vencimento();
        }
    }
}
