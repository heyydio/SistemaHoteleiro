using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_CLC
{
    public partial class frLogin : Form
    {
        public frLogin()
        {
            InitializeComponent();
            pnlLogin.Visible = false;
        }

        private void frLogin_Load(object sender, EventArgs e)
        {
            //pnlLogin.Location = new Point(0, 0);
            //pnlLogin.Location = new Point(this.Width/2, this.Height/2);
            //pnlLogin.Location = new Point(this.Width / 2 - 180, this.Height / 2 - 210);
            //pnlLogin.Location = new Point(this.Width / 2 - pnlLogin.BackgroundImage.Size.Width/2, this.Height / 2 - pnlLogin.BackgroundImage.Size.Height/2);
            //btLogin.

            pnlLogin.Visible=true;

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            ChamarLogin();
           

        }

        public void ChamarLogin() {
            if (tbUsuario.Text == "")
            {
                MessageBox.Show("Preencha os campos usuário", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUsuario.Focus();
                return;

            }

            if (tbSenha.Text == "")
            {
                MessageBox.Show("Preencha os campo senha", "CAMPO VAZIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbUsuario.Focus();
                return;

            }

            //AQUI SERÁ O CÓDIGO PARA LOGIN

            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            //this.Hide();
            Limpar();
            frmMenuPrincipal.ShowDialog();
        }

        private void Limpar()
        {
            tbUsuario.Text = "";
            tbSenha.Text = "";
            tbUsuario.Focus();
        }
        private void tbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLogin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void frLogin_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("Tecla pressionada!");

            if (e.KeyCode == Keys.Enter)
            {
                //MessageBox.Show("Tecla Enter");

                ChamarLogin();
            }
        }
    }
}
