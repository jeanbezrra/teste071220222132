using AppModelo.Controller.External;
using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);
        }

        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            //Crio a instancia do controlador
            var cepController = new ViaCepController();
            //REcebo os dados do metodo obter para o endereço
            var endereco = cepController.Obter(txtEnderecoCep.Text);

            txtEnderecoBairro.Text = endereco.Bairro;
            txtEnderecoLogradouro.Text = endereco.Logradouro;
            txtEnderecoMunicipio.Text = endereco.Localidade;
            txtEnderecoUf.Text = endereco.Uf;
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            //primeira regra
            if (txtNome.Text.Length < 6)
            {
                errorProvider.SetError(txtNome, "Digite seu nome completo");
                return;
            }
            //segunda regra verifica se digitou algum numero
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

        private void txtCpf_Validating(object sender, CancelEventArgs e)
        {
            var cpf = txtCpf.Text;
            var cpfEhvalido = Validadores.ValidarCPF(cpf);

            if (cpfEhvalido is false)
            {
                errorProvider.SetError(txtCpf, "CPF Inválido");
                return;
            }
            errorProvider.Clear();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            var email = txtEmail.Text;
            var emailEhvalido = Validadores.EmailEValido(email);

            if (emailEhvalido is false)
            {
                errorProvider.SetError(txtEmail, "E-mail Inválido");
                return;
            }
            errorProvider.Clear();          
        }

        private void txtDataNascimento_Validating(object sender, CancelEventArgs e)
        {
            //pega a data de hoje e acrescenta 1 dia
            
            var dataNascimento = DateTime.Parse(txtDataNascimento.Text);
            var dateTime = (DateTime.Now.AddDays(0));

            if (dataNascimento > dateTime)
            {
                errorProvider.SetError(txtDataNascimento, "Data Inválida");
                return;
            }
            errorProvider.Clear();
        }
    }
}
