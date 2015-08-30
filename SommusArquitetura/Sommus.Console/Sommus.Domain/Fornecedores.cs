using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommus.Domain
{
    public class Fornecedores
    {
        public Fornecedores()
        {
            FornecedorId = -1;
            LimiteCredito = 250;
        }

        private int fornecedorId;

        public int FornecedorId
        {
            get { return fornecedorId; }
            set { fornecedorId = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string cNPJ;

        public string CNPJ
        {
            get { return cNPJ; }
            set { cNPJ = value; }
        }

        private double limiteCredito;

        public double LimiteCredito
        {
            get { return limiteCredito; }
            set { limiteCredito = value; }
        }

    }
}
