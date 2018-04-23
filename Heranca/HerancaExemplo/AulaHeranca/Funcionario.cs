using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AulaHerenca
{
    public class Funcionario : Pessoa
    {
        private string setor;
        private Boolean trabalhando;

        public void mudarTrabalho()
        {
            this.trabalhando = !this.trabalhando;
        }

        public string getSetor()
        {
            return setor;
        }

        public void setSetor(string setor)
        {
            this.setor = setor;
        }

        public Boolean getTrabalhando()
        {
            return trabalhando;
        }

        public void setTrabalhando(Boolean trabalhando)
        {
            this.trabalhando = trabalhando;
        }

        public override string ToString()
        {
            return "Funcionario" + "\nNome: \t\t" + getNome() + "\nIdade: \t\t" + getIdade() + "\nSexo: \t\t" + getSexo() + "\nSetor: \t\t" + setor + "\nTrabalhando: \t" + trabalhando;
        }

    }
}
