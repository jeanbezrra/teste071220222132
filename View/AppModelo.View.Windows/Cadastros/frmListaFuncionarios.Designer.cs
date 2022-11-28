namespace AppModelo.View.Windows.Cadastros
{
    partial class frmListaFuncionarios
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
            this.gvListaFuncionarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListaFuncionarios
            // 
            this.gvListaFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListaFuncionarios.Location = new System.Drawing.Point(0, 28);
            this.gvListaFuncionarios.Name = "gvListaFuncionarios";
            this.gvListaFuncionarios.RowHeadersWidth = 45;
            this.gvListaFuncionarios.Size = new System.Drawing.Size(450, 284);
            this.gvListaFuncionarios.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(101)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 30);
            this.panel1.TabIndex = 8;
            // 
            // frmListaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(450, 307);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gvListaFuncionarios);
            this.MaximizeBox = false;
            this.Name = "frmListaFuncionarios";
            this.Text = "Lista de Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.gvListaFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvListaFuncionarios;
        private System.Windows.Forms.Panel panel1;
    }
}