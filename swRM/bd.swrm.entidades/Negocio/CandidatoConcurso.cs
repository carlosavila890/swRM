namespace bd.swrm.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class CandidatoConcurso
    {
        [Key]
        public int IdCandidatoConcurso { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "C�digo de Socio Empleo:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string CodigoSocioEmpleo { get; set; }


        [Required(ErrorMessage = "�Descartado?")]
        [Display(Name = "C�digo de Socio Empleo:")]
        public bool Descartado { get; set; }

        [Required(ErrorMessage = "�Ganador?")]
        [Display(Name = "C�digo de Socio Empleo:")]
        public bool Ganador { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Candidato")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdCanditato { get; set; }
        public virtual Canditato Canditato { get; set; }


        [Display(Name = "Fase Partida:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdPartidasFase { get; set; }
        public virtual PartidasFase PartidasFase { get; set; }
    }
}
