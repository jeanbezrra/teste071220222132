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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento de Click, após o botão ser clicado o formulário "frmCadastroFuncionario" é exibido. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastroFunc_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncionario();
            form.MdiParent = this;
            form.Show();
        }
        /// <summary>
        /// Evento de Click, após o botão ser clicado o formulário "frmListaFuncionarios" é exibido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListaFunc_Click(object sender, EventArgs e)
        {
            var form = new frmListaFuncionarios();
            form.MdiParent = this;
            form.Show();
        }
        /// <summary>
        /// Evento de Click, após o botão ser clicado o formulário "frmNaturalidade" é exibido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNaturalidades_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidade();
            form.MdiParent = this;
            form.Show();
        }
        /// <summary>
        /// Evento de Click, após o botão ser clicado o formulário "frmNacionalidades" é exibido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNacionalidades_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.MdiParent = this;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
