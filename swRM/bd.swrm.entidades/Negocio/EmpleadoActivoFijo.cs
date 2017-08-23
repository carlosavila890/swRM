namespace bd.swrm.entidades.Negocio
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class EmpleadoActivoFijo
    {
        [Key]
        public int IdEmpleadoActivoFijo { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fecha de asignaci�n:")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaAsignacion { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Activo fijo:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdActivoFijo { get; set; }
        public virtual ActivoFijo ActivoFijo { get; set; }

        [Display(Name = "Empleado:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEmpleado { get; set; }
        public virtual Empleado Empleado { get; set; }
    }
}
