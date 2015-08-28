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
    public partial class RegistroGrupo : Form
    {
        public RegistroGrupo()
        {
            InitializeComponent();
        }

        private void grupoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.dBNotasNewDataSet.grupo)
            {
                if (item.grp_descricao.Length <= 3)
                {
                    MessageBox.Show(String.Format("Descrição tem que ter mais de 3 letras"));
                    return;
                }

                if (item.grp_observacoes.Length <= 3)
                {
                    MessageBox.Show(String.Format("Observações tem que ter mais de 3 letras"));
                    return;
                }

                if (item.grp_descricao==item.grp_observacoes)
                {
                    MessageBox.Show(String.Format("Descrição e observações não podem ser iguais.\n{0} - {1}", item.grp_descricao, item.grp_observacoes));
                    return;
                }
            }
            
            this.Validate();
            this.grupoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBNotasNewDataSet);

        }

        private void RegistroGrupo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBNotasNewDataSet.grupo' table. You can move, or remove it, as needed.
            this.grupoTableAdapter.Fill(this.dBNotasNewDataSet.grupo);

        }

        public void FiltraGrupo(int IdGrupo)
        {
            this.grupoBindingSource.Filter = String.Format("grp_codigo = {0}", IdGrupo.ToString());
        }
    }
}
