namespace AppModelo.View.Windows.Cadastros
{
    partial class frmCadastroFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEnderecoLogradouro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEnderecoNumero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEnderecoBairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEnderecoMunicipio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEnderecoUf = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEnderecoComplemento = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.cmbNacionalidade = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbNaturalidade = new System.Windows.Forms.ComboBox();
            this.txtEnderecoCep = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisarCep = new System.Windows.Forms.Button();
            this.txtTelefoneContato = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 88);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE FUNCIONÁRIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(14, 130);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(62, 27);
            this.txtId.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(113, 130);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(207, 27);
            this.txtNome.TabIndex = 4;
            this.txtNome.Tag = "Obrigatorio";
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data Nascimento";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(617, 130);
            this.txtCpf.Mask = "###,###,###-##";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(129, 27);
            this.txtCpf.TabIndex = 8;
            this.txtCpf.Tag = "Obrigatorio";
            this.txtCpf.Validating += new System.ComponentModel.CancelEventHandler(this.txtCpf_Validating);
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(339, 130);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(123, 27);
            this.txtDataNascimento.TabIndex = 9;
            this.txtDataNascimento.Tag = "Obrigatorio";
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(14, 259);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 27);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Tag = "Obrigatorio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "E-mail";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(253, 259);
            this.txtTelefone.Mask = "(##) #####-####";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(129, 27);
            this.txtTelefone.TabIndex = 13;
            this.txtTelefone.Tag = "Obrigatorio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cep";
            // 
            // txtEnderecoLogradouro
            // 
            this.txtEnderecoLogradouro.Enabled = false;
            this.txtEnderecoLogradouro.Location = new System.Drawing.Point(14, 388);
            this.txtEnderecoLogradouro.Name = "txtEnderecoLogradouro";
            this.txtEnderecoLogradouro.Size = new System.Drawing.Size(300, 27);
            this.txtEnderecoLogradouro.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Logradouro";
            // 
            // txtEnderecoNumero
            // 
            this.txtEnderecoNumero.Location = new System.Drawing.Point(353, 388);
            this.txtEnderecoNumero.Name = "txtEnderecoNumero";
            this.txtEnderecoNumero.Size = new System.Drawing.Size(93, 27);
            this.txtEnderecoNumero.TabIndex = 19;
            this.txtEnderecoNumero.Tag = "Obrigatorio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(349, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Numero";
            // 
            // txtEnderecoBairro
            // 
            this.txtEnderecoBairro.Enabled = false;
            this.txtEnderecoBairro.Location = new System.Drawing.Point(14, 454);
            this.txtEnderecoBairro.Name = "txtEnderecoBairro";
            this.txtEnderecoBairro.Size = new System.Drawing.Size(230, 27);
            this.txtEnderecoBairro.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Bairro";
            // 
            // txtEnderecoMunicipio
            // 
            this.txtEnderecoMunicipio.Enabled = false;
            this.txtEnderecoMunicipio.Location = new System.Drawing.Point(275, 454);
            this.txtEnderecoMunicipio.Name = "txtEnderecoMunicipio";
            this.txtEnderecoMunicipio.Size = new System.Drawing.Size(171, 27);
            this.txtEnderecoMunicipio.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(271, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Município";
            // 
            // txtEnderecoUf
            // 
            this.txtEnderecoUf.Enabled = false;
            this.txtEnderecoUf.Location = new System.Drawing.Point(469, 454);
            this.txtEnderecoUf.Name = "txtEnderecoUf";
            this.txtEnderecoUf.Size = new System.Drawing.Size(93, 27);
            this.txtEnderecoUf.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(465, 431);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "UF";
            // 
            // txtEnderecoComplemento
            // 
            this.txtEnderecoComplemento.Location = new System.Drawing.Point(469, 388);
            this.txtEnderecoComplemento.Name = "txtEnderecoComplemento";
            this.txtEnderecoComplemento.Size = new System.Drawing.Size(277, 27);
            this.txtEnderecoComplemento.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(465, 365);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Complemento (opcional)";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Checked = true;
            this.rbFeminino.Location = new System.Drawing.Point(503, 127);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(87, 24);
            this.rbFeminino.TabIndex = 28;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(503, 146);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(94, 24);
            this.rbMasculino.TabIndex = 29;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // cmbNacionalidade
            // 
            this.cmbNacionalidade.FormattingEnabled = true;
            this.cmbNacionalidade.Location = new System.Drawing.Point(14, 193);
            this.cmbNacionalidade.Name = "cmbNacionalidade";
            this.cmbNacionalidade.Size = new System.Drawing.Size(140, 28);
            this.cmbNacionalidade.TabIndex = 30;
            this.cmbNacionalidade.Tag = "Obrigatorio";
            this.cmbNacionalidade.SelectedIndexChanged += new System.EventHandler(this.cmbNacionalidade_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Nacionalidade";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(176, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 20);
            this.label16.TabIndex = 33;
            this.label16.Text = "Naturalidade";
            // 
            // cmbNaturalidade
            // 
            this.cmbNaturalidade.FormattingEnabled = true;
            this.cmbNaturalidade.Location = new System.Drawing.Point(180, 193);
            this.cmbNaturalidade.Name = "cmbNaturalidade";
            this.cmbNaturalidade.Size = new System.Drawing.Size(140, 28);
            this.cmbNaturalidade.TabIndex = 32;
            this.cmbNaturalidade.SelectedIndexChanged += new System.EventHandler(this.cmbNaturalidade_SelectedIndexChanged);
            // 
            // txtEnderecoCep
            // 
            this.txtEnderecoCep.Location = new System.Drawing.Point(14, 322);
            this.txtEnderecoCep.Mask = "#####-###";
            this.txtEnderecoCep.Name = "txtEnderecoCep";
            this.txtEnderecoCep.Size = new System.Drawing.Size(100, 27);
            this.txtEnderecoCep.TabIndex = 34;
            this.txtEnderecoCep.Tag = "Obrigatorio";
            // 
            // btnPesquisarCep
            // 
            this.btnPesquisarCep.BackColor = System.Drawing.Color.Chocolate;
            this.btnPesquisarCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCep.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarCep.Location = new System.Drawing.Point(120, 322);
            this.btnPesquisarCep.Name = "btnPesquisarCep";
            this.btnPesquisarCep.Size = new System.Drawing.Size(101, 30);
            this.btnPesquisarCep.TabIndex = 35;
            this.btnPesquisarCep.Text = "Pesquisar";
            this.btnPesquisarCep.UseVisualStyleBackColor = false;
            this.btnPesquisarCep.Click += new System.EventHandler(this.btnPesquisarCep_Click);
            // 
            // txtTelefoneContato
            // 
            this.txtTelefoneContato.Location = new System.Drawing.Point(417, 259);
            this.txtTelefoneContato.Mask = "(##) #####-####";
            this.txtTelefoneContato.Name = "txtTelefoneContato";
            this.txtTelefoneContato.Size = new System.Drawing.Size(129, 27);
            this.txtTelefoneContato.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(413, 236);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 20);
            this.label17.TabIndex = 36;
            this.label17.Text = "Telefone contato";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(499, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 20);
            this.label18.TabIndex = 38;
            this.label18.Text = "Sexo";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.BackColor = System.Drawing.Color.Chocolate;
            this.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Yu Gothic UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(161, 507);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(439, 42);
            this.btnCadastrarFuncionario.TabIndex = 39;
            this.btnCadastrarFuncionario.Text = "Cadastrar";
            this.btnCadastrarFuncionario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // frmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 571);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtTelefoneContato);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnPesquisarCep);
            this.Controls.Add(this.txtEnderecoCep);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbNaturalidade);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbNacionalidade);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.rbFeminino);
            this.Controls.Add(this.txtEnderecoComplemento);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtEnderecoUf);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtEnderecoMunicipio);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtEnderecoBairro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEnderecoNumero);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEnderecoLogradouro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadastroFuncionario";
            this.Tag = "";
            this.Text = "frmCadastroFuncionario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEnderecoLogradouro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEnderecoNumero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEnderecoBairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEnderecoMunicipio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEnderecoUf;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEnderecoComplemento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.ComboBox cmbNacionalidade;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbNaturalidade;
        private System.Windows.Forms.MaskedTextBox txtEnderecoCep;
        private System.Windows.Forms.Button btnPesquisarCep;
        private System.Windows.Forms.MaskedTextBox txtTelefoneContato;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
    }
}