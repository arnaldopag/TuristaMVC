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


    }
}