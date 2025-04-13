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
using System.Data.SqlClient;

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
            using (MySqlConnection conexao = ConexaoBanco.ObterConexao())
                try
                {
                    conexao.Open();
                    string query = "SELECT id, nome,email,nascimento, cep, cpf, telefone FROM tb_pessoa";
                    using (MySqlCommand cmd = new MySqlCommand(query, conexao))
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
                    using (MySqlConnection conexao = ConexaoBanco.ObterConexao())
                       try
                       {
                            conexao.Open();
                            // Primeiro, vamos excluir os registros da tabela tb_usuario que fazem referência ao client
                            string query = "DELETE FROM tb_usuario WHERE id_pessoa = @id_pessoa";
                            using (MySqlCommand cmdExcluirUsuarios = new MySqlCommand(query, conexao))
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

                            using (MySqlCommand cmdExcluirPessoa = new MySqlCommand(excluirPessoa, conexao))
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
