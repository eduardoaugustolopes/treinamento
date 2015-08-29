using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientes
{
    class Clientes
    {
        private int clienteId;

        public int ClienteID
        {
            get { return clienteId; }
            set { clienteId = value; }
        }

        private string clienteNome;

        public string ClienteNome
        {
            get { return clienteNome; }
            set { clienteNome = value; }
        }

        private string cnpjCliente;

        public string CnpjCliente
        {
            get { return cnpjCliente; }
            set { cnpjCliente = value; }
        }


    }
}
