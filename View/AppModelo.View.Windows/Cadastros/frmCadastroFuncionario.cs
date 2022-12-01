using AppModelo.Controller.Cadastros;
using AppModelo.Controller.External;
using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Helpers;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    /// <summary>
    /// Formulário para cadastrar funcionários.
    /// </summary>
    public partial class frmCadastroFuncionario : Form
    {
        /// <summary>
        /// Instância das classes controllers de nacionalidade, naturalidade e funcionário.
        /// </summary>
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        private FuncionarioController _funcionarioController = new FuncionarioController();
        /// <summary>
        /// Construtor do formulário.
        /// </summary>
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);

            cmbNacionalidade.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            cmbNacionalidade.DisplayMember = "Descricao";
            cmbNacionalidade.ValueMember = "Id";

            cmbNaturalidade.DataSource = _naturalidadeController.ObterTodasNaturalidades();
            cmbNaturalidade.DisplayMember = "Descricao";
            cmbNaturalidade.ValueMember = "Id";
        }
        /// <summary>
        /// Botão de pesquisar o cep digitado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //Crio a instancia do Controllador
            var cepController = new ViaCepController();

            //Recebo os dados do metodo obter para o endereço
            var endereco = cepController.Obter(txtEnderecoCep.Text);

            txtEnderecoBairro.Text = endereco.Bairro;
            txtEnderecoLogradouro.Text = endereco.Logradouro;
            txtEnderecoMunicipio.Text = endereco.Localidade;
            txtEnderecoUf.Text = endereco.Uf;
        }
        /// <summary>
        /// Validação do nome digitado. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (txtNome.Text.Length < 6)
            {
                errorProvider.SetError(txtNome, "Digite seu nome completo");
                return;
            }
            //verifica se digitou algum numero
            foreach (var letra in txtNome.Text)
            {
                if (char.IsNumber(letra))
                {
                    errorProvider.SetError(txtNome, "Seu nome parece estar errado");
                    return;
                }
            }
            errorProvider.Clear();
        }
        /// <summary>
        /// Validação do cpf digitado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            var cpf = txtCpf.Text;
            var cpfEhValido = Validadores.ValidarCPF(cpf);
            if (cpfEhValido is false)
            {
                errorProvider.SetError(txtCpf, "CPF Inválido");
                return;
            }
            errorProvider.Clear();
        }
        /// <summary>
        /// Seleção da naturalidade.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNaturalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obterIndexNaturalidade = cmbNaturalidade.SelectedValue;
            string Index = cmbNaturalidade.Text;
        }
        /// <summary>
        /// Seleção da nacionalidade.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNacionalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obterNacionalidade = cmbNacionalidade.SelectedValue;
            string Index = cmbNacionalidade.Text;
        }
        /// <summary>
        /// Botão para cadastro de funcionários.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            try {
                int numero = int.Parse(txtEnderecoNumero.Text);
                var dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                int obterNaturalidade = Convert.ToInt32(cmbNaturalidade.SelectedValue);
                int obterNacionalidade = Convert.ToInt32(cmbNacionalidade.SelectedValue);

                var salvou = _funcionarioController.Cadastrar(obterNaturalidade, obterNacionalidade, txtNome.Text, dataNascimento, rbFeminino.Checked, txtCpf.Text, txtEmail.Text, txtTelefone.Text, txtTelefoneContato.Text, txtEnderecoCep.Text, txtEnderecoLogradouro.Text, numero, txtEnderecoComplemento.Text, txtEnderecoBairro.Text, txtEnderecoMunicipio.Text, txtEnderecoUf.Text);
                
                MessageBox.Show("Salvo com sucesso");

                Componentes.LimparDadosForm(this);
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro! Verifique se todos os campos obrigatórios estão preenchidos corretamente. " + err.Message);
            }
        }
    }
}
