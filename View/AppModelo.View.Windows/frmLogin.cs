using AppModelo.Controller.Seguranca;
using AppModelo.Model.Domain.Validators;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    public partial class frmLogin : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public frmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogar_Click(object sender, EventArgs e)
        {
            var emailEhValido = Validadores.EmailEValido(txtEmail.Text);
            if (emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "Seu e-mail está errado");
                txtEmail.Focus();
                return;
            }

            var controller = new UsuarioController();
            var usuarioEncontrado = controller.EfetuarLogin(txtEmail.Text, txtSenha.Text);
            if (usuarioEncontrado)
            {
                var form = new frmPrincipal();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha não encontrado");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.Show();
        }
    }
}
