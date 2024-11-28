namespace FazendaGroup1 {
    partial class Cadastro {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelConfirmeSenha = new System.Windows.Forms.Label();
            this.textBoxConfirmeSenha = new System.Windows.Forms.TextBox();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.btnLogar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Faça seu Cadastro";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSenha.Location = new System.Drawing.Point(333, 369);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(279, 20);
            this.textBoxSenha.TabIndex = 13;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(430, 342);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(70, 24);
            this.labelSenha.TabIndex = 12;
            this.labelSenha.Text = "Senha";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(388, 248);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(168, 24);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "Digite seu E-mail";
            // 
            // textBoxUser
            // 
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUser.Location = new System.Drawing.Point(333, 275);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(279, 20);
            this.textBoxUser.TabIndex = 10;
            // 
            // labelConfirmeSenha
            // 
            this.labelConfirmeSenha.AutoSize = true;
            this.labelConfirmeSenha.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmeSenha.Location = new System.Drawing.Point(366, 433);
            this.labelConfirmeSenha.Name = "labelConfirmeSenha";
            this.labelConfirmeSenha.Size = new System.Drawing.Size(200, 24);
            this.labelConfirmeSenha.TabIndex = 14;
            this.labelConfirmeSenha.Text = "Confirme sua Senha";
            // 
            // textBoxConfirmeSenha
            // 
            this.textBoxConfirmeSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConfirmeSenha.Location = new System.Drawing.Point(333, 476);
            this.textBoxConfirmeSenha.Name = "textBoxConfirmeSenha";
            this.textBoxConfirmeSenha.PasswordChar = '*';
            this.textBoxConfirmeSenha.Size = new System.Drawing.Size(279, 20);
            this.textBoxConfirmeSenha.TabIndex = 15;
            this.textBoxConfirmeSenha.TextChanged += new System.EventHandler(this.textBoxConfirmeSenha_TextChanged);
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.BackColor = System.Drawing.Color.Green;
            this.btnCriarConta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarConta.ForeColor = System.Drawing.Color.Transparent;
            this.btnCriarConta.Location = new System.Drawing.Point(490, 554);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(122, 42);
            this.btnCriarConta.TabIndex = 16;
            this.btnCriarConta.Text = "Criar Conta";
            this.btnCriarConta.UseVisualStyleBackColor = false;
            this.btnCriarConta.Click += new System.EventHandler(this.btnCriarConta_Click);
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.Red;
            this.btnLogar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogar.Location = new System.Drawing.Point(333, 554);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(105, 42);
            this.btnLogar.TabIndex = 17;
            this.btnLogar.Text = "Sair";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 780);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.btnCriarConta);
            this.Controls.Add(this.textBoxConfirmeSenha);
            this.Controls.Add(this.labelConfirmeSenha);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelConfirmeSenha;
        private System.Windows.Forms.TextBox textBoxConfirmeSenha;
        private System.Windows.Forms.Button btnCriarConta;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}