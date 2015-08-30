using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommus.Domain
{
    public class ItensNotasFiscais
    {
        private int itemNotaFiscalId;

        public int ItemNotaFiscalId
        {
            get { return itemNotaFiscalId; }
            set { itemNotaFiscalId = value; }
        }

        private int notaFiscalId;

        public int NotaFiscalId
        {
            get { return notaFiscalId; }
            set { notaFiscalId = value; }
        }

        private int produtoId;

        public int ProdutoId
        {
            get { return produtoId; }
            set { produtoId = value; }
        }

        private double valorUnitario;

        public double ValorUnitario
        {
            get { return valorUnitario; }
            set { valorUnitario = value; }
        }

        private double quantidade;

        public double Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        private double imposto;

        public double Imposto
        {
            get { return imposto; }
            set { imposto = value; }
        }

        public double ValorTotal
        {
            get
            {
                return Quantidade * ValorUnitario;
            }
        }

        public double ValorLiquido
        {
            get
            {
                return ValorTotal - Imposto;
            }
        }

        private Produtos produtoItemNotaFiscal;

        public Produtos ProdutoItemNotaFiscal
        {
            get { return produtoItemNotaFiscal; }
            set { produtoItemNotaFiscal = value; }
        }
    }
}
