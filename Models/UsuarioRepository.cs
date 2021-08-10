using MySqlConnector;
using System;
namespace atividade_II.Models
{
    public class UsuarioRepository
    {
        private const string dadosConexao = "DataBase = atividadeii; Data Source = localhost; User id= root";

        public void testarConexao()
        {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);


            conexao.Open();

            Console.WriteLine("Conexão iniciada");


            conexao.Close();
        }

        public void excluir(Usuario user)
        {

            MySqlConnection conexao = new MySqlConnection(dadosConexao);

            conexao.Open();

            String QuerySql = "DELETE from usuario WHERE id=@id";

            MySqlCommand comando = new MySqlCommand(QuerySql, conexao);

            comando.Parameters.AddWithValue("@id", user.Id);

            comando.ExecuteNonQuery();


            conexao.Close();

        }

    }
}