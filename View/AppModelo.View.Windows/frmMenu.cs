using AppModelo.View.Windows.Cadastros;
using System;
using System.Linq;
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
        /// Evento de clique, após o botão ser clicado o formulário "frmCadastroFuncionario" é exibido. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastroFunc_Click(object sender, EventArgs e)
        {                        
            if (Application.OpenForms.OfType<frmCadastroFuncionario>().Count() > 0)
            {
                MessageBox.Show("O formulário já está aberto!");
            }
            else
            {
                frmCadastroFuncionario form = new frmCadastroFuncionario();
                form.MdiParent = this;
                form.Show();          
            }
        }
        /// <summary>
        /// Evento de clique, após o botão ser clicado o formulário "frmListaFuncionarios" é exibido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListaFunc_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmListaFuncionarios>().Count() > 0)
            {
                MessageBox.Show("O formulário já está aberto!");
            }
            else
            {
                frmListaFuncionarios form = new frmListaFuncionarios();
                form.MdiParent = this;
                form.Show();
            }                                    
        }
        /// <summary>
        /// Evento de clique, após o botão ser clicado o formulário "frmNaturalidade" é exibido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNaturalidades_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmNaturalidade>().Count() > 0)
            {
                MessageBox.Show("O formulário já está aberto!");
            }
            else
            {
                frmNaturalidade form = new frmNaturalidade();
                form.MdiParent = this;
                form.Show();
            }
        }
        /// <summary>
        /// Evento de clique, após o botão ser clicado o formulário "frmNacionalidades" é exibido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNacionalidades_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmNacionalidades>().Count() > 0)
            {
                MessageBox.Show("O formulário já está aberto!");
            }
            else
            {
                frmNacionalidades form = new frmNacionalidades();
                form.MdiParent = this;
                form.Show();
            }
        }
        /// <summary>
        /// Evento de clique para fechar formulário.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
