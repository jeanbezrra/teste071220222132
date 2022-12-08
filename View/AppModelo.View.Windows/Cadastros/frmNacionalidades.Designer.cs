namespace AppModelo.View.Windows.Cadastros
{
    partial class frmNacionalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNacionalidades));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gvNacionalidades = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemoverNacionalidade = new System.Windows.Forms.Button();
            this.btnAtualizarNacionalidade = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvNacionalidades)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 57);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(42, 21);
            this.txtId.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(15, 99);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(197, 21);
            this.txtDescricao.TabIndex = 3;
            // 
            // gvNacionalidades
            // 
            this.gvNacionalidades.BackgroundColor = System.Drawing.Color.Gray;
            this.gvNacionalidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvNacionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNacionalidades.Location = new System.Drawing.Point(15, 131);
            this.gvNacionalidades.Name = "gvNacionalidades";
            this.gvNacionalidades.RowHeadersWidth = 45;
            this.gvNacionalidades.Size = new System.Drawing.Size(301, 122);
            this.gvNacionalidades.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(243, 95);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(73, 30);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(101)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 35);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lista de nacionalidades";
            // 
            // btnRemoverNacionalidade
            // 
            this.btnRemoverNacionalidade.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoverNacionalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverNacionalidade.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemoverNacionalidade.FlatAppearance.BorderSize = 0;
            this.btnRemoverNacionalidade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRemoverNacionalidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(18)))), ((int)(((byte)(0)))));
            this.btnRemoverNacionalidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverNacionalidade.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Bold);
            this.btnRemoverNacionalidade.ForeColor = System.Drawing.Color.White;
            this.btnRemoverNacionalidade.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverNacionalidade.Image")));
            this.btnRemoverNacionalidade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverNacionalidade.Location = new System.Drawing.Point(229, 268);
            this.btnRemoverNacionalidade.Name = "btnRemoverNacionalidade";
            this.btnRemoverNacionalidade.Size = new System.Drawing.Size(86, 30);
            this.btnRemoverNacionalidade.TabIndex = 7;
            this.btnRemoverNacionalidade.Text = "Remover";
            this.btnRemoverNacionalidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverNacionalidade.UseVisualStyleBackColor = false;
            this.btnRemoverNacionalidade.Click += new System.EventHandler(this.btnRemoverNacionalidade_Click);
            // 
            // btnAtualizarNacionalidade
            // 
            this.btnAtualizarNacionalidade.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizarNacionalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarNacionalidade.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtualizarNacionalidade.FlatAppearance.BorderSize = 0;
            this.btnAtualizarNacionalidade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAtualizarNacionalidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(208)))), ((int)(((byte)(0)))));
            this.btnAtualizarNacionalidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarNacionalidade.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Bold);
            this.btnAtualizarNacionalidade.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarNacionalidade.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizarNacionalidade.Image")));
            this.btnAtualizarNacionalidade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizarNacionalidade.Location = new System.Drawing.Point(123, 268);
            this.btnAtualizarNacionalidade.Name = "btnAtualizarNacionalidade";
            this.btnAtualizarNacionalidade.Size = new System.Drawing.Size(89, 30);
            this.btnAtualizarNacionalidade.TabIndex = 8;
            this.btnAtualizarNacionalidade.Text = "Atualizar";
            this.btnAtualizarNacionalidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizarNacionalidade.UseVisualStyleBackColor = false;
            this.btnAtualizarNacionalidade.Click += new System.EventHandler(this.btnAtualizarNacionalidade_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmNacionalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(332, 312);
            this.Controls.Add(this.btnAtualizarNacionalidade);
            this.Controls.Add(this.btnRemoverNacionalidade);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gvNacionalidades);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmNacionalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.gvNacionalidades)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridView gvNacionalidades;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemoverNacionalidade;
        private System.Windows.Forms.Button btnAtualizarNacionalidade;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
    }
}