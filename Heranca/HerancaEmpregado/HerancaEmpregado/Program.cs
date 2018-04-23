using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HerancaEmpregado
{
    class Program
    {
        static void Main(string[] args)
        {
            Empregado       e1 = new Empregado();
            Assalariado     a1 = new Assalariado();
            Comissionado    c1 = new Comissionado();
            Horista         h1 = new Horista();

            e1.setNome("Leandro Ruan");
            e1.setSobrenome("Costa");
            e1.setCpf("173.128.226-57");
            Console.WriteLine(e1.ToString());

            a1.setNome("Lucca");
            a1.setSobrenome("da Cruz");
            a1.setCpf("957.576.904-02");
            a1.setSalario(2500f);

            a1.atraso(8);
            a1.atraso(true);
            Console.WriteLine(a1.ToString());
            a1.atraso("Segunda-Feira");

            c1.setNome("Diogo");
            c1.setSobrenome("Pereira");
            c1.setCpf("739.833.277-70");
            c1.setTaxaComissao(0.1f);
            c1.setTotalVenda(500f);
            Console.WriteLine(c1.ToString());

            h1.setNome("Kauê");
            h1.setSobrenome("Rocha");
            h1.setCpf("058.318.426-06");
            h1.setPrecoHora(10f);
            h1.setHorasTrabalhadas(30f);
            Console.WriteLine(h1.ToString());
                                                                              
            Console.ReadKey();
        }
    }
}
