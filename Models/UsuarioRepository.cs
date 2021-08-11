using MySqlConnector;
using System;
using System.Collections.Generic;
namespace atividade_II.Models
{
    public class UsuarioRepository
    {
        private const string dadosConexao = "DataBase = atividadeii; Data Source = localhost; User id= root";

    

        public List<Usuario> listar()
        {

            MySqlConnection conexao = new MySqlConnection(dadosConexao);

            conexao.Open();

            String QuerySql = "SELECT * from usuario";

            MySqlCommand comando = new MySqlCommand(QuerySql, conexao);

            MySqlDataReader Reader = comando.ExecuteReader();

            List<Usuario> lista = new List<Usuario>();

            while (Reader.Read())
            {
                int id = Reader.GetInt32("id");
                string nome = Reader.GetString("nome");
                string login = Reader.GetString("login");
                string senha = Reader.GetString("senha");
                DateTime dataNascimento = Reader.GetDateTime("dataNascimento");

                Usuario user = new Usuario(id, nome, login, senha, dataNascimento);


                lista.Add(user);
            }

            conexao.Close();

            return lista;
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

        public void alterar(Usuario user)
        {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);

            conexao.Open();

            String QuerySql = "UPDATE from usuario set nome=@nome, login=@login, senha=@senha, datanascimento=@dataNascimento, Where id=@id";

            MySqlCommand comando = new MySqlCommand(QuerySql, conexao);

            comando.Parameters.AddWithValue("@id", user.Id);
            comando.Parameters.AddWithValue("@nome", user.Nome);
            comando.Parameters.AddWithValue("@login", user.Login);
            comando.Parameters.AddWithValue("@senha", user.Senha);
            comando.Parameters.AddWithValue("@dataNascimento", user.DataNascimento);

            comando.ExecuteNonQuery();


            conexao.Close();

        }

        public void inserir(Usuario user)
        {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);

            conexao.Open();

            String QuerySql = "INSERT INTO usuario (nome, login, senha, datanascimento,)VALUES(@nome,@login,@senha,@dataNascimento)";

            MySqlCommand comando = new MySqlCommand(QuerySql, conexao);

            comando.Parameters.AddWithValue("@id", user.Id);
            comando.Parameters.AddWithValue("@nome", user.Nome);
            comando.Parameters.AddWithValue("@login", user.Login);
            comando.Parameters.AddWithValue("@senha", user.Senha);
            comando.Parameters.AddWithValue("@dataNascimento", user.DataNascimento);

            comando.ExecuteNonQuery();


            conexao.Close();

        }

        public Usuario buscarPorId(int id){

            MySqlConnection conexao = new MySqlConnection(dadosConexao);

            conexao.Open();

            String QuerySql = "SELECT * FROM usuario WHERE id=@id";

            MySqlCommand comando = new MySqlCommand(QuerySql, conexao);

            comando.Parameters.AddWithValue("id", id);

            MySqlDataReader Reader = comando.ExecuteReader(); 

            int id2 = Reader.GetInt32("id");
            string nome = Reader.GetString("nome");
            string login = Reader.GetString("login");
            string senha = Reader.GetString("senha");
            DateTime dataNascimento = Reader.GetDateTime("dataNascimento");

            Usuario usuarioEncontrado = new Usuario(id2, nome, login, senha, dataNascimento);
            conexao.Close();
            

            return usuarioEncontrado;

        }
    }
}