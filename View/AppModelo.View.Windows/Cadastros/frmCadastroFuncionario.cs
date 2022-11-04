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
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);
            cmbNacionalidade.DataSource = _nacionalidadeController.ObterTodasNacionalidades();
            cmbNacionalidade.DisplayMember = "Descricao";

            cmbNaturalidade.DataSource = _naturalidadeController.ObterTodasNaturalidades();
            cmbNaturalidade.DisplayMember = "Descricao";
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

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            var controller = new FuncionarioController();
            //var nome = txtNome.Text;
            //var dataNascimento = txtDataNascimento.Text.ToString();
            //var genero = rbFeminino.Checked;
            //var cpf = txtCpf;
            //var email = txtEmail.Text;
            //var telefone = txtTelefone.Text;
            //var telefoneContato = txtTelefoneContato.Text;
            //var cep = txtEnderecoCep.Text;
            //var logradouro = txtEnderecoLogradouro.Text;
            //var numero =txtEnderecoNumero.Text;
            //var complmeento = txtEnderecoComplemento.Text;
            //var bairro = txtEnderecoBairro.Text;
            //var municipio = txtEnderecoMunicipio.Text;
            //var uf = txtEnderecoUf.Text;
            var cadastrarFuncionario = controller.Cadastrar(txtNome.Text, txtDataNascimento.Text, rbFeminino.Checked, txtCpf.Text, txtEmail.Text, txtTelefone.Text, txtTelefoneContato.Text, txtEnderecoCep.Text, txtEnderecoLogradouro.Text, txtEnderecoNumero.Text, txtEnderecoComplemento.Text, txtEnderecoBairro.Text, txtEnderecoMunicipio.Text, txtEnderecoUf.Text);
        }
    }
}
