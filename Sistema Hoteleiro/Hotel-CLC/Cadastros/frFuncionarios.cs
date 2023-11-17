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
    public partial class frFuncionarios : Form
    {
        public frFuncionarios()
        {
            InitializeComponent();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (tbNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o Nome!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNome.Clear();
                tbNome.Focus();
                return;
            }

            if (mtbCPF.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbCPF.Clear();
                mtbCPF.Focus();
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

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (tbNome.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o Nome!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNome.Clear();
                tbNome.Focus();
                return;
            }

            if (mtbCPF.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF!", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbCPF.Clear();
                mtbCPF.Focus();
                return;
            }

            //Código do botão para salvar

            MessageBox.Show("Registro salvo com sucesso!", "REGISTRO SALVO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btNovo.Enabled = true;
            btSalvar.Enabled = false;

            limparCampos();
            desabilitarCampos();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();

            btSalvar.Enabled = true;

            tbNome.Focus();

            btNovo.Enabled = true;
            btEditar.Enabled = false;
            btExcluir.Enabled = false;
        }

        private void frFuncionarios_Load(object sender, EventArgs e)
        {
            rbBuscarNome.Checked = true;
        }

        private void habilitarCampos()
        {
            tbNome.Enabled = true;
            mtbCPF.Enabled = true;
            tbEndereco.Enabled = true;
            cbCargo.Enabled = true;
            mtbTelefone.Enabled = true;
            tbNome.Focus();
        }

        private void desabilitarCampos()
        {
            tbNome.Enabled = false;
            mtbCPF.Enabled = false;
            tbEndereco.Enabled = false;
            cbCargo.Enabled = false;
            mtbTelefone.Enabled = false;
        }

        private void limparCampos() { 
            tbNome.Clear();
            mtbCPF.Clear();
            tbEndereco.Clear();
            mtbTelefone.Clear();
        }

        private void rbBuscarNome_CheckedChanged(object sender, EventArgs e)
        {
            tbBuscarNome.Visible = true;
            mtbBuscarCPF.Visible = false;

            tbBuscarNome.Clear();
            tbBuscarNome.Focus();
            mtbBuscarCPF.Clear();
        }

        private void rbBuscarCPF_CheckedChanged(object sender, EventArgs e)
        {
            tbBuscarNome.Visible = false;
            mtbBuscarCPF.Visible = true;

            tbBuscarNome.Clear();
            mtbBuscarCPF.Focus();
            mtbBuscarCPF.Clear();
        }

        private void dgvLerDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btEditar.Enabled = true;
            btExcluir.Enabled = true;
            btSalvar.Enabled = false;
        }
    }
}
