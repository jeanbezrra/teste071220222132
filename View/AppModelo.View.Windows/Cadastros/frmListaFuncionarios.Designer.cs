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
            ((System.ComponentModel.ISupportInitialize)(this.gvListaFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListaFuncionarios
            // 
            this.gvListaFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListaFuncionarios.Location = new System.Drawing.Point(2, -3);
            this.gvListaFuncionarios.Name = "gvListaFuncionarios";
            this.gvListaFuncionarios.Size = new System.Drawing.Size(450, 279);
            this.gvListaFuncionarios.TabIndex = 0;
            // 
            // frmListaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 277);
            this.Controls.Add(this.gvListaFuncionarios);
            this.Name = "frmListaFuncionarios";
            this.Text = "frmListaFuncionarios";
            ((System.ComponentModel.ISupportInitialize)(this.gvListaFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvListaFuncionarios;
    }
}