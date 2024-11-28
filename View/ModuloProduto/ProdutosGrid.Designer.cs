namespace FazendaGroup1 {
    partial class ProdutosGrid {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fazendaDataSet = new FazendaGroup1.FazendaDataSet();
            this.produtosTableAdapter = new FazendaGroup1.FazendaDataSetTableAdapters.ProdutosTableAdapter();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPesquisarProdutoPorId = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.labelCloseApp = new System.Windows.Forms.Label();
            this.labelReturn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 24);
            this.label6.TabIndex = 24;
            this.label6.Text = "Pesquisa Produtos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.codigoBarrasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtosBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(196, 234);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(542, 265);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // codigoBarrasDataGridViewTextBoxColumn
            // 
            this.codigoBarrasDataGridViewTextBoxColumn.DataPropertyName = "CodigoBarras";
            this.codigoBarrasDataGridViewTextBoxColumn.HeaderText = "CodigoBarras";
            this.codigoBarrasDataGridViewTextBoxColumn.Name = "codigoBarrasDataGridViewTextBoxColumn";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.fazendaDataSet;
            // 
            // fazendaDataSet
            // 
            this.fazendaDataSet.DataSetName = "FazendaDataSet";
            this.fazendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditarProduto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProduto.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditarProduto.Location = new System.Drawing.Point(196, 520);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(134, 40);
            this.btnEditarProduto.TabIndex = 29;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = false;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 44);
            this.label3.TabIndex = 26;
            this.label3.Text = "Fazenda Urbana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Digite o ID ou Código de Barras";
            // 
            // textBoxPesquisarProdutoPorId
            // 
            this.textBoxPesquisarProdutoPorId.Location = new System.Drawing.Point(344, 193);
            this.textBoxPesquisarProdutoPorId.Name = "textBoxPesquisarProdutoPorId";
            this.textBoxPesquisarProdutoPorId.Size = new System.Drawing.Size(198, 20);
            this.textBoxPesquisarProdutoPorId.TabIndex = 31;
            this.textBoxPesquisarProdutoPorId.TextChanged += new System.EventHandler(this.textBoxPesquisarProdutoPorId_TextChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Location = new System.Drawing.Point(604, 520);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(134, 40);
            this.btnExcluir.TabIndex = 33;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // labelCloseApp
            // 
            this.labelCloseApp.AutoSize = true;
            this.labelCloseApp.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCloseApp.ForeColor = System.Drawing.Color.Red;
            this.labelCloseApp.Location = new System.Drawing.Point(868, 9);
            this.labelCloseApp.Name = "labelCloseApp";
            this.labelCloseApp.Size = new System.Drawing.Size(27, 27);
            this.labelCloseApp.TabIndex = 34;
            this.labelCloseApp.Text = "X";
            this.labelCloseApp.Click += new System.EventHandler(this.labelCloseApp_Click);
            // 
            // labelReturn
            // 
            this.labelReturn.AutoSize = true;
            this.labelReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturn.Location = new System.Drawing.Point(12, -8);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(60, 55);
            this.labelReturn.TabIndex = 35;
            this.labelReturn.Text = "🠔";
            this.labelReturn.Click += new System.EventHandler(this.labelReturn_Click);
            // 
            // ProdutosGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 741);
            this.Controls.Add(this.labelReturn);
            this.Controls.Add(this.labelCloseApp);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.textBoxPesquisarProdutoPorId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditarProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProdutosGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdutosGrid";
            this.Load += new System.EventHandler(this.ProdutosGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FazendaDataSet fazendaDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private FazendaDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPesquisarProdutoPorId;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label labelCloseApp;
        private System.Windows.Forms.Label labelReturn;
    }
}