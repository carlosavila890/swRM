namespace bd.swrm.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class IndiceOcupacionalCapacitaciones
    {
        [Key]
        public int IdIndiceOcupacionalCapacitaciones { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "�ndice Ocupacional:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdIndiceOcupacional { get; set; }
        public virtual IndiceOcupacional IndiceOcupacional { get; set; }

        [Display(Name = "Capacitaci�n:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdCapacitacion { get; set; }
        public virtual Capacitacion Capacitacion { get; set; }

        public virtual ICollection<ExperienciaLaboralRequerida> ExperienciaLaboralRequerida { get; set; }

    }
}
