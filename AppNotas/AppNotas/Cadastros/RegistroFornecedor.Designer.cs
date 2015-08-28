namespace AppNotas.Cadastros
{
    partial class RegistroFornecedor
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
            System.Windows.Forms.Label for_codigoLabel;
            System.Windows.Forms.Label for_nomeLabel;
            System.Windows.Forms.Label for_cnpjLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroFornecedor));
            this.dBNotasNewDataSet = new AppNotas.DBNotasNewDataSet();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedorTableAdapter = new AppNotas.DBNotasNewDataSetTableAdapters.fornecedorTableAdapter();
            this.tableAdapterManager = new AppNotas.DBNotasNewDataSetTableAdapters.TableAdapterManager();
            this.fornecedorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.fornecedorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.for_codigoTextBox = new System.Windows.Forms.TextBox();
            this.for_nomeTextBox = new System.Windows.Forms.TextBox();
            this.for_cnpjTextBox = new System.Windows.Forms.TextBox();
            for_codigoLabel = new System.Windows.Forms.Label();
            for_nomeLabel = new System.Windows.Forms.Label();
            for_cnpjLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBNotasNewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingNavigator)).BeginInit();
            this.fornecedorBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // for_codigoLabel
            // 
            for_codigoLabel.AutoSize = true;
            for_codigoLabel.Location = new System.Drawing.Point(12, 48);
            for_codigoLabel.Name = "for_codigoLabel";
            for_codigoLabel.Size = new System.Drawing.Size(43, 13);
            for_codigoLabel.TabIndex = 1;
            for_codigoLabel.Text = "Código:";
            // 
            // for_nomeLabel
            // 
            for_nomeLabel.AutoSize = true;
            for_nomeLabel.Location = new System.Drawing.Point(12, 74);
            for_nomeLabel.Name = "for_nomeLabel";
            for_nomeLabel.Size = new System.Drawing.Size(38, 13);
            for_nomeLabel.TabIndex = 3;
            for_nomeLabel.Text = "Nome:";
            // 
            // for_cnpjLabel
            // 
            for_cnpjLabel.AutoSize = true;
            for_cnpjLabel.Location = new System.Drawing.Point(12, 100);
            for_cnpjLabel.Name = "for_cnpjLabel";
            for_cnpjLabel.Size = new System.Drawing.Size(37, 13);
            for_cnpjLabel.TabIndex = 5;
            for_cnpjLabel.Text = "CNPJ:";
            // 
            // dBNotasNewDataSet
            // 
            this.dBNotasNewDataSet.DataSetName = "DBNotasNewDataSet";
            this.dBNotasNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "fornecedor";
            this.fornecedorBindingSource.DataSource = this.dBNotasNewDataSet;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.entrada_produtoTableAdapter = null;
            this.tableAdapterManager.entradaTableAdapter = null;
            this.tableAdapterManager.fornecedorTableAdapter = this.fornecedorTableAdapter;
            this.tableAdapterManager.grupoTableAdapter = null;
            this.tableAdapterManager.produto_similarTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppNotas.DBNotasNewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fornecedorBindingNavigator
            // 
            this.fornecedorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fornecedorBindingNavigator.BindingSource = this.fornecedorBindingSource;
            this.fornecedorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fornecedorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fornecedorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fornecedorBindingNavigatorSaveItem});
            this.fornecedorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fornecedorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fornecedorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fornecedorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fornecedorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fornecedorBindingNavigator.Name = "fornecedorBindingNavigator";
            this.fornecedorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fornecedorBindingNavigator.Size = new System.Drawing.Size(442, 25);
            this.fornecedorBindingNavigator.TabIndex = 0;
            this.fornecedorBindingNavigator.Text = "bindingNavigator1";
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
            // fornecedorBindingNavigatorSaveItem
            // 
            this.fornecedorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fornecedorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fornecedorBindingNavigatorSaveItem.Image")));
            this.fornecedorBindingNavigatorSaveItem.Name = "fornecedorBindingNavigatorSaveItem";
            this.fornecedorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fornecedorBindingNavigatorSaveItem.Text = "Save Data";
            this.fornecedorBindingNavigatorSaveItem.Click += new System.EventHandler(this.fornecedorBindingNavigatorSaveItem_Click);
            // 
            // for_codigoTextBox
            // 
            this.for_codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "for_codigo", true));
            this.for_codigoTextBox.Location = new System.Drawing.Point(75, 45);
            this.for_codigoTextBox.Name = "for_codigoTextBox";
            this.for_codigoTextBox.ReadOnly = true;
            this.for_codigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.for_codigoTextBox.TabIndex = 2;
            this.for_codigoTextBox.TabStop = false;
            // 
            // for_nomeTextBox
            // 
            this.for_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "for_nome", true));
            this.for_nomeTextBox.Location = new System.Drawing.Point(75, 71);
            this.for_nomeTextBox.Name = "for_nomeTextBox";
            this.for_nomeTextBox.Size = new System.Drawing.Size(355, 20);
            this.for_nomeTextBox.TabIndex = 4;
            // 
            // for_cnpjTextBox
            // 
            this.for_cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "for_cnpj", true));
            this.for_cnpjTextBox.Location = new System.Drawing.Point(75, 97);
            this.for_cnpjTextBox.Name = "for_cnpjTextBox";
            this.for_cnpjTextBox.Size = new System.Drawing.Size(160, 20);
            this.for_cnpjTextBox.TabIndex = 6;
            // 
            // RegistroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 142);
            this.Controls.Add(for_codigoLabel);
            this.Controls.Add(this.for_codigoTextBox);
            this.Controls.Add(for_nomeLabel);
            this.Controls.Add(this.for_nomeTextBox);
            this.Controls.Add(for_cnpjLabel);
            this.Controls.Add(this.for_cnpjTextBox);
            this.Controls.Add(this.fornecedorBindingNavigator);
            this.Name = "RegistroFornecedor";
            this.Text = "Registro de Fornecedor";
            this.Load += new System.EventHandler(this.RegistroFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBNotasNewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingNavigator)).EndInit();
            this.fornecedorBindingNavigator.ResumeLayout(false);
            this.fornecedorBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBNotasNewDataSet dBNotasNewDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private DBNotasNewDataSetTableAdapters.fornecedorTableAdapter fornecedorTableAdapter;
        private DBNotasNewDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fornecedorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fornecedorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox for_codigoTextBox;
        private System.Windows.Forms.TextBox for_nomeTextBox;
        private System.Windows.Forms.TextBox for_cnpjTextBox;
    }
}