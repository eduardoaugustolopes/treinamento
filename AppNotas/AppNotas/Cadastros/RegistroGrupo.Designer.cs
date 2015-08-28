namespace AppNotas.Cadastros
{
    partial class RegistroGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroGrupo));
            System.Windows.Forms.Label grp_codigoLabel;
            System.Windows.Forms.Label grp_descricaoLabel;
            System.Windows.Forms.Label grp_observacoesLabel;
            this.dBNotasNewDataSet = new AppNotas.DBNotasNewDataSet();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoTableAdapter = new AppNotas.DBNotasNewDataSetTableAdapters.grupoTableAdapter();
            this.tableAdapterManager = new AppNotas.DBNotasNewDataSetTableAdapters.TableAdapterManager();
            this.grupoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.grupoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.grp_codigoTextBox = new System.Windows.Forms.TextBox();
            this.grp_descricaoTextBox = new System.Windows.Forms.TextBox();
            this.grp_observacoesTextBox = new System.Windows.Forms.TextBox();
            grp_codigoLabel = new System.Windows.Forms.Label();
            grp_descricaoLabel = new System.Windows.Forms.Label();
            grp_observacoesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBNotasNewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingNavigator)).BeginInit();
            this.grupoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dBNotasNewDataSet
            // 
            this.dBNotasNewDataSet.DataSetName = "DBNotasNewDataSet";
            this.dBNotasNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.entrada_produtoTableAdapter = null;
            this.tableAdapterManager.entradaTableAdapter = null;
            this.tableAdapterManager.fornecedorTableAdapter = null;
            this.tableAdapterManager.grupoTableAdapter = this.grupoTableAdapter;
            this.tableAdapterManager.produto_similarTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AppNotas.DBNotasNewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // grupoBindingNavigator
            // 
            this.grupoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.grupoBindingNavigator.BindingSource = this.grupoBindingSource;
            this.grupoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.grupoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.grupoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.grupoBindingNavigatorSaveItem});
            this.grupoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.grupoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.grupoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.grupoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.grupoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.grupoBindingNavigator.Name = "grupoBindingNavigator";
            this.grupoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.grupoBindingNavigator.Size = new System.Drawing.Size(365, 25);
            this.grupoBindingNavigator.TabIndex = 0;
            this.grupoBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // grupoBindingNavigatorSaveItem
            // 
            this.grupoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.grupoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("grupoBindingNavigatorSaveItem.Image")));
            this.grupoBindingNavigatorSaveItem.Name = "grupoBindingNavigatorSaveItem";
            this.grupoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.grupoBindingNavigatorSaveItem.Text = "Save Data";
            this.grupoBindingNavigatorSaveItem.Click += new System.EventHandler(this.grupoBindingNavigatorSaveItem_Click);
            // 
            // grp_codigoLabel
            // 
            grp_codigoLabel.AutoSize = true;
            grp_codigoLabel.Location = new System.Drawing.Point(12, 47);
            grp_codigoLabel.Name = "grp_codigoLabel";
            grp_codigoLabel.Size = new System.Drawing.Size(43, 13);
            grp_codigoLabel.TabIndex = 1;
            grp_codigoLabel.Text = "Código:";
            // 
            // grp_codigoTextBox
            // 
            this.grp_codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "grp_codigo", true));
            this.grp_codigoTextBox.Location = new System.Drawing.Point(107, 44);
            this.grp_codigoTextBox.Name = "grp_codigoTextBox";
            this.grp_codigoTextBox.ReadOnly = true;
            this.grp_codigoTextBox.Size = new System.Drawing.Size(100, 20);
            this.grp_codigoTextBox.TabIndex = 2;
            this.grp_codigoTextBox.TabStop = false;
            // 
            // grp_descricaoLabel
            // 
            grp_descricaoLabel.AutoSize = true;
            grp_descricaoLabel.Location = new System.Drawing.Point(12, 73);
            grp_descricaoLabel.Name = "grp_descricaoLabel";
            grp_descricaoLabel.Size = new System.Drawing.Size(58, 13);
            grp_descricaoLabel.TabIndex = 3;
            grp_descricaoLabel.Text = "Descrição:";
            // 
            // grp_descricaoTextBox
            // 
            this.grp_descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "grp_descricao", true));
            this.grp_descricaoTextBox.Location = new System.Drawing.Point(107, 70);
            this.grp_descricaoTextBox.Name = "grp_descricaoTextBox";
            this.grp_descricaoTextBox.Size = new System.Drawing.Size(246, 20);
            this.grp_descricaoTextBox.TabIndex = 4;
            // 
            // grp_observacoesLabel
            // 
            grp_observacoesLabel.AutoSize = true;
            grp_observacoesLabel.Location = new System.Drawing.Point(12, 99);
            grp_observacoesLabel.Name = "grp_observacoesLabel";
            grp_observacoesLabel.Size = new System.Drawing.Size(73, 13);
            grp_observacoesLabel.TabIndex = 5;
            grp_observacoesLabel.Text = "Observações:";
            // 
            // grp_observacoesTextBox
            // 
            this.grp_observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "grp_observacoes", true));
            this.grp_observacoesTextBox.Location = new System.Drawing.Point(107, 96);
            this.grp_observacoesTextBox.Name = "grp_observacoesTextBox";
            this.grp_observacoesTextBox.Size = new System.Drawing.Size(246, 20);
            this.grp_observacoesTextBox.TabIndex = 6;
            // 
            // RegistroGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 145);
            this.Controls.Add(grp_codigoLabel);
            this.Controls.Add(this.grp_codigoTextBox);
            this.Controls.Add(grp_descricaoLabel);
            this.Controls.Add(this.grp_descricaoTextBox);
            this.Controls.Add(grp_observacoesLabel);
            this.Controls.Add(this.grp_observacoesTextBox);
            this.Controls.Add(this.grupoBindingNavigator);
            this.Name = "RegistroGrupo";
            this.Text = "Registro de Grupo";
            this.Load += new System.EventHandler(this.RegistroGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBNotasNewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingNavigator)).EndInit();
            this.grupoBindingNavigator.ResumeLayout(false);
            this.grupoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBNotasNewDataSet dBNotasNewDataSet;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private DBNotasNewDataSetTableAdapters.grupoTableAdapter grupoTableAdapter;
        private DBNotasNewDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator grupoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton grupoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox grp_codigoTextBox;
        private System.Windows.Forms.TextBox grp_descricaoTextBox;
        private System.Windows.Forms.TextBox grp_observacoesTextBox;
    }
}