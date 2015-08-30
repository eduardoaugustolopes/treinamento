using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommus.Domain
{
    public class Clientes
    {
        public Clientes()
        {
            LimiteCredito = 250;
            ClienteID = -1;
        }

        private int clienteID;

        public int ClienteID
        {
            get { return clienteID; }
            set { clienteID = value; }
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
