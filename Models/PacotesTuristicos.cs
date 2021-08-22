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
        private string destino { get; set; }

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
        public string Destino
        {
            get { return Destino; }
            set { destino = value; }
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