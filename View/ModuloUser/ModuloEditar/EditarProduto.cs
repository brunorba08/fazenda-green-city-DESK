using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazendaGroup1 {
    public partial class EditarProduto : Form {
        public EditarProduto() {
            InitializeComponent();
        }

        private SqlCommand command;
        private SqlDataReader reader;
        private SqlConnection connectionstr;
        private void labelReturn_Click(object sender, EventArgs e) {
            ProdutosGrid produto = new ProdutosGrid();
            produto.Show();
            this.Close();
        }

        private void EditarProduto_Load(object sender, EventArgs e)
        {
            try
            {
                
                this.produtosTableAdapter.Fill(this.fazendaDataSet1.Produtos);
            }
            catch (SqlException)
            {
                
            }
        }

        private void labelCloseApp_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnAtualizarProduto_Click(object sender, EventArgs e) {
            //i do the function for convert ID for int and update in dba the information you want
            if (int.TryParse(textBoxIDProduto.Text, out int produtoId)) {
                AtualizarProduto(produtoId);
            }
        }
        private bool CarregarDadosProduto(int produtoId) {

            //i dont know how i make this, but is working! haha
            bool produtoEncontrado = false;
            using (SqlConnection connectionstr = new SqlConnection(ConnectionString.ObterConexao())) {
                string query = "SELECT Nome, Descricao, Preco, Quantidade, CodigoBarras FROM Produtos WHERE ID = @Id";

                SqlCommand command = new SqlCommand(query, connectionstr);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = produtoId;

                connectionstr.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) {
                    textBoxNomeProduto.Text = reader["Nome"].ToString();
                    textBoxDescricaoProduto.Text = reader["Descricao"].ToString();
                    textBoxPrecoProduto.Text = reader["Preco"].ToString();
                    textBoxQtdProduto.Text = reader["Quantidade"].ToString();
                    textBoxCodBarras.Text = reader["CodigoBarras"].ToString();
                    produtoEncontrado = true;
                }

                connectionstr.Close();
            }
            return produtoEncontrado;
        }

        private void textBoxIDProduto_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(textBoxIDProduto.Text, out int produtoId)) {
                CarregarDadosProduto(produtoId);
            }
        }

        private void AtualizarProduto(int produtoId)
        {
            using (SqlConnection connectionstr = new SqlConnection(ConnectionString.ObterConexao()))
            {
                // Inicia a query base
                string query = "UPDATE Produtos SET ";
                List<string> camposAtualizar = new List<string>();
                SqlCommand command = new SqlCommand();

                // Verifica quais campos estão preenchidos e os adiciona à query
                if (!string.IsNullOrWhiteSpace(textBoxNomeProduto.Text))
                {
                    camposAtualizar.Add("Nome = @Nome");
                    command.Parameters.Add("@Nome", SqlDbType.NVarChar).Value = textBoxNomeProduto.Text;
                }

                if (!string.IsNullOrWhiteSpace(textBoxDescricaoProduto.Text))
                {
                    camposAtualizar.Add("Descricao = @Descricao");
                    command.Parameters.Add("@Descricao", SqlDbType.NVarChar).Value = textBoxDescricaoProduto.Text;
                }

                if (!string.IsNullOrWhiteSpace(textBoxPrecoProduto.Text))
                {
                    camposAtualizar.Add("Preco = @Preco");
                    command.Parameters.Add("@Preco", SqlDbType.Decimal).Value = Convert.ToDecimal(textBoxPrecoProduto.Text);
                }

                if (!string.IsNullOrWhiteSpace(textBoxQtdProduto.Text))
                {
                    camposAtualizar.Add("Quantidade = @Quantidade");
                    command.Parameters.Add("@Quantidade", SqlDbType.Int).Value = Convert.ToInt32(textBoxQtdProduto.Text);
                }

                if (!string.IsNullOrWhiteSpace(textBoxCodBarras.Text))
                {
                    camposAtualizar.Add("CodigoBarras = @CodigoBarras");
                    command.Parameters.Add("@CodigoBarras", SqlDbType.NVarChar).Value = textBoxCodBarras.Text;
                }

                // Se nenhum campo foi preenchido, exibe uma mensagem de erro e retorna
                if (camposAtualizar.Count == 0)
                {
                    MessageBox.Show("Nenhum campo foi preenchido para atualização.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Monta a query final concatenando os campos preenchidos
                query += string.Join(", ", camposAtualizar) + " WHERE ID = @Id";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = produtoId;

                command.CommandText = query;
                command.Connection = connectionstr;

                // Executa a query
                connectionstr.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connectionstr.Close();

                // Exibe a mensagem de sucesso ou erro
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Produto atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar o produto.");
                }
            }
        }

        private void labelConfirm_Click(object sender, EventArgs e) {
            if (int.TryParse(textBoxIDProduto.Text, out int produtoId)) {
                bool produtoExiste = CarregarDadosProduto(produtoId);
                if (!produtoExiste) {
                    MessageBox.Show("Produto não encontrado.");
                }
            }
            else {
                MessageBox.Show("Por favor, insira um ID de produto válido.");
            }
        }
    }
}
