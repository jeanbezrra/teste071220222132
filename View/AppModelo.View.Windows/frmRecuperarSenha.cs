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
    public partial class frmRecuperarSenha : Form
    {
        public frmRecuperarSenha()
        {
            InitializeComponent();
        }

        private void btnEmailRecuperarSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Senha recuperada com sucesso, verifique seu email");
            Close();
        }

        private void btnCancelarRecupSenha_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
