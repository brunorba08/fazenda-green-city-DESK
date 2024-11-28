using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FazendaGroup1 {
    public partial class TelaCadastro : Form {
        public TelaCadastro() {
            InitializeComponent();
        }

        private void btnFornecedores_Click(object sender, EventArgs e) {
            FornecedorCadastro fornecedor = new FornecedorCadastro();
            fornecedor.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e) {
            Produtos produtos = new Produtos();
            produtos.Show();
            this.Hide();
        }

        private void labelCloseApp_Click(object sender, EventArgs e) {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("Tem certeza que deseja sair?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                this.Close();
                Inicio inicio = new Inicio();
                inicio.Show();
            }
        }
    }
}
