﻿namespace AppModelo.View.Windows
{
    partial class frmFuncionariosCadastrados
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
            this.gvFuncionariosCadastrados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvFuncionariosCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // gvFuncionariosCadastrados
            // 
            this.gvFuncionariosCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFuncionariosCadastrados.Location = new System.Drawing.Point(12, 12);
            this.gvFuncionariosCadastrados.Name = "gvFuncionariosCadastrados";
            this.gvFuncionariosCadastrados.RowHeadersWidth = 45;
            this.gvFuncionariosCadastrados.Size = new System.Drawing.Size(871, 316);
            this.gvFuncionariosCadastrados.TabIndex = 0;
            // 
            // frmFuncionariosCadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 342);
            this.Controls.Add(this.gvFuncionariosCadastrados);
            this.Name = "frmFuncionariosCadastrados";
            this.Text = "frmFuncionariosCadastrados";
            ((System.ComponentModel.ISupportInitialize)(this.gvFuncionariosCadastrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvFuncionariosCadastrados;
    }
}