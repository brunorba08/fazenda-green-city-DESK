namespace FazendaGroup1 {
    partial class EditarProduto {
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
            this.labelReturn = new System.Windows.Forms.Label();
            this.labelCloseApp = new System.Windows.Forms.Label();
            this.fazendaDataSet1 = new FazendaGroup1.FazendaDataSet1();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new FazendaGroup1.FazendaDataSet1TableAdapters.ProdutosTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxQtdProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodBarras = new System.Windows.Forms.TextBox();
            this.textBoxDescricaoProduto = new System.Windows.Forms.TextBox();
            this.textBoxPrecoProduto = new System.Windows.Forms.TextBox();
            this.textBoxIDProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAtualizarProduto = new System.Windows.Forms.Button();
            this.labelConfirm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fazendaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReturn
            // 
            this.labelReturn.AutoSize = true;
            this.labelReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturn.Location = new System.Drawing.Point(12, -8);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(60, 55);
            this.labelReturn.TabIndex = 36;
            this.labelReturn.Text = "🠔";
            this.labelReturn.Click += new System.EventHandler(this.labelReturn_Click);
            // 
            // labelCloseApp
            // 
            this.labelCloseApp.AutoSize = true;
            this.labelCloseApp.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCloseApp.ForeColor = System.Drawing.Color.Red;
            this.labelCloseApp.Location = new System.Drawing.Point(868, 9);
            this.labelCloseApp.Name = "labelCloseApp";
            this.labelCloseApp.Size = new System.Drawing.Size(27, 27);
            this.labelCloseApp.TabIndex = 37;
            this.labelCloseApp.Text = "X";
            this.labelCloseApp.Click += new System.EventHandler(this.labelCloseApp_Click);
            // 
            // fazendaDataSet1
            // 
            this.fazendaDataSet1.DataSetName = "FazendaDataSet1";
            this.fazendaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.fazendaDataSet1;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 44);
            this.label3.TabIndex = 40;
            this.label3.Text = "Fazenda Urbana";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 24);
            this.label6.TabIndex = 39;
            this.label6.Text = "Editar Produtos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Digite o nome do produto";
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNomeProduto.Location = new System.Drawing.Point(332, 277);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(279, 20);
            this.textBoxNomeProduto.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Digite a descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(386, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 44;
            this.label5.Text = "Digite o preço";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(373, 448);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(190, 24);
            this.labelEmail.TabIndex = 45;
            this.labelEmail.Text = "Digite a quantidade";
            // 
            // textBoxQtdProduto
            // 
            this.textBoxQtdProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQtdProduto.Location = new System.Drawing.Point(332, 485);
            this.textBoxQtdProduto.Name = "textBoxQtdProduto";
            this.textBoxQtdProduto.Size = new System.Drawing.Size(279, 20);
            this.textBoxQtdProduto.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "Digite o código de barras";
            // 
            // textBoxCodBarras
            // 
            this.textBoxCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCodBarras.Location = new System.Drawing.Point(332, 558);
            this.textBoxCodBarras.Name = "textBoxCodBarras";
            this.textBoxCodBarras.Size = new System.Drawing.Size(279, 20);
            this.textBoxCodBarras.TabIndex = 48;
            // 
            // textBoxDescricaoProduto
            // 
            this.textBoxDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescricaoProduto.Location = new System.Drawing.Point(332, 346);
            this.textBoxDescricaoProduto.Name = "textBoxDescricaoProduto";
            this.textBoxDescricaoProduto.Size = new System.Drawing.Size(279, 20);
            this.textBoxDescricaoProduto.TabIndex = 49;
            // 
            // textBoxPrecoProduto
            // 
            this.textBoxPrecoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrecoProduto.Location = new System.Drawing.Point(332, 414);
            this.textBoxPrecoProduto.Name = "textBoxPrecoProduto";
            this.textBoxPrecoProduto.Size = new System.Drawing.Size(279, 20);
            this.textBoxPrecoProduto.TabIndex = 50;
            // 
            // textBoxIDProduto
            // 
            this.textBoxIDProduto.Location = new System.Drawing.Point(495, 190);
            this.textBoxIDProduto.Multiline = true;
            this.textBoxIDProduto.Name = "textBoxIDProduto";
            this.textBoxIDProduto.Size = new System.Drawing.Size(36, 27);
            this.textBoxIDProduto.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(327, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 27);
            this.label7.TabIndex = 52;
            this.label7.Text = "ID do Produto";
            // 
            // btnAtualizarProduto
            // 
            this.btnAtualizarProduto.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAtualizarProduto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarProduto.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtualizarProduto.Location = new System.Drawing.Point(390, 614);
            this.btnAtualizarProduto.Name = "btnAtualizarProduto";
            this.btnAtualizarProduto.Size = new System.Drawing.Size(134, 40);
            this.btnAtualizarProduto.TabIndex = 53;
            this.btnAtualizarProduto.Text = "Atualizar";
            this.btnAtualizarProduto.UseVisualStyleBackColor = false;
            this.btnAtualizarProduto.Click += new System.EventHandler(this.btnAtualizarProduto_Click);
            // 
            // labelConfirm
            // 
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirm.Location = new System.Drawing.Point(537, 190);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(39, 27);
            this.labelConfirm.TabIndex = 54;
            this.labelConfirm.Text = "✔";
            this.labelConfirm.Click += new System.EventHandler(this.labelConfirm_Click);
            // 
            // EditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 741);
            this.Controls.Add(this.labelConfirm);
            this.Controls.Add(this.btnAtualizarProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxIDProduto);
            this.Controls.Add(this.textBoxPrecoProduto);
            this.Controls.Add(this.textBoxDescricaoProduto);
            this.Controls.Add(this.textBoxCodBarras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQtdProduto);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNomeProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelCloseApp);
            this.Controls.Add(this.labelReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarProduto";
            this.Load += new System.EventHandler(this.EditarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fazendaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.Label labelCloseApp;
        private FazendaDataSet1 fazendaDataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private FazendaDataSet1TableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNomeProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxQtdProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodBarras;
        private System.Windows.Forms.TextBox textBoxDescricaoProduto;
        private System.Windows.Forms.TextBox textBoxPrecoProduto;
        private System.Windows.Forms.TextBox textBoxIDProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAtualizarProduto;
        private System.Windows.Forms.Label labelConfirm;
    }
}