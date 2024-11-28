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
    public partial class ProdutosGrid : Form {
        public ProdutosGrid() {
            InitializeComponent();
        }

        private void ProdutosGrid_Load(object sender, EventArgs e)
        {
            try
            {
                this.produtosTableAdapter.Fill(this.fazendaDataSet.Produtos);
            }
            catch (SqlException)
            {
                
            }
        }

        private void textBoxPesquisarProdutoPorId_TextChanged(object sender, EventArgs e) {
            string pesquisa = textBoxPesquisarProdutoPorId.Text.Trim();

            if (!string.IsNullOrEmpty(pesquisa)) {
                try {
                    DataView dv = new DataView(fazendaDataSet.Produtos);
                    dv.RowFilter = $"Convert(ID, 'System.String') LIKE '%{pesquisa}%' OR CodigoBarras LIKE '%{pesquisa}%'";
                    dataGridView1.DataSource = dv;
                }
                catch (Exception ex) {
                    MessageBox.Show("Erro ao pesquisar produto: " + ex.Message);
                }
            }
            else {
                MessageBox.Show("Por favor, digite o ID ou Código de Barras do produto.");
            }
        }

        private void labelReturn_Click(object sender, EventArgs e) {
            Produtos produto = new Produtos();
            produto.Show();
            this.Hide();
        }

        private void labelCloseApp_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnPesquisarProdutos_Click(object sender, EventArgs e) {

        }

        private void btnEditarProduto_Click(object sender, EventArgs e) {
            EditarProduto edit = new EditarProduto();
            edit.Show();
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            ExcluirProduto excluir = new ExcluirProduto();
            excluir.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
