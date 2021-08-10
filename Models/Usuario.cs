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

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public DateTime DataNascimento
        {
            get { return datanascimento; }
            set { datanascimento = value; }
        }

    }

}