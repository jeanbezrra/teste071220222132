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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNaturalidade));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNaturalidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(101)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 35);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Lista de naturalidades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 60);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(40, 20);
            this.txtId.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(15, 102);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(281, 20);
            this.txtDescricao.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(376, 100);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 31);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // gvNaturalidades
            // 
            this.gvNaturalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvNaturalidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.chkStatus.Location = new System.Drawing.Point(320, 106);
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
            this.btnAtualizarNaturalidade.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizarNaturalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarNaturalidade.FlatAppearance.BorderSize = 0;
            this.btnAtualizarNaturalidade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtualizarNaturalidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnAtualizarNaturalidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarNaturalidade.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Bold);
            this.btnAtualizarNaturalidade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtualizarNaturalidade.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizarNaturalidade.Image")));
            this.btnAtualizarNaturalidade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarNaturalidade.Location = new System.Drawing.Point(251, 316);
            this.btnAtualizarNaturalidade.Name = "btnAtualizarNaturalidade";
            this.btnAtualizarNaturalidade.Size = new System.Drawing.Size(100, 31);
            this.btnAtualizarNaturalidade.TabIndex = 16;
            this.btnAtualizarNaturalidade.Text = "Atualizar";
            this.btnAtualizarNaturalidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizarNaturalidade.UseVisualStyleBackColor = false;
            this.btnAtualizarNaturalidade.Click += new System.EventHandler(this.btnAtualizarNaturalidade_Click);
            // 
            // btnRemoverNaturalidade
            // 
            this.btnRemoverNaturalidade.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoverNaturalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverNaturalidade.FlatAppearance.BorderSize = 0;
            this.btnRemoverNaturalidade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoverNaturalidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRemoverNaturalidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverNaturalidade.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Bold);
            this.btnRemoverNaturalidade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoverNaturalidade.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverNaturalidade.Image")));
            this.btnRemoverNaturalidade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverNaturalidade.Location = new System.Drawing.Point(368, 316);
            this.btnRemoverNaturalidade.Name = "btnRemoverNaturalidade";
            this.btnRemoverNaturalidade.Size = new System.Drawing.Size(92, 31);
            this.btnRemoverNaturalidade.TabIndex = 15;
            this.btnRemoverNaturalidade.Text = "Remover";
            this.btnRemoverNaturalidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverNaturalidade.UseVisualStyleBackColor = false;
            this.btnRemoverNaturalidade.Click += new System.EventHandler(this.btnRemoverNaturalidade_Click);
            // 
            // frmNaturalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
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
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmNaturalidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmNaturalidade_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label3;
    }
}