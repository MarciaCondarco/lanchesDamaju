namespace lanchesDamaju
{
    partial class Gerenciamento_Cliente
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
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonRemoverCliente = new System.Windows.Forms.Button();
            this.buttonPesquisarCliente = new System.Windows.Forms.Button();
            this.dataGridViewGerenciamentoCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGerenciamentoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(485, 86);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(111, 41);
            this.buttonVoltar.TabIndex = 9;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonRemoverCliente
            // 
            this.buttonRemoverCliente.Location = new System.Drawing.Point(323, 86);
            this.buttonRemoverCliente.Name = "buttonRemoverCliente";
            this.buttonRemoverCliente.Size = new System.Drawing.Size(111, 41);
            this.buttonRemoverCliente.TabIndex = 8;
            this.buttonRemoverCliente.Text = "Remover Cliente";
            this.buttonRemoverCliente.UseVisualStyleBackColor = true;
            this.buttonRemoverCliente.Click += new System.EventHandler(this.buttonRemoverCliente_Click);
            // 
            // buttonPesquisarCliente
            // 
            this.buttonPesquisarCliente.Location = new System.Drawing.Point(172, 86);
            this.buttonPesquisarCliente.Name = "buttonPesquisarCliente";
            this.buttonPesquisarCliente.Size = new System.Drawing.Size(111, 41);
            this.buttonPesquisarCliente.TabIndex = 7;
            this.buttonPesquisarCliente.Text = "Pesquisar cliente";
            this.buttonPesquisarCliente.UseVisualStyleBackColor = true;
            this.buttonPesquisarCliente.Click += new System.EventHandler(this.buttonPesquisarCliente_Click);
            // 
            // dataGridViewGerenciamentoCliente
            // 
            this.dataGridViewGerenciamentoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGerenciamentoCliente.Location = new System.Drawing.Point(37, 168);
            this.dataGridViewGerenciamentoCliente.Name = "dataGridViewGerenciamentoCliente";
            this.dataGridViewGerenciamentoCliente.Size = new System.Drawing.Size(727, 254);
            this.dataGridViewGerenciamentoCliente.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gerenciamento de Cliente";
            // 
            // Gerenciamento_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonRemoverCliente);
            this.Controls.Add(this.buttonPesquisarCliente);
            this.Controls.Add(this.dataGridViewGerenciamentoCliente);
            this.Controls.Add(this.label1);
            this.Name = "Gerenciamento_Cliente";
            this.Text = "Gerenciamento_Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGerenciamentoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonRemoverCliente;
        private System.Windows.Forms.Button buttonPesquisarCliente;
        private System.Windows.Forms.DataGridView dataGridViewGerenciamentoCliente;
        private System.Windows.Forms.Label label1;
    }
}