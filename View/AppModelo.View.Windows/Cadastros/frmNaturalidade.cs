using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmNaturalidade : Form
    {
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmNaturalidade()
        {
            InitializeComponent();
            var listaDeNaturalidades = _naturalidadeController.ObterTodasNaturalidades();
            gvNaturalidades.DataSource = listaDeNaturalidades;
        }
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            var salvou = _naturalidadeController.Cadastrar(txtDescricao.Text);
            if (salvou)
            {
                MessageBox.Show("Naturalidade incluída com sucesso");
                txtDescricao.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao salvar no banco de dados");

            }
        }
        private void chkAtivo_CheckedChanged(object sender, EventArgs e)
        {
            var ativo = _naturalidadeController.Cadastrar(chkAtivo.Checked);
            if (chkAtivo.Checked == true) 
            {
                
            }
        }
    }
}
