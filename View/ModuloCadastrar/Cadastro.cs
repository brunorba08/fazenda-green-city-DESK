using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FazendaGroup1 {
    public partial class Cadastro : Form {
        public Cadastro() {
            InitializeComponent();
        }

        private SqlConnection connectionstr;
        private SqlCommand command;
        private SqlDataReader reader;

        private void btnCriarConta_Click(object sender, EventArgs e) {

            //the code check if every informations be solved!!
            if (textBoxUser.Text == "" || textBoxSenha.Text == "" || textBoxConfirmeSenha.Text == "") {
                MessageBox.Show("Erro: Preencha todos os campos para seguir com a solicitação de cadastro!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //here, we have a code for the password be equal!!
            if (textBoxSenha.Text != textBoxConfirmeSenha.Text) {
                MessageBox.Show("Erro: As senhas não coincidem! Por favor, digite novamente.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxSenha.Clear();
                textBoxConfirmeSenha.Clear();
                textBoxSenha.Focus();
                return;
            }

            try {
                connectionstr = new SqlConnection(ConnectionString.ObterConexao());
                connectionstr.Open();

                //here, we going to check if exists the email! 
                string checarEmail = "SELECT Email FROM Cadastro WHERE Email = @Email";
                using (SqlCommand checkEmail = new SqlCommand(checarEmail, connectionstr)) {
                    checkEmail.Parameters.Add("@Email", SqlDbType.VarChar).Value = textBoxUser.Text;
                    using (SqlDataReader reader = checkEmail.ExecuteReader()) {
                        if (reader.HasRows) {
                            MessageBox.Show("Este e-mail já foi cadastrado! Insira outro e-mail", "Algo deu errado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reader.Close();
                            return;
                        }
                        reader.Close();
                    }
                }

                // insert into DBA if the email don't exists!!!
                string insertQuery = "INSERT INTO [dbo].[Cadastro] (Email, Senha) VALUES (@Email, @Senha)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connectionstr)) {
                    insertCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = textBoxUser.Text;
                    insertCommand.Parameters.Add("@Senha", SqlDbType.VarChar).Value = textBoxSenha.Text;

                    insertCommand.ExecuteNonQuery();

                    MessageBox.Show("Novo usuário cadastrado!", "Solicitação feita com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connectionstr.Close();
            }
            catch (Exception erro) {
                MessageBox.Show(erro.Message);
                if (connectionstr != null && connectionstr.State == ConnectionState.Open) {
                    connectionstr.Close();
                }
            }
        }

        private void textBoxConfirmeSenha_TextChanged(object sender, EventArgs e) {

        }

        private void btnLogar_Click(object sender, EventArgs e) {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }
    }
}
