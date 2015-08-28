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
    public partial class CadastroProdutos : Form
    {
        public CadastroProdutos()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBNotasNewDataSet);

        }

        private void CadastroProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBNotasNewDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.dBNotasNewDataSet.produto);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RegistroProduto _registroProduto = new RegistroProduto();
            var _idProduto = this.produtoDataGridView.CurrentRow.Cells[0].Value.ToString();
            _registroProduto.FiltraProduto(Convert.ToInt16(_idProduto));
            _registroProduto.StartPosition = FormStartPosition.CenterScreen;
            _registroProduto.ShowDialog();
        }
    }
}
