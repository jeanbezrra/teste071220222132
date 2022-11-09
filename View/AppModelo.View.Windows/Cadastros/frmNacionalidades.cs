using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmNacionalidades : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        public frmNacionalidades()
        {
            InitializeComponent();

            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }
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
                }
                errorProvider1.Clear();

                var salvou = _nacionalidadeController.Cadastrar(txtDescricao.Text);
                if (salvou)
                {
                    MessageBox.Show("Nacionalidade incluída com sucesso");
                    txtDescricao.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Houve um erro ao salvar no banco de dados");
                }
            }
            this.Close();
        }

        private void btnAtualizarNacionalidade_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                errorProvider1.SetError(txtDescricao, "Digite a nacionalidade para atualizá-la");
                return;
            }
            else
            {
                //if (String.IsNullOrWhiteSpace(txtId.Text))

                //int id = int.Parse(txtId.Text);

                var atualizou = _nacionalidadeController.Atualizar(txtDescricao.Text, txtId.Text);
                if (atualizou)
                {
                    MessageBox.Show("Nacionalidade atualizada com sucesso");
                    txtDescricao.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Houve um erro ao atualizar no banco de dados");
                }

            }
            this.Close();
        }

        private void btnRemoverNacionalidade_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                errorProvider1.SetError(txtDescricao, "Digite a nacionalidade para removê-la");
                return;
            }
            else
            {
                var removeu = _nacionalidadeController.Remover(txtDescricao.Text);
                if (removeu)
                {
                    MessageBox.Show("Nacionalidade removida com sucesso");
                    txtDescricao.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Houve um erro ao remover no banco de dados");
                }
            }
            this.Close();
        }
    }
}
