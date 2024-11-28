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
    public partial class ExcluirProduto : Form {
        public ExcluirProduto() {
            InitializeComponent();
        }
        private SqlCommand command;
        private SqlDataReader reader;
        private SqlConnection connectionstr;

        private void ExcluirProduto_Load(object sender, EventArgs e) {

        }
        private void btnDeletarProduto_Click(object sender, EventArgs e) {
            if (int.TryParse(textBoxIDProduto.Text, out int produtoId)) {
                DeletarProduto(produtoId);
            }
            else {
                MessageBox.Show("Por favor, insira um ID de produto válido.");
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
        private void DeletarProduto(int produtoId) {
            using (SqlConnection connectionstr = new SqlConnection(ConnectionString.ObterConexao())) {
                string query = "DELETE FROM Produtos WHERE ID = @Id";

                SqlCommand command = new SqlCommand(query, connectionstr);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = produtoId;

                connectionstr.Open();
                int rowsAffected = command.ExecuteNonQuery();
                connectionstr.Close();

                if (rowsAffected > 0) {
                    MessageBox.Show("Produto deletado com sucesso!");
                }
                else {
                    MessageBox.Show("Produto não encontrado ou erro ao deletar.");
                }
            }
        }
        //text box changed after insert the information into box
        private void textBoxIDProduto_TextChanged(object sender, EventArgs e) {
            if (int.TryParse(textBoxIDProduto.Text, out int produtoId)) {
                CarregarDadosProduto(produtoId);
            }
        }

        private void labelConfirm_Click(object sender, EventArgs e) {
            //please, insert a true ID in the box!! if not, the product doesnt show!
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

        private void labelReturn_Click(object sender, EventArgs e) {
            ProdutosGrid produto = new ProdutosGrid();
            produto.Show();
            this.Hide();
        }

        private void labelCloseApp_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
