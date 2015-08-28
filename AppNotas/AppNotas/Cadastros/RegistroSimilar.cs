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
    public partial class RegistroSimilar : Form
    {
        public RegistroSimilar()
        {
            InitializeComponent();
        }

        private void produto_similarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produto_similarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBNotasNewDataSet);

        }

        private void produto_similarBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.produto_similarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBNotasNewDataSet);

        }

        private void RegistroSimilar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBNotasNewDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.dBNotasNewDataSet.produto);
            // TODO: This line of code loads data into the 'dBNotasNewDataSet.produto_similar' table. You can move, or remove it, as needed.
            this.produto_similarTableAdapter.Fill(this.dBNotasNewDataSet.produto_similar);
            // TODO: This line of code loads data into the 'dBNotasNewDataSet.produto_similar' table. You can move, or remove it, as needed.
            this.produto_similarTableAdapter.Fill(this.dBNotasNewDataSet.produto_similar);
            // TODO: This line of code loads data into the 'dBNotasNewDataSet.produto' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.dBNotasNewDataSet.produto);
            // TODO: This line of code loads data into the 'dBNotasNewDataSet.produto_similar' table. You can move, or remove it, as needed.
            this.produto_similarTableAdapter.Fill(this.dBNotasNewDataSet.produto_similar);

        }

        public void FiltraSimilar(int IdSimilar)
        {
            this.produto_similarBindingSource.Filter = String.Format("sim_similar = {0}", IdSimilar.ToString());
        }

        private void produto_similarBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.produto_similarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBNotasNewDataSet);

        }

        private void produto_similarBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.produto_similarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBNotasNewDataSet);

        }
    }
}
