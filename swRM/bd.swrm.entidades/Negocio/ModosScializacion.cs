namespace bd.swrm.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
     

    public partial class ModosScializacion
    {
        [Key]
        public int IdModosScializacion { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Modo de socializaci�n:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Descripcion { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        public virtual ICollection<FormularioDevengacion> FormularioDevengacion { get; set; }
    }
}
