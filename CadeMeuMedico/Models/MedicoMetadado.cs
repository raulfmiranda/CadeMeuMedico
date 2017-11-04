using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models
{
    [MetadataType(typeof(MedicoMetadado))]
    public partial class Medico
    {

    }

    public class MedicoMetadado
    {
        [Required(ErrorMessage ="Obrigatório informar o CRM")]
        [StringLength(30, ErrorMessage ="O CRM deve possuir no máximo 30 caracters")]
        public string CRM { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Nome")]
        [StringLength(80, ErrorMessage = "O Nome deve possuir no máximo 80 caracters")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Endereco")]
        [StringLength(100, ErrorMessage = "O Endereco deve possuir no máximo 100 caracters")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Bairro")]
        [StringLength(60, ErrorMessage = "O Bairro deve possuir no máximo 60 caracters")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Email")]
        [StringLength(100, ErrorMessage = "O Email deve possuir no máximo 100 caracters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar se atende por Convênio")]
        public bool AtendePorConvenio { get; set; }

        [Required(ErrorMessage = "Obrigatório informar se tem Clínica")]
        public bool TemClinica { get; set; }

        [StringLength(80, ErrorMessage = "O WebsiteBlog deve possuir no máximo 80 caracters")]
        public string WebsiteBlog { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Cidade")]
        public int IDCidade { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Especialidade")]
        public int IDEspecialidade { get; set; }
    }
}