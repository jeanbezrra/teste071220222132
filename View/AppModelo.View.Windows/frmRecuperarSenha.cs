using AppModelo.Controller.Seguranca;
using AppModelo.Model.Domain.Validators;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    /// <summary>
    /// Formulário de recuperação de senha.
    /// </summary>
    public partial class frmRecuperarSenha : Form
    {
        public frmRecuperarSenha()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento de Click para recuperação de senha, quando o botão é clicado, através da classe "Validadores" o email passa pela validadção se
        /// estiver incorreto é gerado um ErrorProvider. Caso seja válido o método "RecuperarSenha" é iniciado enviando um mensagem para
        /// o email informado, e uma MessageBox de sucesso é exibida.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {
            var emailEhValido = Validadores.EmailEValido(txtEmail.Text);
            if (emailEhValido is false)
            {
                errorProvider1.SetError(txtEmail, "Seu e-mail está errado");
                txtEmail.Focus();     
                return;
            }
            var controller = new UsuarioController();
            var resultado = controller.RecuperarSenha(txtEmail.Text);
            MessageBox.Show(resultado);
        }
        /// <summary>
        /// Evento de Click para cancelar a recuperação da senha, quando o botão é clicado o formulario frmRecuperarSenha é fechado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
