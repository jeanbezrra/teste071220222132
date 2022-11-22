using AppModelo.Controller.Cadastros;
using System.Windows.Forms;

namespace AppModelo.View.Windows
{
    // dois pontos = herança do form
    public partial class frmFuncionariosCadastrados : Form
    {
        private FuncionarioController _funcionarioController = new FuncionarioController();
        public frmFuncionariosCadastrados()
        {
            InitializeComponent();
            var listaFuncionarios = _funcionarioController.ObterTodosFuncionarios();
            gvFuncionariosCadastrados.DataSource = listaFuncionarios;
        }
    }
}
