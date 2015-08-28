namespace AppNotas.Cadastros
{
    partial class RegistroSimilar
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
            System.Windows.Forms.Label sim_produtoLabel;
            System.Windows.Forms.Label sim_similarLabel;
            System.Windows.Forms.Label sim_tipoLabel;
            System.Windows.Forms.Label sim_observacoesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroSimilar));
            this.dBNotasNewDataSet = new AppNotas.DBNotasNewDataSet();
            this.produto_similarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produto_similarTableAdapter = new AppNotas.DBNotasNewDataSetTableAdapters.produto_similarTableAdapter();
            this.tableAdapterManager = new AppNotas.DBNotasNewDataSetTableAdapters.TableAdapterManager();
            this.produtoTableAdapter = new AppNotas.DBNotasNewDataSetTableAdapters.produtoTableAdapter();
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
            this.sim_produtoComboBox = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sim_similarComboBox = new System.Windows.Forms.ComboBox();
            this.produtosimilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sim_tipoTextBox = new System.Windows.Forms.TextBox();
            this.sim_observacoesTextBox = new System.Windows.Forms.TextBox();
            this.produtosimilarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            sim_produtoLabel = new System.Windows.Forms.Label();
            sim_similarLabel = new System.Windows.Forms.Label();
            sim_tipoLabel = new System.Windows.Forms.Label();
            sim_observacoesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBNotasNewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produto_similarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produto_similarBindingNavigator)).BeginInit();
            this.produto_similarBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosimilarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosimilarBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // sim_produtoLabel
            // 
            sim_produtoLabel.AutoSize = true;
            sim_produtoLabel.Location = new System.Drawing.Point(26, 43);
            sim_produtoLabel.Name = "sim_produtoLabel";
            sim_produtoLabel.Size = new System.Drawing.Size(64, 13);
            sim_produtoLabel.TabIndex = 1;
            sim_produtoLabel.Text = "sim produto:";
            // 
            // sim_similarLabel
            // 
            sim_similarLabel.AutoSize = true;
            sim_similarLabel.Location = new System.Drawing.Point(26, 70);
            sim_similarLabel.Name = "sim_similarLabel";
            sim_similarLabel.Size = new System.Drawing.Size(56, 13);
            sim_similarLabel.TabIndex = 3;
            sim_similarLabel.Text = "sim similar:";
            // 
            // sim_tipoLabel
            // 
            sim_tipoLabel.AutoSize = true;
            sim_tipoLabel.Location = new System.Drawing.Point(26, 97);
            sim_tipoLabel.Name = "sim_tipoLabel";
            sim_tipoLabel.Size = new System.Drawing.Size(45, 13);
            sim_tipoLabel.TabIndex = 5;
            sim_tipoLabel.Text = "sim tipo:";
            // 
            // sim_observacoesLabel
            // 
            sim_observacoesLabel.AutoSize = true;
            sim_observacoesLabel.Location = new System.Drawing.Point(26, 123);
            sim_observacoesLabel.Name = "sim_observacoesLabel";
            sim_observacoesLabel.Size = new System.Drawing.Size(89, 13);
            sim_observacoesLabel.TabIndex = 7;
            sim_observacoesLabel.Text = "sim observacoes:";
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
            this.tableAdapterManager.produtoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.UpdateOrder = AppNotas.DBNotasNewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
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
            this.produto_similarBindingNavigatorSaveItem});
            this.produto_similarBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produto_similarBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produto_similarBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produto_similarBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produto_similarBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produto_similarBindingNavigator.Name = "produto_similarBindingNavigator";
            this.produto_similarBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produto_similarBindingNavigator.Size = new System.Drawing.Size(411, 25);
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
            this.produto_similarBindingNavigatorSaveItem.Click += new System.EventHandler(this.produto_similarBindingNavigatorSaveItem_Click_3);
            // 
            // sim_produtoComboBox
            // 
            this.sim_produtoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produto_similarBindingSource, "sim_produto", true));
            this.sim_produtoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtosimilarBindingSource, "sim_produto", true));
            this.sim_produtoComboBox.DataSource = this.produtoBindingSource;
            this.sim_produtoComboBox.DisplayMember = "prd_descricao";
            this.sim_produtoComboBox.FormattingEnabled = true;
            this.sim_produtoComboBox.Location = new System.Drawing.Point(121, 40);
            this.sim_produtoComboBox.Name = "sim_produtoComboBox";
            this.sim_produtoComboBox.Size = new System.Drawing.Size(121, 21);
            this.sim_produtoComboBox.TabIndex = 2;
            this.sim_produtoComboBox.ValueMember = "prd_codigo";
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "produto";
            this.produtoBindingSource1.DataSource = this.dBNotasNewDataSet;
            // 
            // sim_similarComboBox
            // 
            this.sim_similarComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produto_similarBindingSource, "sim_similar", true));
            this.sim_similarComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtosimilarBindingSource1, "sim_similar", true));
            this.sim_similarComboBox.DataSource = this.produtoBindingSource1;
            this.sim_similarComboBox.DisplayMember = "prd_descricao";
            this.sim_similarComboBox.FormattingEnabled = true;
            this.sim_similarComboBox.Location = new System.Drawing.Point(121, 67);
            this.sim_similarComboBox.Name = "sim_similarComboBox";
            this.sim_similarComboBox.Size = new System.Drawing.Size(121, 21);
            this.sim_similarComboBox.TabIndex = 4;
            this.sim_similarComboBox.ValueMember = "prd_codigo";
            // 
            // produtosimilarBindingSource
            // 
            this.produtosimilarBindingSource.DataMember = "produto_similar";
            this.produtosimilarBindingSource.DataSource = this.dBNotasNewDataSet;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.dBNotasNewDataSet;
            // 
            // sim_tipoTextBox
            // 
            this.sim_tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produto_similarBindingSource, "sim_tipo", true));
            this.sim_tipoTextBox.Location = new System.Drawing.Point(121, 94);
            this.sim_tipoTextBox.Name = "sim_tipoTextBox";
            this.sim_tipoTextBox.Size = new System.Drawing.Size(121, 20);
            this.sim_tipoTextBox.TabIndex = 6;
            // 
            // sim_observacoesTextBox
            // 
            this.sim_observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produto_similarBindingSource, "sim_observacoes", true));
            this.sim_observacoesTextBox.Location = new System.Drawing.Point(121, 120);
            this.sim_observacoesTextBox.Name = "sim_observacoesTextBox";
            this.sim_observacoesTextBox.Size = new System.Drawing.Size(121, 20);
            this.sim_observacoesTextBox.TabIndex = 8;
            // 
            // produtosimilarBindingSource1
            // 
            this.produtosimilarBindingSource1.DataMember = "produto_similar";
            this.produtosimilarBindingSource1.DataSource = this.dBNotasNewDataSet;
            // 
            // RegistroSimilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 261);
            this.Controls.Add(sim_produtoLabel);
            this.Controls.Add(this.sim_produtoComboBox);
            this.Controls.Add(sim_similarLabel);
            this.Controls.Add(this.sim_similarComboBox);
            this.Controls.Add(sim_tipoLabel);
            this.Controls.Add(this.sim_tipoTextBox);
            this.Controls.Add(sim_observacoesLabel);
            this.Controls.Add(this.sim_observacoesTextBox);
            this.Controls.Add(this.produto_similarBindingNavigator);
            this.Name = "RegistroSimilar";
            this.Text = "RegistroSimilar";
            this.Load += new System.EventHandler(this.RegistroSimilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBNotasNewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produto_similarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produto_similarBindingNavigator)).EndInit();
            this.produto_similarBindingNavigator.ResumeLayout(false);
            this.produto_similarBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosimilarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosimilarBindingSource1)).EndInit();
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
        private DBNotasNewDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.ComboBox sim_produtoComboBox;
        private System.Windows.Forms.ComboBox sim_similarComboBox;
        private System.Windows.Forms.TextBox sim_tipoTextBox;
        private System.Windows.Forms.TextBox sim_observacoesTextBox;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private System.Windows.Forms.BindingSource produtosimilarBindingSource;
        private System.Windows.Forms.BindingSource produtosimilarBindingSource1;



    }
}