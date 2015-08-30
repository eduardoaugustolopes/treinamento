namespace Clientes
{
    public class Clientes
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

        private double limiteCredito = 250;
        public double LimiteCredito
        {
            get { return limiteCredito; }
        }

    }
}
