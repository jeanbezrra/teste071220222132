namespace AppModelo.View.Windows.Cadastros
{
    partial class frmNaturalidade
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gvNaturalidades = new System.Windows.Forms.DataGridView();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAtualizarNaturalidade = new System.Windows.Forms.Button();
            this.btnRemoverNaturalidade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvNaturalidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(101)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 30);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 52);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 20);
            this.txtId.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(15, 94);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(281, 20);
            this.txtDescricao.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(388, 92);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // gvNaturalidades
            // 
            this.gvNaturalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvNaturalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNaturalidades.Location = new System.Drawing.Point(12, 136);
            this.gvNaturalidades.Name = "gvNaturalidades";
            this.gvNaturalidades.RowHeadersWidth = 45;
            this.gvNaturalidades.Size = new System.Drawing.Size(448, 160);
            this.gvNaturalidades.TabIndex = 13;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Checked = true;
            this.chkStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkStatus.Location = new System.Drawing.Point(320, 98);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(50, 17);
            this.chkStatus.TabIndex = 14;
            this.chkStatus.Text = "Ativo";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnAtualizarNaturalidade
            // 
            this.btnAtualizarNaturalidade.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAtualizarNaturalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarNaturalidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarNaturalidade.Location = new System.Drawing.Point(295, 316);
            this.btnAtualizarNaturalidade.Name = "btnAtualizarNaturalidade";
            this.btnAtualizarNaturalidade.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarNaturalidade.TabIndex = 16;
            this.btnAtualizarNaturalidade.Text = "Atualizar";
            this.btnAtualizarNaturalidade.UseVisualStyleBackColor = false;
            this.btnAtualizarNaturalidade.Click += new System.EventHandler(this.btnAtualizarNaturalidade_Click);
            // 
            // btnRemoverNaturalidade
            // 
            this.btnRemoverNaturalidade.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoverNaturalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverNaturalidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverNaturalidade.Location = new System.Drawing.Point(388, 316);
            this.btnRemoverNaturalidade.Name = "btnRemoverNaturalidade";
            this.btnRemoverNaturalidade.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverNaturalidade.TabIndex = 15;
            this.btnRemoverNaturalidade.Text = "Remover";
            this.btnRemoverNaturalidade.UseVisualStyleBackColor = false;
            this.btnRemoverNaturalidade.Click += new System.EventHandler(this.btnRemoverNaturalidade_Click);
            // 
            // frmNaturalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(478, 359);
            this.Controls.Add(this.btnAtualizarNaturalidade);
            this.Controls.Add(this.btnRemoverNaturalidade);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.gvNaturalidades);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmNaturalidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Naturalidades";
            ((System.ComponentModel.ISupportInitialize)(this.gvNaturalidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView gvNaturalidades;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnAtualizarNaturalidade;
        private System.Windows.Forms.Button btnRemoverNaturalidade;
    }
}