namespace bd.swrm.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
     

    public partial class EvaluacionInducion
    {
        [Key]
        public int IdEvaluacionInduccion { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "M�nipo de puntos para aprobar:")]
        [Range(1,1, ErrorMessage = "El {0} debe ser mayor que {1} ")]
        public int MinimoAprobar { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "M�nipo de puntos para aprobar:")]
        [Range(1, 100, ErrorMessage = "El {0} debe ser menor que {2} ")]
        public int MaximoPuntos { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Evaluaci�n de inducci�n:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        public virtual ICollection<Pregunta> Pregunta { get; set; }

        public virtual ICollection<RealizaExamenInduccion> RealizaExamenInduccion { get; set; }
    }
}
