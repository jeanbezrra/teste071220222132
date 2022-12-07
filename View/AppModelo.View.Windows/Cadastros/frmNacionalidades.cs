using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    /// <summary>
    /// Formulário para cadastro de nacionalidades.
    /// </summary>
    public partial class frmNacionalidades : Form
    {
        /// <summary>
        /// Instância de classe NacionalidadeController. 
        /// </summary>
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        public frmNacionalidades()
        {
            InitializeComponent();

            AtualizarDataGrid();
        }
        /// <summary>
        /// Evento de clique para salvar uma nacionalidade no banco de dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                errorProvider1.SetError(txtDescricao, "Digite a nacionalidade para salvá-la");
                return;
            }
            else
            {
                foreach (var letra in txtDescricao.Text)
                {
                    if (char.IsNumber(letra))
                    {
                        errorProvider1.SetError(txtDescricao, "A nacionalidade parece estar errada");
                        return;
                    }
                    errorProvider1.Clear();
                }
                errorProvider1.Clear();
                var descricaoMaiuscula = txtDescricao.Text.ToUpper();
                var salvou = _nacionalidadeController.Cadastrar(descricaoMaiuscula);
                if (salvou)
                {
                    MessageBox.Show("Nacionalidade incluída com sucesso");
                    txtDescricao.Text = string.Empty;
                    AtualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("Houve um erro ao salvar no banco de dados");
                }
            }
            limparDados(this);
            errorProvider1.Clear();
        }
        /// <summary>
        /// Método para atualizar uma nacionalidade no banco de dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtualizarNacionalidade_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtId.Text))
            {
                errorProvider1.SetError(txtId, "Digite o ID para atualizar");
                return;
            }
            errorProvider1.Clear();
            if (String.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                errorProvider1.SetError(txtDescricao, "Digite a nacionalidade para atualizá-la");
                return;
            }
            else
            {
                var descricaoMaiuscula = txtDescricao.Text.ToUpper();
                var atualizou = _nacionalidadeController.Atualizar(descricaoMaiuscula, txtId.Text);
                if (atualizou)
                {
                    MessageBox.Show("Nacionalidade atualizada com sucesso");
                    txtDescricao.Text = string.Empty;
                    AtualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("Houve um erro ao atualizar no banco de dados");                   
                }
            }
            limparDados(this);
            errorProvider1.Clear();
        }
        /// <summary>
        /// Método para remover uma nacionalidade do banco de dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoverNacionalidade_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtId.Text))
                {
                    errorProvider1.SetError(txtId, "Digite o ID para remover a nacionalidade");
                    return;
                }
                else
                {
                    var removeu = _nacionalidadeController.Remover(txtId.Text);

                    if (removeu)
                    {
                        MessageBox.Show("Nacionalidade removida com sucesso");
                        txtId.Text = string.Empty;
                        AtualizarDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Houve um erro ao remover no banco de dados");
                    }
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("ERRO, verifique se o ID já está vinculado a um funcionario! ");
            }
            limparDados(this);
            errorProvider1.Clear();
        }
        /// <summary>
        /// Método para atualizar DataGridView dos dados de Nacionalidades quando inicializado ou alterado.
        /// </summary>
        private void AtualizarDataGrid()
        {
            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }
        /// <summary>
        /// Limpa dados digitados nos campos de textbox.
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
