using AppModelo.View.Windows.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    /// <summary>
    /// Formulário Principal do sistema com todos formulários de cadastros.
    /// </summary>
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento de Click, após o botão ser clicado o formulário "frmCadastroFuncionario" é exibido. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncionario();
            form.Show();
        }
        /// <summary>
        /// Evento de Click, após o botão ser clicado o formulário "frmNaturalidade" é exibido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void naturalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidade();
            form.Show();
        }
        /// <summary>
        /// Evento de Click, após o botão ser clicado o formulário "frmNacionalidades" é exibido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nacionalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.Show();
        }

        private void cadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
