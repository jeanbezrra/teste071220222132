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
            this.components = new System.ComponentModel.Container();
            this.gvListaFuncionarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnRemoverFuncionario = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvListaFuncionarios
            // 
            this.gvListaFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvListaFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListaFuncionarios.Location = new System.Drawing.Point(0, 28);
            this.gvListaFuncionarios.Name = "gvListaFuncionarios";
            this.gvListaFuncionarios.RowHeadersWidth = 45;
            this.gvListaFuncionarios.Size = new System.Drawing.Size(449, 284);
            this.gvListaFuncionarios.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(101)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 30);
            this.panel1.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(11, 342);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(48, 20);
            this.txtId.TabIndex = 9;
            // 
            // btnRemoverFuncionario
            // 
            this.btnRemoverFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoverFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnRemoverFuncionario.Location = new System.Drawing.Point(85, 339);
            this.btnRemoverFuncionario.Name = "btnRemoverFuncionario";
            this.btnRemoverFuncionario.Size = new System.Drawing.Size(105, 24);
            this.btnRemoverFuncionario.TabIndex = 10;
            this.btnRemoverFuncionario.Text = "Remover";
            this.btnRemoverFuncionario.UseVisualStyleBackColor = false;
            this.btnRemoverFuncionario.Click += new System.EventHandler(this.btnRemoverFuncionario_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(11, 324);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "Id";
            // 
            // frmListaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(101)))));
            this.ClientSize = new System.Drawing.Size(449, 391);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnRemoverFuncionario);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gvListaFuncionarios);
            this.MaximizeBox = false;
            this.Name = "frmListaFuncionarios";
            this.Text = "Lista de Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.gvListaFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvListaFuncionarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnRemoverFuncionario;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblId;
    }
}