namespace bd.swrm.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class RelacionesInternasExternasIndiceOcupacional
    {
        [Key]
        public int IdRelacionesInternasExternasIndiceOcupacional { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Relaciones internas externas:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int RelacionesInternasExternasId { get; set; }
        public virtual RelacionesInternasExternas RelacionesInternasExternas { get; set; }

        [Display(Name = "�ndice ocupacional:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdIndiceOcupacional { get; set; }
        public virtual IndiceOcupacional IndiceOcupacional { get; set; }


    }
}
