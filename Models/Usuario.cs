using System;
namespace atividade_II.Models
{
    public class Usuario
    {
        private int id { get; set; }
        private string nome { get; set; }
        private string login { get; set; }
        private string senha { get; set; }
        private DateTime datanascimento { get; set; }

        public Usuario(int id, string nome, string login, string senha, DateTime datanascimento)
        {
            this.id = id;
            this.nome = nome;
            this.login = login;
            this.senha = senha;
            this.datanascimento = datanascimento;
        }
    }
}