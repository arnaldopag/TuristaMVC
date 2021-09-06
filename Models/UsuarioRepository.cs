using System.Collections.Generic;
using MySqlConnector;
using System;

namespace atividade_II.Models
{
    public class UsuarioRepository
    {
        private const string DadosConexao = "Database=atividadeii;Data Source=localhost;User Id=root";



        public Usuario ValidarLogin(Usuario user)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();

            String QuerySql = "select * from Usuario WHERE Login=@Login and Senha=@Senha";

            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);


            Comando.Parameters.AddWithValue("@Login", user.Login);
            Comando.Parameters.AddWithValue("@Senha", user.Senha);


            MySqlDataReader Reader = Comando.ExecuteReader();

            Usuario UsuarioEncontrado = null;


            if (Reader.Read())
            {


                UsuarioEncontrado = new Usuario();
                UsuarioEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    UsuarioEncontrado.Login = Reader.GetString("Login");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");

                UsuarioEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
            }

            Conexao.Close();
            return UsuarioEncontrado;
        }


        public Usuario BuscarPorId(int Id)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();


            String QuerySql = "select * from Usuario WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            Comando.Parameters.AddWithValue("@Id", Id);

            MySqlDataReader Reader = Comando.ExecuteReader();

            var UsuarioEncontrado = new Usuario();

            if (Reader.Read())
            {

                UsuarioEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    UsuarioEncontrado.Nome = Reader.GetString("Nome");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    UsuarioEncontrado.Login = Reader.GetString("Login");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    UsuarioEncontrado.Senha = Reader.GetString("Senha");

                UsuarioEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");
            }


            Conexao.Close();

            return UsuarioEncontrado;

        }

        public List<Usuario> Listar()
        {


            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();


            String QuerySql = "select * from Usuario";


            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            MySqlDataReader Reader = Comando.ExecuteReader();

            List<Usuario> Lista = new List<Usuario>();


            while (Reader.Read())
            {

                Usuario userEncontrado = new Usuario();

                userEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    userEncontrado.Nome = Reader.GetString("Nome");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Login")))
                    userEncontrado.Login = Reader.GetString("Login");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Senha")))
                    userEncontrado.Senha = Reader.GetString("Senha");

                userEncontrado.DataNascimento = Reader.GetDateTime("DataNascimento");


                Lista.Add(userEncontrado);
            }

            Conexao.Close();

            return Lista;

        }

        public void Inserir(Usuario user)
        {


            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();


            String QuerySql = "insert into Usuario (Nome,Login,Senha,DataNascimento) values (@Nome,@Login,@Senha,@DataNascimento)";


            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);


            Comando.Parameters.AddWithValue("@Nome", user.Nome);
            Comando.Parameters.AddWithValue("@Login", user.Login);
            Comando.Parameters.AddWithValue("@Senha", user.Senha);
            Comando.Parameters.AddWithValue("@DataNascimento", user.DataNascimento);


            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public void Alterar(Usuario user)
        {


            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();


            String QuerySql = "update Usuario set Nome=@Nome, Login=@Login, Senha=@Senha, DataNascimento=@DataNascimento WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            Comando.Parameters.AddWithValue("@Id", user.Id);
            Comando.Parameters.AddWithValue("@Nome", user.Nome);
            Comando.Parameters.AddWithValue("@Login", user.Login);
            Comando.Parameters.AddWithValue("@Senha", user.Senha);
            Comando.Parameters.AddWithValue("@DataNascimento", user.DataNascimento);


            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public void Excluir(Usuario user)
        {


            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();


            String QuerySql = "delete from Usuario WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);


            Comando.Parameters.AddWithValue("@Id", user.Id);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

    }
}