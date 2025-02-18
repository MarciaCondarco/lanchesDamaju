using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lanchesDamaju
{
    public partial class Gerenciamento_Produto : Form
    {
        public Gerenciamento_Produto()
        {
            InitializeComponent();
        }

        private void buttonPesquisarProduto_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; Port=3306; Database=db_lanchesdamaju; Uid=root; Pwd=;";

            try
            {
                //Cria uma conexão com o banco de dados MySql
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    //Abre a conexão 
                    consulta.Open();

                    //Consulta SQL para selecionar os clientes 
                    string listagem = "SELECT * FROM tb_produto";


                    //Cria o comando MySql 
                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {

                        //Executa a consulta e obtém os resultados 
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros 
                        DataTable dadosProduto = new DataTable();
                        dadosProduto.Load(reader);


                        //Atribui a tabela de dados ao DataGridView
                        dataGridViewGerenciamentoProduto.DataSource = dadosProduto;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os produtos: " + ex.Message);
            }
        }

        private void buttonRemoverProduto_Click(object sender, EventArgs e)
        {
            if (dataGridViewGerenciamentoProduto.SelectedRows.Count > 0)
            {
                //ele pega ID do cliente da linha selecionada
                int produtoID = Convert.ToInt32(dataGridViewGerenciamentoProduto.SelectedRows[0].Cells["id_produto"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=localhost; Port=3306; Database=db_lanchesdamaju; Uid=root; Pwd=;";

                    try
                    {
                        //Cria uma conexão com o banco de dados MySql
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            //Abre a conexão 
                            consulta.Open();

                            //Consulta SQL para selecionar os clientes 
                            string listagem = "DELETE FROM tb_produto WHERE id_produto = @id_produto";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("id_produto", produtoID);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Produto excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o produto");

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, selecione um produto para excluir");
                }

            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
