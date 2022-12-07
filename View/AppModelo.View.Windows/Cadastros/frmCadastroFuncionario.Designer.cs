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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(101)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 42);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE FUNCIONÁRIOS";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(239, 30);
            this.txtNome.TabIndex = 1;
            this.txtNome.Tag = "Obrigatorio";
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtNome_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome Completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data Nascimento";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(15, 97);
            this.txtCpf.Mask = "###,###,###-##";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(105, 30);
            this.txtCpf.TabIndex = 3;
            this.txtCpf.Tag = "Obrigatorio";
            this.txtCpf.Validating += new System.ComponentModel.CancelEventHandler(this.txtCpf_Validating);
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(279, 30);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(138, 30);
            this.txtDataNascimento.TabIndex = 2;
            this.txtDataNascimento.Tag = "Obrigatorio";
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(146, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 30);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Tag = "Obrigatorio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "E-mail";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(368, 97);
            this.txtTelefone.Mask = "(##) #####-####";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(112, 30);
            this.txtTelefone.TabIndex = 5;
            this.txtTelefone.Tag = "Obrigatorio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "Telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cep";
            // 
            // txtEnderecoLogradouro
            // 
            this.txtEnderecoLogradouro.Enabled = false;
            this.txtEnderecoLogradouro.Location = new System.Drawing.Point(231, 33);
            this.txtEnderecoLogradouro.Name = "txtEnderecoLogradouro";
            this.txtEnderecoLogradouro.Size = new System.Drawing.Size(300, 30);
            this.txtEnderecoLogradouro.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Logradouro";
            // 
            // txtEnderecoNumero
            // 
            this.txtEnderecoNumero.Location = new System.Drawing.Point(15, 159);
            this.txtEnderecoNumero.Name = "txtEnderecoNumero";
            this.txtEnderecoNumero.Size = new System.Drawing.Size(93, 30);
            this.txtEnderecoNumero.TabIndex = 9;
            this.txtEnderecoNumero.Tag = "Obrigatorio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Número";
            // 
            // txtEnderecoBairro
            // 
            this.txtEnderecoBairro.Enabled = false;
            this.txtEnderecoBairro.Location = new System.Drawing.Point(15, 99);
            this.txtEnderecoBairro.Name = "txtEnderecoBairro";
            this.txtEnderecoBairro.Size = new System.Drawing.Size(207, 30);
            this.txtEnderecoBairro.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Bairro";
            // 
            // txtEnderecoMunicipio
            // 
            this.txtEnderecoMunicipio.Enabled = false;
            this.txtEnderecoMunicipio.Location = new System.Drawing.Point(231, 99);
            this.txtEnderecoMunicipio.Name = "txtEnderecoMunicipio";
            this.txtEnderecoMunicipio.Size = new System.Drawing.Size(171, 30);
            this.txtEnderecoMunicipio.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(227, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 23);
            this.label12.TabIndex = 22;
            this.label12.Text = "Município";
            // 
            // txtEnderecoUf
            // 
            this.txtEnderecoUf.Enabled = false;
            this.txtEnderecoUf.Location = new System.Drawing.Point(418, 99);
            this.txtEnderecoUf.Name = "txtEnderecoUf";
            this.txtEnderecoUf.Size = new System.Drawing.Size(93, 30);
            this.txtEnderecoUf.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(414, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 23);
            this.label13.TabIndex = 24;
            this.label13.Text = "UF";
            // 
            // txtEnderecoComplemento
            // 
            this.txtEnderecoComplemento.Location = new System.Drawing.Point(129, 159);
            this.txtEnderecoComplemento.Name = "txtEnderecoComplemento";
            this.txtEnderecoComplemento.Size = new System.Drawing.Size(277, 30);
            this.txtEnderecoComplemento.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(125, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 23);
            this.label14.TabIndex = 26;
            this.label14.Text = "Complemento (opcional)";
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Checked = true;
            this.rbFeminino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFeminino.Location = new System.Drawing.Point(440, 20);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(97, 27);
            this.rbFeminino.TabIndex = 28;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMasculino.Location = new System.Drawing.Point(440, 41);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(105, 27);
            this.rbMasculino.TabIndex = 29;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // cmbNacionalidade
            // 
            this.cmbNacionalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbNacionalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacionalidade.FormattingEnabled = true;
            this.cmbNacionalidade.Location = new System.Drawing.Point(15, 163);
            this.cmbNacionalidade.Name = "cmbNacionalidade";
            this.cmbNacionalidade.Size = new System.Drawing.Size(165, 31);
            this.cmbNacionalidade.TabIndex = 12;
            this.cmbNacionalidade.Tag = "";
            this.cmbNacionalidade.SelectedIndexChanged += new System.EventHandler(this.cmbNacionalidade_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 23);
            this.label15.TabIndex = 31;
            this.label15.Text = "Nacionalidade";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(168, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 23);
            this.label16.TabIndex = 33;
            this.label16.Text = "Naturalidade";
            // 
            // cmbNaturalidade
            // 
            this.cmbNaturalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbNaturalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNaturalidade.FormattingEnabled = true;
            this.cmbNaturalidade.Location = new System.Drawing.Point(186, 163);
            this.cmbNaturalidade.Name = "cmbNaturalidade";
            this.cmbNaturalidade.Size = new System.Drawing.Size(167, 31);
            this.cmbNaturalidade.TabIndex = 13;
            this.cmbNaturalidade.SelectedIndexChanged += new System.EventHandler(this.cmbNaturalidade_SelectedIndexChanged);
            // 
            // txtEnderecoCep
            // 
            this.txtEnderecoCep.Location = new System.Drawing.Point(15, 33);
            this.txtEnderecoCep.Mask = "#####-###";
            this.txtEnderecoCep.Name = "txtEnderecoCep";
            this.txtEnderecoCep.Size = new System.Drawing.Size(100, 30);
            this.txtEnderecoCep.TabIndex = 7;
            this.txtEnderecoCep.Tag = "Obrigatorio";
            // 
            // btnPesquisarCep
            // 
            this.btnPesquisarCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(101)))));
            this.btnPesquisarCep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarCep.FlatAppearance.BorderSize = 0;
            this.btnPesquisarCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCep.ForeColor = System.Drawing.Color.White;
            this.btnPesquisarCep.Location = new System.Drawing.Point(121, 33);
            this.btnPesquisarCep.Name = "btnPesquisarCep";
            this.btnPesquisarCep.Size = new System.Drawing.Size(101, 30);
            this.btnPesquisarCep.TabIndex = 8;
            this.btnPesquisarCep.Text = "Pesquisar";
            this.btnPesquisarCep.UseVisualStyleBackColor = false;
            this.btnPesquisarCep.Click += new System.EventHandler(this.btnPesquisarCep_Click);
            // 
            // txtTelefoneContato
            // 
            this.txtTelefoneContato.Location = new System.Drawing.Point(368, 164);
            this.txtTelefoneContato.Mask = "(##) #####-####";
            this.txtTelefoneContato.Name = "txtTelefoneContato";
            this.txtTelefoneContato.Size = new System.Drawing.Size(136, 30);
            this.txtTelefoneContato.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(362, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 23);
            this.label17.TabIndex = 36;
            this.label17.Text = "Telefone contato";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(436, 1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 23);
            this.label18.TabIndex = 38;
            this.label18.Text = "Sexo";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(101)))));
            this.btnCadastrarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarFuncionario.FlatAppearance.BorderSize = 0;
            this.btnCadastrarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Yu Gothic UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(72, 504);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(439, 42);
            this.btnCadastrarFuncionario.TabIndex = 11;
            this.btnCadastrarFuncionario.Text = "Cadastrar";
            this.btnCadastrarFuncionario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.txtEnderecoNumero);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtEnderecoLogradouro);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.btnPesquisarCep);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtEnderecoCep);
            this.panel2.Controls.Add(this.txtEnderecoBairro);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtEnderecoMunicipio);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtEnderecoUf);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtEnderecoComplemento);
            this.panel2.Location = new System.Drawing.Point(16, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 209);
            this.panel2.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.txtDataNascimento);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtTelefoneContato);
            this.panel3.Controls.Add(this.txtNome);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cmbNaturalidade);
            this.panel3.Controls.Add(this.txtCpf);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cmbNacionalidade);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.rbMasculino);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.rbFeminino);
            this.panel3.Controls.Add(this.txtTelefone);
            this.panel3.Location = new System.Drawing.Point(16, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(546, 218);
            this.panel3.TabIndex = 40;
            // 
            // frmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(576, 557);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Tag = "";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}