using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AulaHerenca
{
    public class Aluno : Pessoa
    {
        private int matricula;
        private string curso;

        public void cancelarMatricula()
        {
            Console.WriteLine("Matricula cancelada!");
        }

        public int getMatricula()
        {
            return matricula;
        }

        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }

        public string getCurso()
        {
            return curso;
        }

        public void setCurso(string curso)
        {
            this.curso = curso;
        }

        public override string ToString()
        {
            return "Aluno\n" + "Nome: \t\t" + getNome() + "\nIdade: \t\t" + getIdade() + "\nSexo: \t\t" + getSexo() + "\nMatricula: \t" + matricula + "\nCurso: \t\t" + curso;
        }
    }
}
