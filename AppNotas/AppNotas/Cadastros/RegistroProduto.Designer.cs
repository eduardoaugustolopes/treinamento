namespace AppNotas.Cadastros
{
    partial class RegistroProduto
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
            System.Windows.Forms.Label prd_codigoLabel;
            System.Windows.Forms.Label prd_descricaoLabel;
            System.Windows.Forms.Label prd_grupoLabel;
            System.Windows.Forms.Label prd_estoqueLabel;
            System.Windows.Forms.Label prd_preco_custoLabel;
            System.Windows.Forms.Label prd_margem_lucroLabel;
            System.Windows.Forms.Label prd_preco_vendaLabel;
            System.Windows.Forms.Label prd_data_cadastroLabel;
            System.Windows.Forms.Label prd_ativoLabel;
            System.Windows.Forms.Label prd_observacoesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroProduto));
            this.dBNotasNewDataSet = new AppNotas.DBNotasNewDataSet();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new AppNotas.DBNotasNewDataSetTableAdapters.produtoTableAdapter();
            this.tableAdapterManager = new AppNotas.DBNotasNewDataSetTableAdapters.TableAdapterManager();
            this.produtoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.produtoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.prd_codigoTextBox = new System.Windows.Forms.TextBox();
            this.prd_descricaoTextBox = new System.Windows.Forms.TextBox();
            this.prd_estoqueTextBox = new System.Windows.Forms.TextBox();
            this.prd_preco_custoTextBox = new System.Windows.Forms.TextBox();
            this.prd_margem_lucroTextBox = new System.Windows.Forms.TextBox();
            this.prd_preco_vendaTextBox = new System.Windows.Forms.TextBox();
            this.prd_data_cadastroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.prd_ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.prd_observacoesTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoTableAdapter = new AppNotas.DBNotasNewDataSetTableAdapters.grupoTableAdapter();
            prd_codigoLabel = new System.Windows.Forms.Label();
            prd_descricaoLabel = new System.Windows.Forms.Label();
            prd_grupoLabel = new System.Windows.Forms.Label();
            prd_estoqueLabel = new System.Windows.Forms.Label();
            prd_preco_custoLabel = new System.Windows.Forms.Label();
            prd_margem_lucroLabel = new System.Windows.Forms.Label();
            prd_preco_vendaLabel = new System.Windows.Forms.Label();
            prd_data_cadastroLabel = new System.Windows.Forms.Label();
            prd_ativoLabel = new System.Windows.Forms.Label();
            prd_observacoesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBNotasNewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).BeginInit();
            this.produtoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prd_codigoLabel
            // 
            prd_codigoLabel.AutoSize = true;
            prd_codigoLabel.Location = new System.Drawing.Point(14, 45);
            prd_codigoLabel.Name = "prd_codigoLabel";
            prd_codigoLabel.Size = new System.Drawing.Size(43, 13);
            prd_codigoLabel.TabIndex = 1;
            prd_codigoLabel.Text = "Código:";
            // 
            // prd_descricaoLabel
            // 
            prd_descricaoLabel.AutoSize = true;
            prd_descricaoLabel.Location = new System.Drawing.Point(14, 71);
            prd_descricaoLabel.Name = "prd_descricaoLabel";
            prd_descricaoLabel.Size = new System.Drawing.Size(58, 13);
            prd_descricaoLabel.TabIndex = 3;
            prd_descricaoLabel.Text = "Descrição:";
            // 
            // prd_grupoLabel
            // 
            prd_grupoLabel.AutoSize = true;
            prd_grupoLabel.Location = new System.Drawing.Point(14, 97);
            prd_grupoLabel.Name = "prd_grupoLabel";
            prd_grupoLabel.Size = new System.Drawing.Size(39, 13);
            prd_grupoLabel.TabIndex = 5;
            prd_grupoLabel.Text = "Grupo:";
            // 
            // prd_estoqueLabel
            // 
            prd_estoqueLabel.AutoSize = true;
            prd_estoqueLabel.Location = new System.Drawing.Point(14, 123);
            prd_estoqueLabel.Name = "prd_estoqueLabel";
            prd_estoqueLabel.Size = new System.Drawing.Size(49, 13);
            prd_estoqueLabel.TabIndex = 7;
            prd_estoqueLabel.Text = "Estoque:";
            // 
            // prd_preco_custoLabel
            // 
            prd_preco_custoLabel.AutoSize = true;
            prd_preco_custoLabel.Location = new System.Drawing.Point(14, 149);
            prd_preco_custoLabel.Name = "prd_preco_custoLabel";
            prd_preco_custoLabel.Size = new System.Drawing.Size(83, 13);
            prd_preco_custoLabel.TabIndex = 9;
            prd_preco_custoLabel.Text = "Preço de Custo:";
            // 
            // prd_margem_lucroLabel
            // 
            prd_margem_lucroLabel.AutoSize = true;
            prd_margem_lucroLabel.Location = new System.Drawing.Point(14, 175);
            prd_margem_lucroLabel.Name = "prd_margem_lucroLabel";
            prd_margem_lucroLabel.Size = new System.Drawing.Size(93, 13);
            prd_margem_lucroLabel.TabIndex = 11;
            prd_margem_lucroLabel.Text = "Margem de Lucro:";
            // 
            // prd_preco_vendaLabel
            // 
            prd_preco_vendaLabel.AutoSize = true;
            prd_preco_vendaLabel.Location = new System.Drawing.Point(14, 201);
            prd_preco_vendaLabel.Name = "prd_preco_vendaLabel";
            prd_preco_vendaLabel.Size = new System.Drawing.Size(87, 13);
            prd_preco_vendaLabel.TabIndex = 13;
            prd_preco_vendaLabel.Text = "Preço de Venda:";
            // 
            // prd_data_cadastroLabel
            // 
            prd_data_cadastroLabel.AutoSize = true;
            prd_data_cadastroLabel.Location = new System.Drawing.Point(14, 228);
            prd_data_cadastroLabel.Name = "prd_data_cadastroLabel";
            prd_data_cadastroLabel.Size = new System.Drawing.Size(93, 13);
            prd_data_cadastroLabel.TabIndex = 15;
            prd_data_cadastroLabel.Text = "Data de Cadastro:";
            // 
            // prd_ativoLabel
            // 
            prd_ativoLabel.AutoSize = true;
            prd_ativoLabel.Location = new System.Drawing.Point(14, 255);
            prd_ativoLabel.Name = "prd_ativoLabel";
            prd_ativoLabel.Size = new System.Drawing.Size(74, 13);
            prd_ativoLabel.TabIndex = 17;
            prd_ativoLabel.Text = "Produto Ativo:";
            // 
            // prd_observacoesLabel
            // 
            prd_observacoesLabel.AutoSize = true;
            prd_observacoesLabel.Location = new System.Drawing.Point(14, 283);
            prd_observacoesLabel.Name = "prd_observacoesLabel";
            prd_observacoesLabel.Size = new System.Drawing.Size(73, 13);
            prd_observacoesLabel.TabIndex = 19;
            prd_observacoesLabel.Text = "Observações:";
            // 
            // dBNotasNewDataSet
            // 
            this.dBNotasNewDataSet.DataSetName = "DBNotasNewDataSet";
            this.dBNotasNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.dBNotasNewDataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.entrada_produtoTableAdapter = null;
            this.tableAdapterManager.entradaTableAdapter = null;
            this.tableAdapterManager.fornecedorTableAdapter = null;
            this.tableAdapterManager.grupoTableAdapter = null;
            this.tableAdapterManager.produto_similarTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.UpdateOrder = AppNotas.DBNotasNewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // produtoBindingNavigator
            // 
            this.produtoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produtoBindingNavigator.BindingSource = this.produtoBindingSource;
            this.produtoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produtoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produtoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.produtoBindingNavigatorSaveItem});
            this.produtoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produtoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produtoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produtoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produtoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produtoBindingNavigator.Name = "produtoBindingNavigator";
            this.produtoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produtoBindingNavigator.Size = new System.Drawing.Size(370, 25);
            this.produtoBindingNavigator.TabIndex = 0;
            this.produtoBindingNavigator.Text = "bindingNavigator1";
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
            // produtoBindingNavigatorSaveItem
            // 
            this.produtoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produtoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produtoBindingNavigatorSaveItem.Image")));
            this.produtoBindingNavigatorSaveItem.Name = "produtoBindingNavigatorSaveItem";
            this.produtoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produtoBindingNavigatorSaveItem.Text = "Save Data";
            this.produtoBindingNavigatorSaveItem.Click += new System.EventHandler(this.produtoBindingNavigatorSaveItem_Click);
            // 
            // prd_codigoTextBox
            // 
            this.prd_codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "prd_codigo", true));
            this.prd_codigoTextBox.Location = new System.Drawing.Point(113, 42);
            this.prd_codigoTextBox.Name = "prd_codigoTextBox";
            this.prd_codigoTextBox.ReadOnly = true;
            this.prd_codigoTextBox.Size = new System.Drawing.Size(88, 20);
            this.prd_codigoTextBox.TabIndex = 2;
            this.prd_codigoTextBox.TabStop = false;
            // 
            // prd_descricaoTextBox
            // 
            this.prd_descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "prd_descricao", true));
            this.prd_descricaoTextBox.Location = new System.Drawing.Point(113, 68);
            this.prd_descricaoTextBox.Name = "prd_descricaoTextBox";
            this.prd_descricaoTextBox.Size = new System.Drawing.Size(245, 20);
            this.prd_descricaoTextBox.TabIndex = 4;
            // 
            // prd_estoqueTextBox
            // 
            this.prd_estoqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "prd_estoque", true));
            this.prd_estoqueTextBox.Location = new System.Drawing.Point(113, 120);
            this.prd_estoqueTextBox.Name = "prd_estoqueTextBox";
            this.prd_estoqueTextBox.Size = new System.Drawing.Size(200, 20);
            this.prd_estoqueTextBox.TabIndex = 8;
            // 
            // prd_preco_custoTextBox
            // 
            this.prd_preco_custoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "prd_preco_custo", true));
            this.prd_preco_custoTextBox.Location = new System.Drawing.Point(113, 146);
            this.prd_preco_custoTextBox.Name = "prd_preco_custoTextBox";
            this.prd_preco_custoTextBox.Size = new System.Drawing.Size(200, 20);
            this.prd_preco_custoTextBox.TabIndex = 10;
            // 
            // prd_margem_lucroTextBox
            // 
            this.prd_margem_lucroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "prd_margem_lucro", true));
            this.prd_margem_lucroTextBox.Location = new System.Drawing.Point(113, 172);
            this.prd_margem_lucroTextBox.Name = "prd_margem_lucroTextBox";
            this.prd_margem_lucroTextBox.Size = new System.Drawing.Size(200, 20);
            this.prd_margem_lucroTextBox.TabIndex = 12;
            // 
            // prd_preco_vendaTextBox
            // 
            this.prd_preco_vendaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "prd_preco_venda", true));
            this.prd_preco_vendaTextBox.Location = new System.Drawing.Point(113, 198);
            this.prd_preco_vendaTextBox.Name = "prd_preco_vendaTextBox";
            this.prd_preco_vendaTextBox.Size = new System.Drawing.Size(200, 20);
            this.prd_preco_vendaTextBox.TabIndex = 14;
            // 
            // prd_data_cadastroDateTimePicker
            // 
            this.prd_data_cadastroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.produtoBindingSource, "prd_data_cadastro", true));
            this.prd_data_cadastroDateTimePicker.Location = new System.Drawing.Point(113, 224);
            this.prd_data_cadastroDateTimePicker.Name = "prd_data_cadastroDateTimePicker";
            this.prd_data_cadastroDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.prd_data_cadastroDateTimePicker.TabIndex = 16;
            // 
            // prd_ativoCheckBox
            // 
            this.prd_ativoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.produtoBindingSource, "prd_ativo", true));
            this.prd_ativoCheckBox.Location = new System.Drawing.Point(113, 250);
            this.prd_ativoCheckBox.Name = "prd_ativoCheckBox";
            this.prd_ativoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.prd_ativoCheckBox.TabIndex = 18;
            this.prd_ativoCheckBox.Text = "checkBox1";
            this.prd_ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // prd_observacoesTextBox
            // 
            this.prd_observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "prd_observacoes", true));
            this.prd_observacoesTextBox.Location = new System.Drawing.Point(113, 280);
            this.prd_observacoesTextBox.Name = "prd_observacoesTextBox";
            this.prd_observacoesTextBox.Size = new System.Drawing.Size(200, 20);
            this.prd_observacoesTextBox.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtoBindingSource, "prd_grupo", true));
            this.comboBox1.DataSource = this.grupoBindingSource;
            this.comboBox1.DisplayMember = "grp_descricao";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "grp_codigo";
            // 
            // grupoBindingSource
            // 
            this.grupoBindingSource.DataMember = "grupo";
            this.grupoBindingSource.DataSource = this.dBNotasNewDataSet;
            // 
            // grupoTableAdapter
            // 
            this.grupoTableAdapter.ClearBeforeFill = true;
            // 
            // RegistroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 335);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(prd_codigoLabel);
            this.Controls.Add(this.prd_codigoTextBox);
            this.Controls.Add(prd_descricaoLabel);
            this.Controls.Add(this.prd_descricaoTextBox);
            this.Controls.Add(prd_grupoLabel);
            this.Controls.Add(prd_estoqueLabel);
            this.Controls.Add(this.prd_estoqueTextBox);
            this.Controls.Add(prd_preco_custoLabel);
            this.Controls.Add(this.prd_preco_custoTextBox);
            this.Controls.Add(prd_margem_lucroLabel);
            this.Controls.Add(this.prd_margem_lucroTextBox);
            this.Controls.Add(prd_preco_vendaLabel);
            this.Controls.Add(this.prd_preco_vendaTextBox);
            this.Controls.Add(prd_data_cadastroLabel);
            this.Controls.Add(this.prd_data_cadastroDateTimePicker);
            this.Controls.Add(prd_ativoLabel);
            this.Controls.Add(this.prd_ativoCheckBox);
            this.Controls.Add(prd_observacoesLabel);
            this.Controls.Add(this.prd_observacoesTextBox);
            this.Controls.Add(this.produtoBindingNavigator);
            this.Name = "RegistroProduto";
            this.Text = "RegistroProduto";
            this.Load += new System.EventHandler(this.RegistroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBNotasNewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).EndInit();
            this.produtoBindingNavigator.ResumeLayout(false);
            this.produtoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBNotasNewDataSet dBNotasNewDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private DBNotasNewDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private DBNotasNewDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produtoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton produtoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox prd_codigoTextBox;
        private System.Windows.Forms.TextBox prd_descricaoTextBox;
        private System.Windows.Forms.TextBox prd_estoqueTextBox;
        private System.Windows.Forms.TextBox prd_preco_custoTextBox;
        private System.Windows.Forms.TextBox prd_margem_lucroTextBox;
        private System.Windows.Forms.TextBox prd_preco_vendaTextBox;
        private System.Windows.Forms.DateTimePicker prd_data_cadastroDateTimePicker;
        private System.Windows.Forms.CheckBox prd_ativoCheckBox;
        private System.Windows.Forms.TextBox prd_observacoesTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private DBNotasNewDataSetTableAdapters.grupoTableAdapter grupoTableAdapter;
    }
}