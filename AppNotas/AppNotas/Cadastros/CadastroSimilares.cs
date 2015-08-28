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
    public partial class CadastroSimilares : Form
    {
        public CadastroSimilares()
        {
            InitializeComponent();
        }

        private void produto_similarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produto_similarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBNotasNewDataSet);

        }

        private void CadastroSimilares_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBNotasNewDataSet.produto_similar' table. You can move, or remove it, as needed.
            this.produto_similarTableAdapter.Fill(this.dBNotasNewDataSet.produto_similar);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RegistroSimilar _registroSimilar = new RegistroSimilar();
            var _idSimilar = this.produto_similarDataGridView.CurrentRow.Cells[0].Value.ToString();
            //_registroSimilar.FiltraSimilar(Convert.ToInt16(_idSimilar));
            _registroSimilar.StartPosition = FormStartPosition.CenterScreen;
            _registroSimilar.ShowDialog();
        }
    }
}
