namespace AppNotas.Cadastros
{
    partial class CadastroSimilares
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroSimilares));
            this.dBNotasNewDataSet = new AppNotas.DBNotasNewDataSet();
            this.produto_similarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produto_similarTableAdapter = new AppNotas.DBNotasNewDataSetTableAdapters.produto_similarTableAdapter();
            this.tableAdapterManager = new AppNotas.DBNotasNewDataSetTableAdapters.TableAdapterManager();
            this.produto_similarBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.produto_similarBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.produto_similarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dBNotasNewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produto_similarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produto_similarBindingNavigator)).BeginInit();
            this.produto_similarBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produto_similarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dBNotasNewDataSet
            // 
            this.dBNotasNewDataSet.DataSetName = "DBNotasNewDataSet";
            this.dBNotasNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produto_similarBindingSource
            // 
            this.produto_similarBindingSource.DataMember = "produto_similar";
            this.produto_similarBindingSource.DataSource = this.dBNotasNewDataSet;
            // 
            // produto_similarTableAdapter
            // 
            this.produto_similarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.entrada_produtoTableAdapter = null;
            this.tableAdapterManager.entradaTableAdapter = null;
            this.tableAdapterManager.fornecedorTableAdapter = null;
            this.tableAdapterManager.grupoTableAdapter = null;
            this.tableAdapterManager.produto_similarTableAdapter = this.produto_similarTableAdapter;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppNotas.DBNotasNewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produto_similarBindingNavigator
            // 
            this.produto_similarBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produto_similarBindingNavigator.BindingSource = this.produto_similarBindingSource;
            this.produto_similarBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produto_similarBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produto_similarBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.produto_similarBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.produto_similarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produto_similarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produto_similarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produto_similarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produto_similarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produto_similarBindingNavigator.Name = "produto_similarBindingNavigator";
            this.produto_similarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produto_similarBindingNavigator.Size = new System.Drawing.Size(417, 25);
            this.produto_similarBindingNavigator.TabIndex = 0;
            this.produto_similarBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // produto_similarBindingNavigatorSaveItem
            // 
            this.produto_similarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produto_similarBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produto_similarBindingNavigatorSaveItem.Image")));
            this.produto_similarBindingNavigatorSaveItem.Name = "produto_similarBindingNavigatorSaveItem";
            this.produto_similarBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produto_similarBindingNavigatorSaveItem.Text = "Save Data";
            this.produto_similarBindingNavigatorSaveItem.Click += new System.EventHandler(this.produto_similarBindingNavigatorSaveItem_Click);
            // 
            // produto_similarDataGridView
            // 
            this.produto_similarDataGridView.AutoGenerateColumns = false;
            this.produto_similarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produto_similarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.produto_similarDataGridView.DataSource = this.produto_similarBindingSource;
            this.produto_similarDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.produto_similarDataGridView.Location = new System.Drawing.Point(0, 25);
            this.produto_similarDataGridView.Name = "produto_similarDataGridView";
            this.produto_similarDataGridView.Size = new System.Drawing.Size(417, 291);
            this.produto_similarDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "sim_produto";
            this.dataGridViewTextBoxColumn1.HeaderText = "sim_produto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sim_similar";
            this.dataGridViewTextBoxColumn2.HeaderText = "sim_similar";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sim_tipo";
            this.dataGridViewTextBoxColumn3.HeaderText = "sim_tipo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sim_observacoes";
            this.dataGridViewTextBoxColumn4.HeaderText = "sim_observacoes";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // CadastroSimilares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 316);
            this.Controls.Add(this.produto_similarDataGridView);
            this.Controls.Add(this.produto_similarBindingNavigator);
            this.Name = "CadastroSimilares";
            this.Text = "CadastroSimilares";
            this.Load += new System.EventHandler(this.CadastroSimilares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBNotasNewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produto_similarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produto_similarBindingNavigator)).EndInit();
            this.produto_similarBindingNavigator.ResumeLayout(false);
            this.produto_similarBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produto_similarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBNotasNewDataSet dBNotasNewDataSet;
        private System.Windows.Forms.BindingSource produto_similarBindingSource;
        private DBNotasNewDataSetTableAdapters.produto_similarTableAdapter produto_similarTableAdapter;
        private DBNotasNewDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produto_similarBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton produto_similarBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView produto_similarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}