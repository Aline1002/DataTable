using System.ComponentModel.DataAnnotations;

namespace DataTable.Models
{
    public class Empresas
    {
        [Key]
        public int EmpresasID { get; set; }

        //Auto_relacionamentonamento
        public int? EmpresasMatrizesID { get; set; }
        public Empresas EmpresasMatrizes { get; set; }

        //atributos 
        [MaxLength(80)]
        public string? RazaoSocial { get; set; }

        [MaxLength(55)]
        public string? NomeFantasia { get; set; }

        [StringLength(14)]
        public string? CNPJ { get; set; }

        [MaxLength(30)]
        public string? Endereco { get; set; }

        [MaxLength(5)]
        public string? Numero { get; set; }

        [MaxLength(30)]
        public string? Complemento { get; set; }

        [MaxLength(30)]
        public string? Bairro { get; set; }

        [MaxLength(30)]
        public string? Cidade { get; set; }

        [StringLength(2)]
        public string? UF { get; set; }

        public bool Ativo { get; set; }

        public string? UrlLogoTipo { get; set; }

        public DateTime DataInclusao { get; set; }


    }
}
