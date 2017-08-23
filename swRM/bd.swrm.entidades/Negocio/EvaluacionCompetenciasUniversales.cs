namespace bd.swrm.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class EvaluacionCompetenciasUniversales
    {
        [Key]
        public int IdEvaluacionCompetenciasUniversales { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Nombre:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        public virtual ICollection<Eval001> Eval001 { get; set; }

        public virtual ICollection<EvaluacionCompetenciasUniversalesFactor> EvaluacionCompetenciasUniversalesFactor { get; set; }

        public virtual ICollection<EvaluacionCompetenciasUniversalesDetalle> EvaluacionCompetenciasUniversalesDetalle { get; set; }
    }
}
