using AppModelo.Controller.Cadastros;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmListaFuncionarios : Form
    {
        public frmListaFuncionarios()
        {
            FuncionarioController _funcionarioController = new FuncionarioController();

            InitializeComponent();
            var listaFuncionarios = _funcionarioController.ObterTodosFuncionarios();
            gvListaFuncionarios.DataSource = listaFuncionarios;
            gerirGrid();
        }
        /// <summary>
        /// Função para identar Data grid view, trazendo apenas as colunas nas quais ele gostaria de mostrar ao usuario 
        /// </summary>
        public void gerirGrid()
        {
            gvListaFuncionarios.Columns[0].HeaderText = "ID";
            gvListaFuncionarios.Columns[1].HeaderText = "nacionalidade";
            gvListaFuncionarios.Columns[2].HeaderText = "naturalidade";
            gvListaFuncionarios.Columns[3].HeaderText = "nome";
            gvListaFuncionarios.Columns[4].HeaderText = "Data de nascimento";
            gvListaFuncionarios.Columns[5].HeaderText = "sexo";
            gvListaFuncionarios.Columns[6].HeaderText = "email";
            gvListaFuncionarios.Columns[7].HeaderText = "telefone";
            gvListaFuncionarios.Columns[8].HeaderText = "telefone_contato";
            gvListaFuncionarios.Columns[9].HeaderText = "cep";
            gvListaFuncionarios.Columns[10].HeaderText = "logradouro";
            gvListaFuncionarios.Columns[11].HeaderText = "numero";
            gvListaFuncionarios.Columns[12].HeaderText = "complemento";
            gvListaFuncionarios.Columns[13].HeaderText = "bairro";
            gvListaFuncionarios.Columns[14].HeaderText = "municipio";
            gvListaFuncionarios.Columns[15].HeaderText = "uf";

            gvListaFuncionarios.Columns[1].Visible = false;
            gvListaFuncionarios.Columns[2].Visible = false;
            gvListaFuncionarios.Columns[5].Visible = false;
            gvListaFuncionarios.Columns[6].Visible = false;
            gvListaFuncionarios.Columns[7].Visible = false;
            gvListaFuncionarios.Columns[8].Visible = false;
            gvListaFuncionarios.Columns[9].Visible = false;
            gvListaFuncionarios.Columns[10].Visible = false;
            gvListaFuncionarios.Columns[11].Visible = false;
            gvListaFuncionarios.Columns[12].Visible = false;
            gvListaFuncionarios.Columns[13].Visible = false;
            gvListaFuncionarios.Columns[14].Visible = false;
            gvListaFuncionarios.Columns[15].Visible = false;
        }
    }
}
