using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommus.Domain
{
    public class Produtos
    {
        private int produtoId;

        public int ProdutoId
        {
            get { return produtoId; }
            set { produtoId = value; }
        }

        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private double valorVenda;

        public double ValorVenda
        {
            get { return valorVenda; }
            set { valorVenda = value; }
        }

    }
}
