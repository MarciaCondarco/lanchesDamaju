namespace lanchesDamaju
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCadProduto = new System.Windows.Forms.Button();
            this.buttonCadCliente = new System.Windows.Forms.Button();
            this.buttonGerenciarProduto = new System.Windows.Forms.Button();
            this.buttonGerenciarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(261, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lanches Damaju";
            // 
            // buttonCadProduto
            // 
            this.buttonCadProduto.Location = new System.Drawing.Point(168, 322);
            this.buttonCadProduto.Name = "buttonCadProduto";
            this.buttonCadProduto.Size = new System.Drawing.Size(195, 73);
            this.buttonCadProduto.TabIndex = 4;
            this.buttonCadProduto.Text = "Cadastrar Produto";
            this.buttonCadProduto.UseVisualStyleBackColor = true;
            this.buttonCadProduto.Click += new System.EventHandler(this.buttonCadProduto_Click);
            // 
            // buttonCadCliente
            // 
            this.buttonCadCliente.Location = new System.Drawing.Point(422, 322);
            this.buttonCadCliente.Name = "buttonCadCliente";
            this.buttonCadCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCadCliente.Size = new System.Drawing.Size(195, 73);
            this.buttonCadCliente.TabIndex = 5;
            this.buttonCadCliente.Text = "Cadastro Cliente";
            this.buttonCadCliente.UseVisualStyleBackColor = true;
            this.buttonCadCliente.Click += new System.EventHandler(this.buttonCadCliente_Click);
            // 
            // buttonGerenciarProduto
            // 
            this.buttonGerenciarProduto.Location = new System.Drawing.Point(168, 414);
            this.buttonGerenciarProduto.Name = "buttonGerenciarProduto";
            this.buttonGerenciarProduto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonGerenciarProduto.Size = new System.Drawing.Size(195, 73);
            this.buttonGerenciarProduto.TabIndex = 6;
            this.buttonGerenciarProduto.Text = "Gerenciar Produto";
            this.buttonGerenciarProduto.UseVisualStyleBackColor = true;
            this.buttonGerenciarProduto.Click += new System.EventHandler(this.buttonGerenciarProduto_Click);
            // 
            // buttonGerenciarCliente
            // 
            this.buttonGerenciarCliente.Location = new System.Drawing.Point(422, 414);
            this.buttonGerenciarCliente.Name = "buttonGerenciarCliente";
            this.buttonGerenciarCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonGerenciarCliente.Size = new System.Drawing.Size(195, 73);
            this.buttonGerenciarCliente.TabIndex = 7;
            this.buttonGerenciarCliente.Text = "Gerenciar Cliente";
            this.buttonGerenciarCliente.UseVisualStyleBackColor = true;
            this.buttonGerenciarCliente.Click += new System.EventHandler(this.buttonGerenciarCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.buttonGerenciarCliente);
            this.Controls.Add(this.buttonGerenciarProduto);
            this.Controls.Add(this.buttonCadCliente);
            this.Controls.Add(this.buttonCadProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCadProduto;
        private System.Windows.Forms.Button buttonCadCliente;
        private System.Windows.Forms.Button buttonGerenciarProduto;
        private System.Windows.Forms.Button buttonGerenciarCliente;
    }
}

