using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace FazendaGroup1 {
    public partial class Produtos : Form {
        private SqlConnection connectionstr;

        public Produtos() {
            InitializeComponent();
            textBoxCodBarras.MaxLength = 13;
            textBoxPrecoProduto.Enter += textBoxPrecoProduto_Enter;
            textBoxPrecoProduto.Leave += textBoxPrecoProduto_Leave;

        }

        private void Produtos_Load(object sender, EventArgs e) {
            CarregarDados();
        }

        private void CarregarDados() {
            try {
                connectionstr = new SqlConnection(ConnectionString.ObterConexao());
                connectionstr.Open();

                string query = "SELECT * FROM Produtos";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connectionstr);
                DataTable table = new DataTable();
                adapter.Fill(table);

            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
            finally {
                if (connectionstr != null && connectionstr.State == ConnectionState.Open) {
                    connectionstr.Close();
                }
            }
        }

        private void textBoxPrecoProduto_Enter(object sender, EventArgs e) {
            if (textBoxPrecoProduto.Text == "R$" || textBoxPrecoProduto.Text.StartsWith("R$ ")) {
                textBoxPrecoProduto.Text = textBoxPrecoProduto.Text.Replace("R$ ", "").Trim();
            }
        }

        private void textBoxPrecoProduto_Leave(object sender, EventArgs e) {
            if (decimal.TryParse(textBoxPrecoProduto.Text, out decimal price)) {
                textBoxPrecoProduto.Text = $"R$ {price:N2}";
            }
            else {
                textBoxPrecoProduto.Text = "R$";
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            // to verify if all columns were filled
            if (string.IsNullOrWhiteSpace(textBoxNomeProduto.Text) || string.IsNullOrWhiteSpace(textBoxDescricaoProduto.Text) ||
                string.IsNullOrWhiteSpace(textBoxPrecoProduto.Text) || string.IsNullOrWhiteSpace(textBoxQtdProduto.Text) ||
                string.IsNullOrWhiteSpace(textBoxCodBarras.Text)) {

                MessageBox.Show("Erro: Preencha todos os campos para seguir com a solicitação de cadastro de produto!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try {
                connectionstr = new SqlConnection(ConnectionString.ObterConexao());
                connectionstr.Open();

                string insertQuery = "INSERT INTO [dbo].[Produtos] (Nome, Descricao, Preco, Quantidade, CodigoBarras) VALUES (@Nome, @Descricao, @Preco, @Quantidade, @CodigoBarras)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connectionstr)) {
                    insertCommand.Parameters.Add("@Nome", SqlDbType.VarChar).Value = textBoxNomeProduto.Text;
                    insertCommand.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = textBoxDescricaoProduto.Text;

                    // i do the solution for convert the value of decimal and insert into DBA with "R$"
                    if (decimal.TryParse(textBoxPrecoProduto.Text.Replace("R$", "").Trim(), out decimal precoDecimal)) {
                        insertCommand.Parameters.Add("@Preco", SqlDbType.Decimal).Value = precoDecimal;
                    }
                    else {
                        MessageBox.Show("Erro: Formato inválido para o preço.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    insertCommand.Parameters.Add("@Quantidade", SqlDbType.Int).Value = int.Parse(textBoxQtdProduto.Text);
                    insertCommand.Parameters.Add("@CodigoBarras", SqlDbType.VarChar).Value = textBoxCodBarras.Text;

                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("O Produto foi cadastrado com sucesso!", "Solicitação feita com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // here i going to update the data grid after inserting the product
                    CarregarDados();
                }
            }
            catch (Exception erro) {
                MessageBox.Show("Erro: " + erro.Message);
            }
            finally {
                if (connectionstr != null && connectionstr.State == ConnectionState.Open) {
                    connectionstr.Close();
                }
            }
        }

        private void btnPesquisarProdutos_Click(object sender, EventArgs e) {
            ProdutosGrid grid = new ProdutosGrid();
            grid.Show();
            this.Hide();
        }

        private void labelReturn_Click(object sender, EventArgs e) {
            TelaCadastro menu = new Cadastro();
            menu.Show();
            this.Hide();
        }

        private void labelCloseApp_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void textBoxDescricaoProduto_TextChanged(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void textBoxPrecoProduto_TextChanged(object sender, EventArgs e) {

        }

        private void labelEmail_Click(object sender, EventArgs e) {

        }

        private void textBoxQtdProduto_TextChanged(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void textBoxCodBarras_TextChanged(object sender, EventArgs e) {

        }

        private void textBoxNomeProduto_TextChanged(object sender, EventArgs e) {

        }
    }
}
