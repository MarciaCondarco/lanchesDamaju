﻿namespace lanchesDamaju
{
    partial class Cad_Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cad_Produto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxValor = new System.Windows.Forms.MaskedTextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.buttonEscolherFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Produto";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNome.Location = new System.Drawing.Point(123, 167);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(308, 20);
            this.textBoxNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descrição";
            // 
            // richTextBoxDescricao
            // 
            this.richTextBoxDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxDescricao.Location = new System.Drawing.Point(123, 342);
            this.richTextBoxDescricao.Name = "richTextBoxDescricao";
            this.richTextBoxDescricao.Size = new System.Drawing.Size(308, 136);
            this.richTextBoxDescricao.TabIndex = 9;
            this.richTextBoxDescricao.Text = "";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Doces",
            "Salgados",
            "Bebidas"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(123, 288);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(308, 21);
            this.comboBoxCategoria.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(751, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 174);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // maskedTextBoxValor
            // 
            this.maskedTextBoxValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBoxValor.Location = new System.Drawing.Point(123, 226);
            this.maskedTextBoxValor.Mask = "$00.00";
            this.maskedTextBoxValor.Name = "maskedTextBoxValor";
            this.maskedTextBoxValor.Size = new System.Drawing.Size(308, 20);
            this.maskedTextBoxValor.TabIndex = 13;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSalvar.Location = new System.Drawing.Point(805, 445);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(126, 52);
            this.buttonSalvar.TabIndex = 14;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLimpar.Location = new System.Drawing.Point(805, 383);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(126, 52);
            this.buttonLimpar.TabIndex = 15;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVoltar.Location = new System.Drawing.Point(805, 325);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(126, 52);
            this.buttonVoltar.TabIndex = 16;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // buttonEscolherFoto
            // 
            this.buttonEscolherFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEscolherFoto.Location = new System.Drawing.Point(805, 97);
            this.buttonEscolherFoto.Name = "buttonEscolherFoto";
            this.buttonEscolherFoto.Size = new System.Drawing.Size(146, 35);
            this.buttonEscolherFoto.TabIndex = 12;
            this.buttonEscolherFoto.Text = "Escolher Foto";
            this.buttonEscolherFoto.UseVisualStyleBackColor = true;
            this.buttonEscolherFoto.Click += new System.EventHandler(this.buttonEscolherFoto_Click);
            // 
            // Cad_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1131, 618);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.maskedTextBoxValor);
            this.Controls.Add(this.buttonEscolherFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.richTextBoxDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Cad_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cad_Produto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Cad_Produto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxDescricao;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValor;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Button buttonEscolherFoto;
    }
}