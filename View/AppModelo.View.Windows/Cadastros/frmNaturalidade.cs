using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    /// <summary>
    /// Formulário para cadastro de naturalidades.
    /// </summary>
    public partial class frmNaturalidade : Form
    {
        /// <summary>
        /// Instância de classe NaturalidadeController.  
        /// </summary>
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmNaturalidade()
        {
            InitializeComponent();
            AtualizarDataGrid();
        }
        /// <summary>
        /// Evento de clique para salvar uma naturalidade no banco de dados.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            var temNumero = Helpers.Componentes.ExisteNumeroNoTexto(txtDescricao.Text);

            if (temNumero)
            {
                errorProvider2.SetError(txtDescricao, "Naturalidade geralmente nâo tem número");
                txtDescricao.Focus();
                return;
            }
            errorProvider2.Clear();

            if (String.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                errorProvider2.SetError(txtDescricao, "Digite a naturalidade para salvá-la");
                return;
            }
            else
            {
                var descricaoMaiuscula = txtDescricao.Text.ToUpper();
                var salvou = _naturalidadeController.Cadastrar(descricaoMaiuscula, chkStatus.Checked);
                if (salvou)
                {
                    MessageBox.Show("Naturalidade incluída com sucesso");
                    txtDescricao.Text = string.Empty;                    
                    AtualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("Houve um erro ao salvar no banco de dados");
                }
            }
            limparDados(this);
            errorProvider2.Clear();
        }
        /// <summary>
        /// Método para atualizar uma naturalidade no banco de dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtualizarNaturalidade_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtId.Text))
            {
                errorProvider2.SetError(txtId, "Digite o ID para atualizar");
                return;
            }
            errorProvider2.Clear();

            if (String.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                errorProvider2.SetError(txtDescricao, "Digite a naturalidade para atualizá-la");
                return;
            }
            else
            {
                var descricaoMaiuscula = txtDescricao.Text.ToUpper();
                var atualizou = _naturalidadeController.Atualizar(descricaoMaiuscula, txtId.Text);

                if (atualizou)
                {
                    MessageBox.Show("Naturalidade atualizada com sucesso");
                    txtDescricao.Text = string.Empty;                    
                    AtualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("Houve um erro ao atualizar no banco de dados");
                }
            }
            limparDados(this);
            errorProvider2.Clear();
        }
        /// <summary>
        /// Método para remover uma naturalidade do banco de dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoverNaturalidade_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtId.Text))
                {
                    errorProvider2.SetError(txtId, "Digite o ID para remover a naturalidade");
                    return;
                }
                else
                {
                    var removeu = _naturalidadeController.Remover(txtId.Text);
                    if (removeu)
                    {
                        MessageBox.Show("Naturalidade removida com sucesso");
                        txtId.Text = string.Empty;                        
                        AtualizarDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Houve um erro ao remover no banco de dados");
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("ERRO, verifique se o ID já está vinculado a um funcionário! ");
            }
            limparDados(this);
            errorProvider2.Clear();
        }
        /// <summary>
        /// Método para atualizar DataGridView dos dados de Naturalidades quando inicializado ou alterado.
        /// </summary>
        private void AtualizarDataGrid()
        {
            var listaDeNaturalidades = _naturalidadeController.ObterTodasNaturalidades();
            gvNaturalidades.DataSource = listaDeNaturalidades;
        }
        /// <summary>
        /// Limpa dados digitados nos campos de tipo textbox.
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
