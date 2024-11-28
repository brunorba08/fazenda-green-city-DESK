namespace FazendaGroup1 {
    partial class FornecedorCadastro {
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
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.labelNameFornecedor = new System.Windows.Forms.Label();
            this.textBoxFornecedor = new System.Windows.Forms.TextBox();
            this.btnCadastrarFornecedor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fazenda Urbana";
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornecedor.Location = new System.Drawing.Point(404, 216);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(130, 22);
            this.labelFornecedor.TabIndex = 3;
            this.labelFornecedor.Text = "Fornecedores";
            // 
            // labelNameFornecedor
            // 
            this.labelNameFornecedor.AutoSize = true;
            this.labelNameFornecedor.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameFornecedor.ForeColor = System.Drawing.Color.Black;
            this.labelNameFornecedor.Location = new System.Drawing.Point(329, 290);
            this.labelNameFornecedor.Name = "labelNameFornecedor";
            this.labelNameFornecedor.Size = new System.Drawing.Size(282, 24);
            this.labelNameFornecedor.TabIndex = 4;
            this.labelNameFornecedor.Text = "Digite o nome do Fornecedor";
            // 
            // textBoxFornecedor
            // 
            this.textBoxFornecedor.Location = new System.Drawing.Point(333, 342);
            this.textBoxFornecedor.Name = "textBoxFornecedor";
            this.textBoxFornecedor.Size = new System.Drawing.Size(278, 20);
            this.textBoxFornecedor.TabIndex = 5;
            // 
            // btnCadastrarFornecedor
            // 
            this.btnCadastrarFornecedor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCadastrarFornecedor.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFornecedor.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarFornecedor.Location = new System.Drawing.Point(479, 437);
            this.btnCadastrarFornecedor.Name = "btnCadastrarFornecedor";
            this.btnCadastrarFornecedor.Size = new System.Drawing.Size(132, 62);
            this.btnCadastrarFornecedor.TabIndex = 6;
            this.btnCadastrarFornecedor.Text = "Cadastrar";
            this.btnCadastrarFornecedor.UseVisualStyleBackColor = false;
            this.btnCadastrarFornecedor.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(333, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 62);
            this.button1.TabIndex = 7;
            this.button1.Text = "Retornar ao Menu ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FornecedorCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCadastrarFornecedor);
            this.Controls.Add(this.textBoxFornecedor);
            this.Controls.Add(this.labelNameFornecedor);
            this.Controls.Add(this.labelFornecedor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FornecedorCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FornecedorCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.Label labelNameFornecedor;
        private System.Windows.Forms.TextBox textBoxFornecedor;
        private System.Windows.Forms.Button btnCadastrarFornecedor;
        private System.Windows.Forms.Button button1;
    }
}