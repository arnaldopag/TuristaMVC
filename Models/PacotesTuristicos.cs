using System;
namespace atividade_II.Models
{
    public class PacotesTuristicos
    {

        private int id { get; set; }
        private string nome { get; set; }
        private string origem { get; set; }
        private string atrativos { get; set; }
        private DateTime saida { get; set; }
        private DateTime retorno { get; set; }

        public PacotesTuristicos(int id, string nome, string origem, string atrativos, DateTime saida, DateTime retorno)
        {
            this.id = id;
            this.nome = nome;
            this.origem = origem;
            this.atrativos = atrativos;
            this.saida = saida;
            this.retorno = retorno;
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
        public string Origem
        {
            get { return Origem; }
            set { origem = value; }
        }
        public string Atrativos
        {
            get { return atrativos; }
            set { atrativos = value; }
        }
        public DateTime Saida
        {
            get { return saida; }
            set { saida = value; }
        }

        public DateTime Retorno
        {
            get { return retorno; }
            set { retorno = value; }
        }
    }
}