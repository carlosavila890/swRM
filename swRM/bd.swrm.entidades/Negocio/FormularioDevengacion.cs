namespace bd.swrm.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class FormularioDevengacion
    {
        [Key]
        public int IdFormularioDevengacion { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Modo social:")]
        [StringLength(250, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string ModoSocial { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Evento:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdEvento { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Modo socializaci�n:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int ModosScializacionId { get; set; }
        public virtual ModosScializacion ModosScializacion { get; set; }

        [Display(Name = "Empleado:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEmpleado { get; set; }
        public virtual Empleado Empleado { get; set; }

        [Display(Name = "Analista Desarrollo Institucional:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int AnalistaDesarrolloInstitucional { get; set; }
        public virtual Empleado EmpleadoDesarrolloInstitucional { get; set; }

        [Display(Name = "Responsable �rea:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int ResponsableArea { get; set; }
        public virtual Empleado EmpleadoResponsableArea { get; set; }

        public virtual ICollection<EmpleadosFormularioDevengacion> EmpleadosFormularioDevengacion { get; set; }

        public virtual ICollection<MaterialApoyo> MaterialApoyo { get; set; }

    }
}
