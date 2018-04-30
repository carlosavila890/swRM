namespace bd.swrm.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     
    public partial class Proveedor
    {
        [Key]
        public int IdProveedor { get; set; }

        [Required(ErrorMessage = "Debe introducir el {0}")]
        [Display(Name = "Nombre:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe introducir los {0}")]
        [Display(Name = "Apellidos:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Los {0} no pueden tener m�s de {1} y menos de {2}")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "Debe introducir la {0}")]
        [Display(Name = "Identificaci�n:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "La {0} no puede tener m�s de {1} y menos de {2}")]
        [RegularExpression(@"^\d*$", ErrorMessage = "La {0} solo puede contener n�meros.")]
        public string Identificacion { get; set; }

        [Required(ErrorMessage = "Debe introducir la {0}")]
        [Display(Name = "Direcci�n:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "La {0} no puede tener m�s de {1} y menos de {2}")]
        public string Direccion { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        public virtual ICollection<Factura> Factura { get; set; }

        public virtual ICollection<RecepcionActivoFijo> RecepcionActivoFijo { get; set; }

        public virtual ICollection<RecepcionArticulos> RecepcionArticulos { get; set; }
    }
}
