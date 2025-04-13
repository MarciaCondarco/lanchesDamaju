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
            using (MySqlConnection conexao = ConexaoBanco.ObterConexao())

                try
                    {
                    conexao.Open();
                    //Abre a conexão

                    string query = "SELECT * FROM tb_produtos";
                    //Consulta SQL para selecionar os clientes

                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                    //Cria o comando MySql
                    {

                        //Cria o comando MySql 
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

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
                int produtoID = Convert.ToInt32(dataGridViewGerenciamentoProduto.SelectedRows[0].Cells["id_produtos"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conexao = ConexaoBanco.ObterConexao())

                        try
                        {
                            conexao.Open();
                            //Abre a conexão

                            string query = "DELETE FROM tb_produtos WHERE id_produtos = @id_produtos";
                            //Consulta SQL para selecionar os clientes

                            using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                            //Cria o comando MySql

                            {
                                cmd.Parameters.AddWithValue("id_produtos", produtoID);

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

        private void dataGridViewGerenciamentoProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
