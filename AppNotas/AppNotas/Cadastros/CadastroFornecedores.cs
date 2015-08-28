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
    public partial class CadastroFornecedores : Form
    {
        public CadastroFornecedores()
        {
            InitializeComponent();
        }

        private void fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBNotasNewDataSet);

        }

        private void CadastroFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBNotasNewDataSet.fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.dBNotasNewDataSet.fornecedor);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RegistroFornecedor _registroFornecedor = new RegistroFornecedor();
            var _idFornecedor = this.fornecedorDataGridView.CurrentRow.Cells[0].Value.ToString();
            _registroFornecedor.FiltraFornecedor(Convert.ToInt16(_idFornecedor));
            _registroFornecedor.StartPosition = FormStartPosition.CenterScreen;
            _registroFornecedor.ShowDialog();
        }
    }
}
