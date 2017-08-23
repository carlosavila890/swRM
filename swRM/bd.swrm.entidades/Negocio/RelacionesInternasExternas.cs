namespace bd.swrm.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class RelacionesInternasExternas
    {
        [Key]
        public int IdRelacionesInternasExternas { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Descripci�n:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Descripcion { get; set; }

        public virtual ICollection<RelacionesInternasExternasIndiceOcupacional> RelacionesInternasExternasIndiceOcupacional { get; set; }
    }
}
