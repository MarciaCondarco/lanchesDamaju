namespace lanchesDamaju
{
    partial class Gerenciamento_Produto
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewGerenciamentoProduto = new System.Windows.Forms.DataGridView();
            this.buttonPesquisarProduto = new System.Windows.Forms.Button();
            this.buttonRemoverProduto = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGerenciamentoProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciamento de Produto";
            // 
            // dataGridViewGerenciamentoProduto
            // 
            this.dataGridViewGerenciamentoProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewGerenciamentoProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewGerenciamentoProduto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewGerenciamentoProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGerenciamentoProduto.Location = new System.Drawing.Point(94, 144);
            this.dataGridViewGerenciamentoProduto.Name = "dataGridViewGerenciamentoProduto";
            this.dataGridViewGerenciamentoProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewGerenciamentoProduto.Size = new System.Drawing.Size(887, 407);
            this.dataGridViewGerenciamentoProduto.TabIndex = 1;
            this.dataGridViewGerenciamentoProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGerenciamentoProduto_CellContentClick);
            // 
            // buttonPesquisarProduto
            // 
            this.buttonPesquisarProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPesquisarProduto.Location = new System.Drawing.Point(249, 94);
            this.buttonPesquisarProduto.Name = "buttonPesquisarProduto";
            this.buttonPesquisarProduto.Size = new System.Drawing.Size(111, 41);
            this.buttonPesquisarProduto.TabIndex = 2;
            this.buttonPesquisarProduto.Text = "Pesquisar produto";
            this.buttonPesquisarProduto.UseVisualStyleBackColor = true;
            this.buttonPesquisarProduto.Click += new System.EventHandler(this.buttonPesquisarProduto_Click);
            // 
            // buttonRemoverProduto
            // 
            this.buttonRemoverProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRemoverProduto.Location = new System.Drawing.Point(477, 94);
            this.buttonRemoverProduto.Name = "buttonRemoverProduto";
            this.buttonRemoverProduto.Size = new System.Drawing.Size(111, 41);
            this.buttonRemoverProduto.TabIndex = 3;
            this.buttonRemoverProduto.Text = "Remover Produto";
            this.buttonRemoverProduto.UseVisualStyleBackColor = true;
            this.buttonRemoverProduto.Click += new System.EventHandler(this.buttonRemoverProduto_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVoltar.Location = new System.Drawing.Point(717, 94);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(111, 41);
            this.buttonVoltar.TabIndex = 4;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // Gerenciamento_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1122, 594);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonRemoverProduto);
            this.Controls.Add(this.buttonPesquisarProduto);
            this.Controls.Add(this.dataGridViewGerenciamentoProduto);
            this.Controls.Add(this.label1);
            this.Name = "Gerenciamento_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento_Produto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGerenciamentoProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewGerenciamentoProduto;
        private System.Windows.Forms.Button buttonPesquisarProduto;
        private System.Windows.Forms.Button buttonRemoverProduto;
        private System.Windows.Forms.Button buttonVoltar;
    }
}