using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNotas.Cadastros
{
    public partial class RegistroFornecedor : Form
    {
        public RegistroFornecedor()
        {
            InitializeComponent();
        }


        private void fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBNotasNewDataSet);

        }

        private void RegistroFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBNotasNewDataSet.fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.dBNotasNewDataSet.fornecedor);

        }
        
        public void FiltraFornecedor(int IdFornecedor)
        {
            this.fornecedorBindingSource.Filter = String.Format("for_codigo = {0}", IdFornecedor.ToString());
        }

        
    }
}
