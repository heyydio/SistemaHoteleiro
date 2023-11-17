using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_CLC.Cadastros
{
    public partial class frCargos : Form
    {
        public frCargos()
        {
            InitializeComponent();
        }
        private void desabilitarCampos()
        {
            tbCargo.Enabled = false;
        }

        private void limparCampos()
        {
            tbCargo.Clear();
        }
        private void btNovo_Click(object sender, EventArgs e)
        {
            tbCargo.Enabled = true;
            btSalvar.Enabled = true;
            btNovo.Enabled = false;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;
            tbCargo.Focus();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (tbCargo.Text.ToString() == "")
            {
                MessageBox.Show("Preencha o Cargo!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCargo.Text = "";
                tbCargo.Focus();
                return;
            }

            //Código do botão para salvar

            MessageBox.Show("Registro salvo com sucesso!", "REGISTRO SALVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btNovo.Enabled = true;
            btSalvar.Enabled= false;
            tbCargo.Text = "";
            tbCargo.Enabled = false; 
        }

        private void dgvLerDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLerDados_Click(object sender, EventArgs e)
        {
            btEditar.Enabled = true;
            btExcluir.Enabled = true;
            btSalvar.Enabled = false;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (tbCargo.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o Nome!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbCargo.Clear();
                tbCargo.Focus();
                return;
            }

            //Código do botão para salvar

            MessageBox.Show("Registro editado com sucesso!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btNovo.Enabled = true;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;

            limparCampos();
            desabilitarCampos();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                //MessageBox.Show("Clicou em Sim!");

                //Código do botao para excluir

                MessageBox.Show("Registro excluído com sucesso!", "REGISTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btNovo.Enabled = true;
                btEditar.Enabled = false;
                btExcluir.Enabled = false;

                limparCampos();
                desabilitarCampos();
            }
        }

        private void frCargos_Load(object sender, EventArgs e)
        {

        }
    }
}
