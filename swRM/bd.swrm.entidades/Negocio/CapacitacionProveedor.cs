namespace bd.swrm.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class CapacitacionProveedor
    {
        [Key]
        public int IdCapacitacionProveedor { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Tel�fono:")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Capacitaci�n:")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Direcci�n:")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Direccion { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Capacitaci�n recibida:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdCapacitacionRecibida { get; set; }
        public virtual CapacitacionRecibida CapacitacionRecibida { get; set; }

        public virtual ICollection<CapacitacionTemarioProveedor> CapacitacionTemarioProveedor { get; set; }

        
    }
}
