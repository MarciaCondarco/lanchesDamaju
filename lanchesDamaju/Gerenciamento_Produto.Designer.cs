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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciamento de Produto";
            // 
            // dataGridViewGerenciamentoProduto
            // 
            this.dataGridViewGerenciamentoProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewGerenciamentoProduto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewGerenciamentoProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGerenciamentoProduto.Location = new System.Drawing.Point(52, 122);
            this.dataGridViewGerenciamentoProduto.Name = "dataGridViewGerenciamentoProduto";
            this.dataGridViewGerenciamentoProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewGerenciamentoProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewGerenciamentoProduto.Size = new System.Drawing.Size(989, 407);
            this.dataGridViewGerenciamentoProduto.TabIndex = 1;
            // 
            // buttonPesquisarProduto
            // 
            this.buttonPesquisarProduto.Location = new System.Drawing.Point(159, 75);
            this.buttonPesquisarProduto.Name = "buttonPesquisarProduto";
            this.buttonPesquisarProduto.Size = new System.Drawing.Size(111, 41);
            this.buttonPesquisarProduto.TabIndex = 2;
            this.buttonPesquisarProduto.Text = "Pesquisar produto";
            this.buttonPesquisarProduto.UseVisualStyleBackColor = true;
            this.buttonPesquisarProduto.Click += new System.EventHandler(this.buttonPesquisarProduto_Click);
            // 
            // buttonRemoverProduto
            // 
            this.buttonRemoverProduto.Location = new System.Drawing.Point(310, 75);
            this.buttonRemoverProduto.Name = "buttonRemoverProduto";
            this.buttonRemoverProduto.Size = new System.Drawing.Size(111, 41);
            this.buttonRemoverProduto.TabIndex = 3;
            this.buttonRemoverProduto.Text = "Remover Produto";
            this.buttonRemoverProduto.UseVisualStyleBackColor = true;
            this.buttonRemoverProduto.Click += new System.EventHandler(this.buttonRemoverProduto_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(464, 75);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(111, 41);
            this.buttonVoltar.TabIndex = 4;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            // 
            // Gerenciamento_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 531);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonRemoverProduto);
            this.Controls.Add(this.buttonPesquisarProduto);
            this.Controls.Add(this.dataGridViewGerenciamentoProduto);
            this.Controls.Add(this.label1);
            this.Name = "Gerenciamento_Produto";
            this.Text = "Gerenciamento_Produto";
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