using AppNotas.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNotas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroGrupos _grupos = new CadastroGrupos();
            _grupos.StartPosition = FormStartPosition.CenterScreen;
            _grupos.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedores _fornecedores = new CadastroFornecedores();
            _fornecedores.StartPosition = FormStartPosition.CenterScreen;
            _fornecedores.ShowDialog();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroProdutos _produtos = new CadastroProdutos();
            _produtos.StartPosition = FormStartPosition.CenterScreen;
            _produtos.ShowDialog();
        }

        private void similaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroSimilares _similares = new CadastroSimilares();
            _similares.StartPosition = FormStartPosition.CenterScreen;
            _similares.ShowDialog();
        }
    }
}
