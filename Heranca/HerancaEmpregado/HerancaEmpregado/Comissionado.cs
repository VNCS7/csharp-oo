using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; //WINDSCRIBE

namespace HerancaEmpregado
{
    class Comissionado : Empregado
    {
        private double totalVenda=0;
        private double taxaComissao=0;
         
        public double getTotalVenda()
        {
            return totalVenda;
        }

        public void setTotalVenda(double totalVenda)
        {
            this.totalVenda = totalVenda;
        }

        public double getTaxaComissao()
        {
            return taxaComissao;
        }

        public void setTaxaComissao(double taxaComissao)
        {
            this.taxaComissao = taxaComissao;
        }

        public override double vencimento()
        {
            return taxaComissao*totalVenda;
        }

        public override string ToString()
        {
            return "\n\tCOMISSIONADO\nNome: \t\t" + getNome() + "\nSobrenome: \t" + getSobrenome() + "\nCPF: \t\t" + getCpf() + "\nTotal venda: \t" + getTotalVenda() + "\nTaxa comissão: \t" + getTaxaComissao() + "\nVencimento: \t" + vencimento();
        }

    }
}
