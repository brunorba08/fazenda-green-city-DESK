namespace FazendaGroup1 {
    partial class Produtos {
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxCodBarras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQtdProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescricaoProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrecoProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPesquisarProdutos = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.labelCloseApp = new System.Windows.Forms.Label();
            this.labelReturn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fazenda Urbana";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(383, 391);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(190, 24);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Digite a quantidade";
            this.labelEmail.Click += new System.EventHandler(this.labelEmail_Click);
            // 
            // textBoxCodBarras
            // 
            this.textBoxCodBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCodBarras.Location = new System.Drawing.Point(342, 480);
            this.textBoxCodBarras.Name = "textBoxCodBarras";
            this.textBoxCodBarras.Size = new System.Drawing.Size(279, 20);
            this.textBoxCodBarras.TabIndex = 12;
            this.textBoxCodBarras.TextChanged += new System.EventHandler(this.textBoxCodBarras_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Digite a descrição";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxQtdProduto
            // 
            this.textBoxQtdProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQtdProduto.Location = new System.Drawing.Point(342, 419);
            this.textBoxQtdProduto.Name = "textBoxQtdProduto";
            this.textBoxQtdProduto.Size = new System.Drawing.Size(279, 20);
            this.textBoxQtdProduto.TabIndex = 14;
            this.textBoxQtdProduto.TextChanged += new System.EventHandler(this.textBoxQtdProduto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(359, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Digite o código de barras";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxDescricaoProduto
            // 
            this.textBoxDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescricaoProduto.Location = new System.Drawing.Point(342, 295);
            this.textBoxDescricaoProduto.Name = "textBoxDescricaoProduto";
            this.textBoxDescricaoProduto.Size = new System.Drawing.Size(279, 20);
            this.textBoxDescricaoProduto.TabIndex = 16;
            this.textBoxDescricaoProduto.TextChanged += new System.EventHandler(this.textBoxDescricaoProduto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Digite o nome do produto";
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNomeProduto.Location = new System.Drawing.Point(342, 229);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(279, 20);
            this.textBoxNomeProduto.TabIndex = 18;
            this.textBoxNomeProduto.TextChanged += new System.EventHandler(this.textBoxNomeProduto_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Digite o preço";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxPrecoProduto
            // 
            this.textBoxPrecoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPrecoProduto.Location = new System.Drawing.Point(342, 359);
            this.textBoxPrecoProduto.Name = "textBoxPrecoProduto";
            this.textBoxPrecoProduto.Size = new System.Drawing.Size(279, 20);
            this.textBoxPrecoProduto.TabIndex = 20;
            this.textBoxPrecoProduto.TextChanged += new System.EventHandler(this.textBoxPrecoProduto_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(424, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Produtos";
            // 
            // btnPesquisarProdutos
            // 
            this.btnPesquisarProdutos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPesquisarProdutos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarProdutos.ForeColor = System.Drawing.Color.Transparent;
            this.btnPesquisarProdutos.Location = new System.Drawing.Point(333, 565);
            this.btnPesquisarProdutos.Name = "btnPesquisarProdutos";
            this.btnPesquisarProdutos.Size = new System.Drawing.Size(134, 40);
            this.btnPesquisarProdutos.TabIndex = 23;
            this.btnPesquisarProdutos.Text = "Pesquisar";
            this.btnPesquisarProdutos.UseVisualStyleBackColor = false;
            this.btnPesquisarProdutos.Click += new System.EventHandler(this.btnPesquisarProdutos_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(499, 565);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(134, 40);
            this.btnCadastrarProduto.TabIndex = 24;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCloseApp
            // 
            this.labelCloseApp.AutoSize = true;
            this.labelCloseApp.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCloseApp.ForeColor = System.Drawing.Color.Red;
            this.labelCloseApp.Location = new System.Drawing.Point(868, 9);
            this.labelCloseApp.Name = "labelCloseApp";
            this.labelCloseApp.Size = new System.Drawing.Size(27, 27);
            this.labelCloseApp.TabIndex = 35;
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
            this.labelReturn.TabIndex = 36;
            this.labelReturn.Text = "🠔";
            this.labelReturn.Click += new System.EventHandler(this.labelReturn_Click);
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 741);
            this.Controls.Add(this.labelReturn);
            this.Controls.Add(this.labelCloseApp);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.btnPesquisarProdutos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPrecoProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNomeProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDescricaoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQtdProduto);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxCodBarras);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.Produtos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxCodBarras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQtdProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescricaoProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNomeProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrecoProduto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPesquisarProdutos;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Label labelCloseApp;
        private System.Windows.Forms.Label labelReturn;
    }
}