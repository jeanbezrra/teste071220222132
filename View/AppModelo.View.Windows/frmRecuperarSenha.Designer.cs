namespace AppModelo.View.Windows
{
    partial class frmRecuperarSenha
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
            this.btnCancelarRecupSenha = new System.Windows.Forms.Button();
            this.btnEmailRecuperarSenha = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelarRecupSenha
            // 
            this.btnCancelarRecupSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.btnCancelarRecupSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarRecupSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarRecupSenha.ForeColor = System.Drawing.Color.White;
            this.btnCancelarRecupSenha.Location = new System.Drawing.Point(28, 175);
            this.btnCancelarRecupSenha.Name = "btnCancelarRecupSenha";
            this.btnCancelarRecupSenha.Size = new System.Drawing.Size(251, 23);
            this.btnCancelarRecupSenha.TabIndex = 7;
            this.btnCancelarRecupSenha.Text = "CANCELAR";
            this.btnCancelarRecupSenha.UseVisualStyleBackColor = false;
            this.btnCancelarRecupSenha.Click += new System.EventHandler(this.btnCancelarRecupSenha_Click);
            // 
            // btnEmailRecuperarSenha
            // 
            this.btnEmailRecuperarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmailRecuperarSenha.Location = new System.Drawing.Point(28, 136);
            this.btnEmailRecuperarSenha.Name = "btnEmailRecuperarSenha";
            this.btnEmailRecuperarSenha.Size = new System.Drawing.Size(251, 23);
            this.btnEmailRecuperarSenha.TabIndex = 6;
            this.btnEmailRecuperarSenha.Text = "RECUPERAR ACESSO";
            this.btnEmailRecuperarSenha.UseVisualStyleBackColor = true;
            this.btnEmailRecuperarSenha.Click += new System.EventHandler(this.btnEmailRecuperarSenha_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(67, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recuperar senha";
            // 
            // frmRecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(306, 228);
            this.Controls.Add(this.btnCancelarRecupSenha);
            this.Controls.Add(this.btnEmailRecuperarSenha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmRecuperarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecuperarSenha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarRecupSenha;
        private System.Windows.Forms.Button btnEmailRecuperarSenha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}