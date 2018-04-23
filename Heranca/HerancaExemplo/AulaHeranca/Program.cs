using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AulaHerenca
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Aluno pessoa2 = new Aluno();
            Professor pessoa3 = new Professor();
            Funcionario pessoa4 = new Funcionario();
            Professor pessoa5 = new Professor();

            pessoa1.setNome("Luis");
            pessoa1.setIdade(30);
            pessoa1.setSexo("Masculino");

            pessoa2.setNome("Maria");
            pessoa2.setIdade(26);
            pessoa2.setSexo("Feminino");
            pessoa2.setMatricula(12345678);
            pessoa2.setCurso("TI");

            pessoa3.setNome("José");
            pessoa3.setIdade(40);
            pessoa3.setSexo("Masculino");
            pessoa3.setEspecialidade("Excel");
            pessoa3.setSalario(3000.50f);

            pessoa4.setNome("João");
            pessoa4.setIdade(34);
            pessoa4.setSexo("Masculino");
            pessoa4.setSetor("Administrativo");
            pessoa4.setTrabalhando(false);

            pessoa5.setNome("Caio");
            pessoa5.setIdade(35);
            pessoa5.setSexo("Masculino");
            pessoa5.setEspecialidade("Word");
            pessoa5.setSalario(2500.68f);

            Console.WriteLine(pessoa1.ToString());
            Console.WriteLine("\n" + pessoa2.ToString());
            Console.WriteLine("\n" + pessoa3.ToString());
            Console.WriteLine("\n" + pessoa4.ToString());
            Console.WriteLine("\n" + pessoa5.ToString());

            Console.ReadKey();
        }
    }
}
