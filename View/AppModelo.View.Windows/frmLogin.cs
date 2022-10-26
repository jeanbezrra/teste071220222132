using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblRecuperarSenha_Click(object sender, EventArgs e)
        {
            var form = new frmRecuperarSenha();
            form.ShowDialog();
        }

        private void btnEntrarMDI_Click(object sender, EventArgs e)
        {
            var email = txtEmailLogin.Text;
            var emailValido = Validadores.EmailEValido(email);
            if (emailValido is false)
            {
                errorProvider1.SetError(txtEmailLogin, "Email Inválido");
                return;
            }
            errorProvider1.Clear();
            var form = new frmPrincipal();
            form.Show();
            this.Hide();
        }

        private void lblSuporteEContato_Click(object sender, EventArgs e)
        {

        }
    }
}
