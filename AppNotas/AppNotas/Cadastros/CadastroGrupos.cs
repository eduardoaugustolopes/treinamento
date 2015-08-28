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
    public partial class CadastroGrupos : Form
    {
        public CadastroGrupos()
        {
            InitializeComponent();
        }

        private void grupoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.grupoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBNotasNewDataSet);

        }

        private void CadastroGrupos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBNotasNewDataSet.grupo' table. You can move, or remove it, as needed.
            this.grupoTableAdapter.Fill(this.dBNotasNewDataSet.grupo);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RegistroGrupo _registroGrupo = new RegistroGrupo();
            var _idGrupo = this.grupoDataGridView.CurrentRow.Cells[0].Value.ToString();
            _registroGrupo.FiltraGrupo(Convert.ToInt16(_idGrupo));
            _registroGrupo.StartPosition = FormStartPosition.CenterScreen;
            _registroGrupo.ShowDialog();
        }
    }
}
