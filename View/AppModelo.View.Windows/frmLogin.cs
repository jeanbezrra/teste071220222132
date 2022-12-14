using AppModelo.Controller.Seguranca;
using AppModelo.Model.Domain.Validators;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    /// <summary>
    /// Formulário login para entrar no programa.
    /// </summary>
    public partial class frmLogin : Form
    {       
        public frmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento de clique do botão para logar no programa, onde é validado no banco de dados seu email e senha,
        /// caso seja válido o frmPrincipal é exibido. Através da classe "Validadores" o email passa pela validadção se 
        /// estiver incorreto é gerado um ErrorProvider, o mesmo acontece caso o usuario não esteja cadastrado, 
        /// más agora gerando uma MessageBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogar_Click(object sender, EventArgs e)
        {
            var emailEhValido = Validadores.EmailEValido(txtEmail.Text);
            if (emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "Digite um e-mail válido");
                txtEmail.Focus();
                return;
            }

            var controller = new UsuarioController();
            var usuarioEncontrado = controller.EfetuarLogin(txtEmail.Text, txtSenha.Text);
            if (usuarioEncontrado)
            {
                var form = new frmMenu();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha não encontrado");
            }
        }
        /// <summary>
        /// Evento de clique para recuperação de senha, após o clique o formulário "frmRecuperarSenha" é exbido.
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
