namespace bd.swrm.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class RecepcionActivoFijo
    {
        [Key]
        public int IdRecepcionActivoFijo { get; set; }

        [Required(ErrorMessage = "Debe introducir la {0}")]
        [Display(Name = "Fecha de recepci�n:")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaRecepcion { get; set; }

        [Required(ErrorMessage = "Debe introducir la {0}")]
        [Display(Name = "Cantidad:")]
        public decimal Cantidad { get; set; }

        [Required(ErrorMessage = "Debe introducir la {0}")]
        [Display(Name = "�Validacion t�cnica?")]
        public bool ValidacionTecnica { get; set; }

        [Required(ErrorMessage = "Debe introducir el {0}")]
        [Display(Name = "Fondo:")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Fondo { get; set; }

        [Required(ErrorMessage = "Debe introducir la {0}")]
        [Display(Name = "Orden de compra:")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string OrdenCompra { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Libro de activo fijo:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdLibroActivoFijo { get; set; }
        public virtual LibroActivoFijo LibroActivoFijo { get; set; }

        [Display(Name = "Servidor p�blico:")]
        [Required(ErrorMessage = "Debe seleccionar el {0}")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEmpleado { get; set; }
        public virtual Empleado Empleado { get; set; }

        [Display(Name = "Sub clase de activo fijo:")]
        [Required(ErrorMessage = "Debe seleccionar la {0}")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdSubClaseActivoFijo { get; set; }
        public virtual SubClaseActivoFijo SubClaseActivoFijo { get; set; }

        [Display(Name = "MotivoRecepci�n:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdMotivoRecepcion { get; set; }
        public virtual MotivoRecepcion MotivoRecepcion { get; set; }

        [Display(Name = "Proveedor:")]
        [Required(ErrorMessage = "Debe seleccionar el {0}")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdProveedor { get; set; }
        public virtual Proveedor Proveedor { get; set; }

        public virtual ICollection<RecepcionActivoFijoDetalle> RecepcionActivoFijoDetalle { get; set; }
    }
}
