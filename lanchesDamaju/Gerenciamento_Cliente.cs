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
            string connectionString = "Server=srv1438.hstgr.io; Port=3306; Database=u289366797_db_damaju; Uid=u289366797_Damaju; Pwd=Damaju123&; convert zero datetime=True";

            try
            {
                //Cria uma conexão com o banco de dados MySql
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    //Abre a conexão 
                    consulta.Open();

                    //Consulta SQL para selecionar os clientes 
                    string listagem = "SELECT id, nome,email,nascimento, cep, cpf, telefone FROM tb_pessoa";
                        
                        
                        //" id_cliente, nome, senha, email, cep, cpf, numero, telefone FROM tb_cliente";


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
                // Pega o ID do cliente da linha selecionada
                int clienteID = Convert.ToInt32(dataGridViewGerenciamentoCliente.SelectedRows[0].Cells["id"].Value);

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    string connectionString = "Server=srv1438.hstgr.io; Port=3306; Database=u289366797_db_damaju; Uid=u289366797_Damaju; Pwd=Damaju123&;";

                    try
                    {
                        // Cria uma conexão com o banco de dados MySQL
                        using (MySqlConnection consulta = new MySqlConnection(connectionString))
                        {
                            consulta.Open();

                            // Primeiro, vamos excluir os registros da tabela tb_usuario que fazem referência ao cliente
                            string excluirUsuarios = "DELETE FROM tb_usuario WHERE id_pessoa = @id_pessoa";

                            using (MySqlCommand cmdExcluirUsuarios = new MySqlCommand(excluirUsuarios, consulta))
                            {
                                cmdExcluirUsuarios.Parameters.AddWithValue("@id_pessoa", clienteID);
                                int usuarioRowsAffected = cmdExcluirUsuarios.ExecuteNonQuery();

                                // Verifica se algum usuário foi excluído
                                if (usuarioRowsAffected > 0)
                                {
                                    MessageBox.Show("Usuários associados excluídos com sucesso!");
                                }
                            }

                            // Agora, vamos excluir o registro de tb_pessoa
                            string excluirPessoa = "DELETE FROM tb_pessoa WHERE id = @id_pessoa";

                            using (MySqlCommand cmdExcluirPessoa = new MySqlCommand(excluirPessoa, consulta))
                            {
                                cmdExcluirPessoa.Parameters.AddWithValue("@id_pessoa", clienteID);
                                int pessoaRowsAffected = cmdExcluirPessoa.ExecuteNonQuery();

                                if (pessoaRowsAffected > 0)
                                {
                                    MessageBox.Show("Cliente excluído com sucesso!");
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o Cliente.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cliente para excluir");
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
