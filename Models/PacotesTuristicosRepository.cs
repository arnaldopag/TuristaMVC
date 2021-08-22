using System.Collections.Generic;
using MySqlConnector;
using System;

namespace atividade_II.Models
{
    public class PacotesTuristicosRepository
    {
        private const string DadosConexao = "Database = atividadeii; Data Source=localhost ; User = root";


        public PacotesTuristicos BuscarPorId(int Id)
        {

            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();


            String QuerySql = "select * from pacotesturisticos WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            Comando.Parameters.AddWithValue("@Id", Id);

            MySqlDataReader Reader = Comando.ExecuteReader();

            PacotesTuristicos PacoteEncontrado = new PacotesTuristicos();

            if (Reader.Read())
            {

                PacoteEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    PacoteEncontrado.Nome = Reader.GetString("Nome");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Origem")))
                    PacoteEncontrado.Origem = Reader.GetString("Origem");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Destino")))
                    PacoteEncontrado.Origem = Reader.GetString("Destino");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Atrativos")))
                    PacoteEncontrado.Atrativos = Reader.GetString("Atrativos");

                PacoteEncontrado.Saida = Reader.GetDateTime("Saida");
                PacoteEncontrado.Retorno = Reader.GetDateTime("Retorno");
            }


            Conexao.Close();

            return PacoteEncontrado;

        }

        public List<PacotesTuristicos> Listar()
        {


            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();


            String QuerySql = "select * from pacotesturisticos";


            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);

            MySqlDataReader Reader = Comando.ExecuteReader();

            List<PacotesTuristicos> Lista = new List<PacotesTuristicos>();


            while (Reader.Read())
            {

                PacotesTuristicos PacoteEncontrado = new PacotesTuristicos();

                PacoteEncontrado.Id = Reader.GetInt32("Id");

                if (!Reader.IsDBNull(Reader.GetOrdinal("Nome")))
                    PacoteEncontrado.Nome = Reader.GetString("Nome");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Origem")))
                    PacoteEncontrado.Origem = Reader.GetString("Origem");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Destino")))
                    PacoteEncontrado.Origem = Reader.GetString("Destino");
                if (!Reader.IsDBNull(Reader.GetOrdinal("Atrativos")))
                    PacoteEncontrado.Atrativos = Reader.GetString("Atrativos");

                PacoteEncontrado.Saida = Reader.GetDateTime("Saida");
                PacoteEncontrado.Retorno = Reader.GetDateTime("Retorno");

                Lista.Add(PacoteEncontrado);
            }

            Conexao.Close();

            return Lista;

        }

        public void Inserir(PacotesTuristicos pacote)
        {


            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();


            String QuerySql = "insert into Usuario (nome,origem,atrativos,saida,retorno,destino) values (@nome,@origem,@atrativos,@Dsaida,@retorno,@destino)";


            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);


            Comando.Parameters.AddWithValue("@nome", pacote.Nome);
            Comando.Parameters.AddWithValue("@origem", pacote.Origem);
            Comando.Parameters.AddWithValue("@destino", pacote.Destino);
            Comando.Parameters.AddWithValue("@atrativos", pacote.Atrativos);
            Comando.Parameters.AddWithValue("@saida", pacote.Saida);
            Comando.Parameters.AddWithValue("@retorno", pacote.Retorno);


            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public void Alterar(PacotesTuristicos pacote)
        {


            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();


            String QuerySql = "update pacotesturisticos set nome=@nome, origem=@origem,destino=@destino, atrativos=@atrativos,saida=@saida, retorno=@retorno WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);


            Comando.Parameters.AddWithValue("@nome", pacote.Nome);
            Comando.Parameters.AddWithValue("@origem", pacote.Origem);
            Comando.Parameters.AddWithValue("@Destino", pacote.Destino);
            Comando.Parameters.AddWithValue("@atrativos", pacote.Atrativos);
            Comando.Parameters.AddWithValue("@saida", pacote.Saida);
            Comando.Parameters.AddWithValue("@retorno", pacote.Retorno);


            Comando.ExecuteNonQuery();

            Conexao.Close();
        }

        public void Excluir(PacotesTuristicos pacote)
        {


            MySqlConnection Conexao = new MySqlConnection(DadosConexao);
            Conexao.Open();


            String QuerySql = "delete from pacotesturisticos WHERE Id=@Id";

            MySqlCommand Comando = new MySqlCommand(QuerySql, Conexao);


            Comando.Parameters.AddWithValue("@Id", pacote.Id);

            Comando.ExecuteNonQuery();

            Conexao.Close();
        }




    }
}