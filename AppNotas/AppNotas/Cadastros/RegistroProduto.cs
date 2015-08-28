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
    public partial class RegistroProduto : Form
    {
        public RegistroProduto()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBNotasNewDataSet);

        }

        private void RegistroProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBNotasNewDataSet.grupo' table. You can move, or remove it, as needed.
            this.grupoTableAdapter.Fill(this.dBNotasNewDataSet.grupo);
            // TODO: This line of code loads data into the 'dBNotasNewDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.dBNotasNewDataSet.produto);

        }

        public void FiltraProduto(int IdProduto)
        {
            this.produtoBindingSource.Filter = String.Format("prd_codigo = {0}", IdProduto.ToString());
        }
    }
}
