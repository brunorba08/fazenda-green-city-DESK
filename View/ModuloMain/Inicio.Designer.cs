namespace FazendaGroup1 {
    partial class Inicio {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnLogar = new System.Windows.Forms.Button();
            this.labelCloseApp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fazenda Urbana";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSenha.Location = new System.Drawing.Point(333, 406);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(279, 20);
            this.textBoxSenha.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuário";
            // 
            // textBoxUser
            // 
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUser.Location = new System.Drawing.Point(333, 305);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(279, 20);
            this.textBoxUser.TabIndex = 6;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCadastro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastro.Location = new System.Drawing.Point(333, 522);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(122, 42);
            this.btnCadastro.TabIndex = 10;
            this.btnCadastro.Text = "Registre-se";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLogar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogar.Location = new System.Drawing.Point(516, 522);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(105, 42);
            this.btnLogar.TabIndex = 11;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click_1);
            // 
            // labelCloseApp
            // 
            this.labelCloseApp.AutoSize = true;
            this.labelCloseApp.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCloseApp.ForeColor = System.Drawing.Color.Red;
            this.labelCloseApp.Location = new System.Drawing.Point(916, 9);
            this.labelCloseApp.Name = "labelCloseApp";
            this.labelCloseApp.Size = new System.Drawing.Size(27, 27);
            this.labelCloseApp.TabIndex = 12;
            this.labelCloseApp.Text = "X";
            this.labelCloseApp.Click += new System.EventHandler(this.labelCloseApp_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 819);
            this.Controls.Add(this.labelCloseApp);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Label labelCloseApp;
    }
}

