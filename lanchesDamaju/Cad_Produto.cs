using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace lanchesDamaju
{
    public partial class Cad_Produto : Form
    {
        public Cad_Produto()
        {
            InitializeComponent();
        }

        private void Cad_Produto_Load(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string conexaoString = "Server=localhost; Port=3306; Database=db_lanchesdamaju; Uid=root; Pwd=;";



            string query = "INSERT INTO tb_produto (nome, valor, descricao, categoria, imagem) VALUES " +
                "(@nome, @valor, @descricao, @categoria, @imagem)";


            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {

                try
                {

                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] imageBytes = ms.ToArray();
                    //Abre a conexão 
                    conexao.Open();
                    //adicinar os parametros com os valores dos textBox
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", textBoxNome.Text);
                        comando.Parameters.AddWithValue("@valor", maskedTextBoxValor.Text);
                        comando.Parameters.AddWithValue("@descricao", comboBoxCategoria.Text);
                        comando.Parameters.AddWithValue("@categoria", richTextBoxDescricao.Text);
                        comando.Parameters.AddWithValue("@imagem",imageBytes);

                        //Executa o comando de inserção

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Dados inseridos com sucesso!");

                        textBoxNome.Text = "";
                        maskedTextBoxValor.Text = "";
                        comboBoxCategoria.Text = "";
                        richTextBoxDescricao.Text = "";
                        pictureBox1.Text = "";

                    }
                    //testedsgh

                }
                catch (Exception ex)
                {
                    //em caso de erro, exiba mensagem do erro 
                    MessageBox.Show("Erro: " + ex.Message);
                }


            }

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            maskedTextBoxValor.Text = "";
            comboBoxCategoria.Text = "";
            richTextBoxDescricao.Text = "";
            pictureBox1.Text = "";
        }

        private void buttonEscolherFoto_Click(object sender, EventArgs e)
        {
            // Cria uma instância do OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Defina o filtro para mostrar apenas arquivos de imagem
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            // Verifica se o usuário selecionou um arquivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Exibe a imagem selecionada no PictureBox
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
