using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    /// <summary>
    /// Formulário para listagem de funcionários cadastrados.
    /// </summary>
    public partial class frmListaFuncionarios : Form
    {
        /// <summary>
        /// Instacia classe do funcionário controller.
        /// </summary>
        FuncionarioController _funcionarioController = new FuncionarioController();
        /// <summary>
        /// Construtor contendo o método para atualizar e formatar DataGridView
        /// </summary>
        public frmListaFuncionarios()
        {
            InitializeComponent();
            AtualizarDataGrid();
            gerirGrid();
        }
        /// <summary>
        /// Função para formatar Data grid view, trazendo apenas as colunas nas quais são nescessárias a serem mostradas. 
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
        /// <summary>
        /// Evento de clique para remover um funcionário no banco de dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoverFuncionario_Click(object sender, System.EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtId.Text))
            {
                errorProvider1.SetError(txtId, "Digite o ID para remover o funcionário");
                return;
            }
            else
            {
                var removeu = _funcionarioController.Remover(txtId.Text);
                if (removeu)
                {
                    MessageBox.Show("Funcionário removido com Êxito!");
                    txtId.Text = string.Empty;
                    AtualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("Houve um erro ao remover o funcionário");
                    limparDados(this);
                }
            }
            errorProvider1.Clear();        
        }
        /// <summary>
        /// Método para atualizar DataGridView dos dados de funcionários quando inicializado ou removido.
        /// </summary>
        public void AtualizarDataGrid()
        {
            var listaFuncionarios = _funcionarioController.ObterTodosFuncionarios();
            gvListaFuncionarios.DataSource = listaFuncionarios;
        }
        /// <summary>
        /// Limpa campos de tipo textbox do formulário.
        /// </summary>
        /// <param name="ctrl"></param>
        public static void limparDados(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
        }
    }
}
