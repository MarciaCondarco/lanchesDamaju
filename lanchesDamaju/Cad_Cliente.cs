using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lanchesDamaju
{
    public partial class Cad_Cliente : Form
    {
        public Cad_Cliente()
        {
            InitializeComponent();
        }

        private bool ValidarCpf(string cpf)
        {
            // Remove qualquer caractere não numérico
            cpf = Regex.Replace(cpf, @"[^\d]", "");

            // Verifica se tem 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verifica se o CPF é uma sequência de números iguais (ex.: 111.111.111-11)
            if (new string(cpf[0], 11) == cpf)
                return false;

            // Calculando o primeiro dígito verificador
            int soma = 0;
            int peso = 10;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * peso--;
            }

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;
            if (digito1 != int.Parse(cpf[9].ToString()))
                return false;

            // Calculando o segundo dígito verificador
            soma = 0;
            peso = 11;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * peso--;
            }

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;
            return digito2 == int.Parse(cpf[10].ToString());
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string conexaoString = "Server=srv1438.hstgr.io; Port=3306; Database=u289366797_db_damaju; Uid=u289366797_Damaju; Pwd=Damaju123&;";



            string query = "INSERT INTO tb_cliente (nome, senha, email, cep, cpf,numero,telefone,imagem) VALUES " +
                "(@nome, @senha, @email, @cep, @cpf, @numero, @telefone, @imagem)";


            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {

                try
                {

                    MemoryStream ms = new MemoryStream();
                    pictureBoxImagem.Image.Save(ms, pictureBoxImagem.Image.RawFormat);
                    byte[] imageBytes = ms.ToArray();
                    //Abre a conexão 
                    conexao.Open();
                    //adicinar os parametros com os valores dos textBox
                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", textBoxNome.Text);
                        comando.Parameters.AddWithValue("@senha", textBoxSenha.Text);
                        comando.Parameters.AddWithValue("@email", textBoxEmail.Text);
                        comando.Parameters.AddWithValue("@cep", maskedTextBoxcep.Text);
                        comando.Parameters.AddWithValue("@cpf", maskedTextBoxcpf.Text);
                        comando.Parameters.AddWithValue("@numero", maskedTextBoxNumero.Text);
                        comando.Parameters.AddWithValue("@telefone", maskedTextBoxTelefone.Text);
                        comando.Parameters.AddWithValue("@imagem",imageBytes);

                        //Executa o comando de inserção

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Dados inseridos com sucesso!");

                        textBoxNome.Text = "";
                        textBoxSenha.Text = "";
                        textBoxEmail.Text = "";
                        maskedTextBoxcep.Text = "";
                        maskedTextBoxcpf.Text = "";
                        maskedTextBoxNumero.Text = "";
                        maskedTextBoxTelefone.Text = "";
                        pictureBoxImagem.Text = "";

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
            textBoxSenha.Text = "";
            textBoxEmail.Text = "";
            maskedTextBoxcep.Text = "";
            maskedTextBoxcpf.Text = "";
            maskedTextBoxNumero.Text = "";
            maskedTextBoxTelefone.Text = "";
            pictureBoxImagem.Text = "";
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
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
                pictureBoxImagem.Image = Image.FromFile(openFileDialog.FileName);

                pictureBoxImagem.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    
    }
}
