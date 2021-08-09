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
    }
}