using System;
namespace atividade_II.Models
{
    public class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public DateTime dataNascimento { get; set; }

        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { this.nome = value; }
        }
        public string Login
        {
            get { return login; }
            set { this.login = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { this.senha = value; }
        }
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { this.dataNascimento = value; }
        }

    }

}