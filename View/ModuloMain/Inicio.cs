using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace FazendaGroup1 {
    public partial class Inicio : Form {
        public Inicio() {
            InitializeComponent();
        }
        private SqlConnection connectionstr;
        private SqlCommand command;
        private SqlDataReader reader;

        private void btnRegistrar_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnLogar_Click(object sender, EventArgs e) {

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e) {
            Cadastro cadastrar = new Cadastro();
            cadastrar.Show();
            this.Hide();
        }

        private void labelCloseApp_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnLogar_Click_1(object sender, EventArgs e) {
            if (textBoxUser.Text == "" || textBoxSenha.Text == "") {
                MessageBox.Show("Para logar, preencha todos os campos necessários", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try {
                connectionstr = new SqlConnection(ConnectionString.ObterConexao());
                connectionstr.Open();
                string strSQL = "SELECT Id, Email, Senha FROM Cadastro WHERE Email = @Email AND Senha = @Senha";
                using (SqlCommand command = new SqlCommand(strSQL, connectionstr)) {
                    command.Connection = connectionstr;
                    command.CommandText = strSQL;
                    command.Parameters.Clear();
                    command.Parameters.Add("@Email", SqlDbType.VarChar).Value = textBoxUser.Text;
                    command.Parameters.Add("@Senha", SqlDbType.VarChar).Value = textBoxSenha.Text;
                    reader = command.ExecuteReader();
                }
                if (reader.HasRows) {
                    reader.Read();
                    string nomeUsuario = reader["Email"].ToString();
                    string senha = reader["Senha"].ToString();
                    int index = Convert.ToInt32(reader["Id"]);
                    reader.Close();
                    MessageBox.Show("Seu login foi processado com sucesso!", "Solicitação feita com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cadastro menu = new Cadastro();
                    menu.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Usuário ou senha incorretos. Por favor, tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


            catch (Exception ex) {
                MessageBox.Show($"Erro: {ex.Message}");
            }
        }
    }
}




