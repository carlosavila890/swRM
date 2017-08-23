namespace bd.swrm.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class CapacitacionTipoPregunta
    {
        [Key]
        public int IdCapacitacionTipoPregunta { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Tipo de pregunta:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Descripcion { get; set; }

        public virtual ICollection<CapacitacionPregunta> CapacitacionPregunta { get; set; }
    }
}
