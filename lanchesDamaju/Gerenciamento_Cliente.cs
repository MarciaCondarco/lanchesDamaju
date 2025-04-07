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
    public partial class Gerenciamento_Cliente : Form
    {
        public Gerenciamento_Cliente()
        {
            InitializeComponent();
        }

        private void buttonPesquisarCliente_Click(object sender, EventArgs e)
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
                    string listagem = "SELECT id_cliente, nome, senha, email, cep, cpf, numero, telefone FROM tb_cliente";


                    //Cria o comando MySql 
                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {

                        //Executa a consulta e obtém os resultados 
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros 
                        DataTable dadosCliente = new DataTable();
                        dadosCliente.Load(reader);


                        //Atribui a tabela de dados ao DataGridView
                        dataGridViewGerenciamentoCliente.DataSource = dadosCliente;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar os Clientes: " + ex.Message);
            }
        }

        private void buttonRemoverCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewGerenciamentoCliente.SelectedRows.Count > 0)
            {
                //ele pega ID do cliente da linha selecionada
                int clienteID = Convert.ToInt32(dataGridViewGerenciamentoCliente.SelectedRows[0].Cells["id_cliente"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

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
                            string listagem = "DELETE FROM tb_cliente WHERE id_cliente = @id_cliente";

                            using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                            {
                                cmd.Parameters.AddWithValue("id_cliente", clienteID);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cliente excluido com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o Cliente");

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
                    MessageBox.Show("Por favor, selecione um cliente para excluir");
                }

            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void dataGridViewGerenciamentoCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
