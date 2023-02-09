using System.ComponentModel.DataAnnotations;

namespace RegistroDeCulto.Models
{
    public class Culto
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public string PalavraInicial { get; set; }
        public int HinosHarpa { get; set; }
        public string OracaoOportunidades { get; set; }
        public string Oportunidades { get; set; }
        public string LouvorOfertas { get; set; }
        public string OracaoOfertas { get; set; }
        public string OracaoPreleitor { get; set; }
        public string Preleitor { get; set; }
        public string Mensagem { get; set; }
        public int Adultos { get; set; }
        public int Criancas { get; set; }
        public int Total { get; set; }
        public string Avisos { get; set; }
        public string OracaoFinal { get; set; }
        public string BencaoApostolica { get; set; }

    }
}
