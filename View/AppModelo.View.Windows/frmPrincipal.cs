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
    /// <summary>
    /// 
    /// </summary>
    public partial class frmPrincipal : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public frmPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCadastroFuncionario();
            form.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void naturalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNaturalidade();
            form.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nacionalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmNacionalidades();
            form.Show();
        }
    }
}
