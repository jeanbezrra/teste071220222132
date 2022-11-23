using AppModelo.Controller.Cadastros;
using AppModelo.Controller.External;
using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Helpers;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmCadastroFuncionario : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        private FuncionarioController _funcionarioController = new FuncionarioController();
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
        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            //primeira regra nome < que 6 letras
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
                    errorProvider
                        .SetError(txtNome, "Seu nome parece estar errado");
                    return;
                }
            }
            errorProvider.Clear();
        }
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

        private void cmbNaturalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obterIndexNaturalidade = cmbNaturalidade.SelectedValue;
            string Index = cmbNaturalidade.Text;
        }
        private void cmbNacionalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            var obterNacionalidade = cmbNacionalidade.SelectedValue;
            string Index = cmbNacionalidade.Text;
        }
        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtEnderecoNumero.Text);

            var validou = Helpers.Componentes.ValidarCamposObrigatorios(txtNome.Text, txtDataNascimento.Text, txtCpf.Text, txtEmail.Text, txtTelefone.Text, numero);
            if (validou)
            {
                btnCadastrarFuncionario.Enabled = false;
            }
            else { 

                btnCadastrarFuncionario.Enabled = true;
                var dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);            

                int obterNaturalidade = Convert.ToInt32(cmbNaturalidade.SelectedValue);
                int obterNacionalidade = Convert.ToInt32(cmbNacionalidade.SelectedValue);

                var salvou = _funcionarioController.Cadastrar(obterNaturalidade, obterNacionalidade, txtNome.Text, dataNascimento, rbFeminino.Checked, txtCpf.Text, txtEmail.Text, txtTelefone.Text, txtTelefoneContato.Text, txtEnderecoCep.Text, txtEnderecoLogradouro.Text, numero, txtEnderecoComplemento.Text, txtEnderecoBairro.Text, txtEnderecoMunicipio.Text, txtEnderecoUf.Text);
                if (salvou)
                {
                    MessageBox.Show("Cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuário");
                }
            }
            Componentes.LimparDadosForm(this);
        }
    }
}
