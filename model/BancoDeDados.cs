using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMetasBeta.Model
{
    class BancoDeDados
    {
        //Conexão com o banco de dados (teste).
        private string _conexao = "server=localhost;database=mymetasdb;uid=root;pwd=;";

        //Metodo para executar SELECTS e retornar tabelas de dados.
        public DataTable ExecutarConsultas(string sql)
        {
            //DataTable é um objeto que armazena os dados em formato de tabela com linhas e colunas.
            //Isso mantém os dados organizados após trazaer do banco.
            DataTable tabela = new DataTable();

            try
            {
                //Criando e abrindo a conexão com o banco de dados. 
                //OBS: usin é uma palavra reservada que garante que o objeto (Conexão e comandos) será fechado mesmo se der erro.
                using (MySqlConnection minhaConexao = new MySqlConnection(_conexao))
                {
                    minhaConexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(sql, minhaConexao))
                    {
                        //Preencher a tabela com os resultados
                        //MySqlDataAdapter serve para transportar os dados do banco para o DataTable.
                        //Com o Fill você preenche as tabelas e com o Update Atualiza o banco com as mudanças feitas no DataTable
                        MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                        adapter.Fill(tabela);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar o banco: " + ex.Message);
            }

            return tabela;
        }

        //Metodos para executas INSERT, UPDATE e DELETE.
        public int ExecutarComando(string sql)
        {
            int linhasAfetadas = 0;

            try
            {
                //Criando e abrindo conexão com o banco de dados.
                using (MySqlConnection minhaConexao = new MySqlConnection(_conexao))
                {
                    minhaConexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(sql, minhaConexao))
                    {
                        // O ExecuteNonQuery retorna o número de linhas afetadas.
                        linhasAfetadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar comando: " + ex.Message);
            }
            finally
            {

            }

            return linhasAfetadas;
        }

    }
}
