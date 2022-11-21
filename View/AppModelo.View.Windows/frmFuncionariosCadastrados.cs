using AppModelo.Controller.Cadastros;
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
    public partial class frmFuncionariosCadastrados : Form
    {
        private FuncionarioController _funcionarioController = new FuncionarioController();
        public frmFuncionariosCadastrados()
        {
            InitializeComponent();
            ExibirCadastroFuncionarios();
        }
        private void ExibirCadastroFuncionarios()
        {
            var listaFuncionarios = _funcionarioController.ObterTodosFuncionarios();
            gvFuncionariosCadastrados.DataSource = listaFuncionarios;
        }
    }
}
