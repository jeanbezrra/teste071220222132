﻿namespace AppModelo.View.Windows.Cadastros
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.gvNacionalidades = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoverNacionalidade = new System.Windows.Forms.Button();
            this.btnAtualizarNacionalidade = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvNacionalidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 52);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(15, 94);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(197, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // gvNacionalidades
            // 
            this.gvNacionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNacionalidades.Location = new System.Drawing.Point(15, 131);
            this.gvNacionalidades.Name = "gvNacionalidades";
            this.gvNacionalidades.RowHeadersWidth = 45;
            this.gvNacionalidades.Size = new System.Drawing.Size(301, 122);
            this.gvNacionalidades.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(241, 92);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(101)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 30);
            this.panel1.TabIndex = 6;
            // 
            // btnRemoverNacionalidade
            // 
            this.btnRemoverNacionalidade.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoverNacionalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverNacionalidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverNacionalidade.ForeColor = System.Drawing.Color.Black;
            this.btnRemoverNacionalidade.Location = new System.Drawing.Point(241, 268);
            this.btnRemoverNacionalidade.Name = "btnRemoverNacionalidade";
            this.btnRemoverNacionalidade.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverNacionalidade.TabIndex = 7;
            this.btnRemoverNacionalidade.Text = "Remover";
            this.btnRemoverNacionalidade.UseVisualStyleBackColor = false;
            this.btnRemoverNacionalidade.Click += new System.EventHandler(this.btnRemoverNacionalidade_Click);
            // 
            // btnAtualizarNacionalidade
            // 
            this.btnAtualizarNacionalidade.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAtualizarNacionalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarNacionalidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarNacionalidade.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizarNacionalidade.Location = new System.Drawing.Point(138, 268);
            this.btnAtualizarNacionalidade.Name = "btnAtualizarNacionalidade";
            this.btnAtualizarNacionalidade.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarNacionalidade.TabIndex = 8;
            this.btnAtualizarNacionalidade.Text = "Atualizar";
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
            this.ClientSize = new System.Drawing.Size(333, 303);
            this.Controls.Add(this.btnAtualizarNacionalidade);
            this.Controls.Add(this.btnRemoverNacionalidade);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gvNacionalidades);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmNacionalidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Nacionalidades";
            ((System.ComponentModel.ISupportInitialize)(this.gvNacionalidades)).EndInit();
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
    }
}