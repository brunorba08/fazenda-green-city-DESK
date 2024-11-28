using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FazendaGroup1 {
    public partial class FornecedorCadastro : Form {
        public FornecedorCadastro() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            //the code check if every informations be solved!!
            if (textBoxFornecedor.Text == "") {
                MessageBox.Show("Erro: Preencha todos os campos para seguir com a solicitação de cadastro!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try {
                using (SqlConnection connectionstr = new SqlConnection(ConnectionString.ObterConexao())) {
                    connectionstr.Open();

                    //here, we going to check if exists the name! 
                    string checarNome = "SELECT Nome FROM Fornecedor WHERE Nome = @Nome";
                    using (SqlCommand checkName = new SqlCommand(checarNome, connectionstr)) {
                        checkName.Parameters.Add("@Nome", SqlDbType.VarChar).Value = textBoxFornecedor.Text;
                        using (SqlDataReader reader = checkName.ExecuteReader()) {
                            if (reader.HasRows) {
                                MessageBox.Show("Este fornecedor já foi cadastrado", "Algo deu errado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                reader.Close();
                                return;
                            }
                            reader.Close();
                        }
                    }

                    // insert into DBA if the name don't exists!!!
                    string insertQuery = "INSERT INTO [dbo].[Fornecedor] (Nome) VALUES (@Nome)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connectionstr)) {
                        insertCommand.Parameters.Add("@Nome", SqlDbType.VarChar).Value = textBoxFornecedor.Text;

                        insertCommand.ExecuteNonQuery();

                        MessageBox.Show("Novo fornecedor cadastrado!", "Solicitação feita com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connectionstr.Close();
                }
            }
            catch (Exception erro) {
                MessageBox.Show(erro.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            TelaCadastro menuPrincipal = new Cadastro();
            menuPrincipal.Show();
            this.Hide();

        }
    }
    }

