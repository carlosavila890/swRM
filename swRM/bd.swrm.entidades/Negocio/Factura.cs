namespace bd.swrm.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Factura
    {
        [Key]
        public int IdFactura { get; set; }

        [Required(ErrorMessage = "Debe introducir el {0}")]
        [Display(Name = "N�mero de factura:")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Numero { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Proveedor:")]
        [Required(ErrorMessage = "Debe seleccionar el {0}")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdProveedor { get; set; }
        public virtual Proveedor Proveedor { get; set; }

        [Display(Name = "Maestro Art�culo de Sucursal:")]
        [Required(ErrorMessage = "Debe seleccionar el {0}")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdMaestroArticuloSucursal { get; set; }
        public virtual MaestroArticuloSucursal MaestroArticuloSucursal { get; set; }

        public virtual ICollection<DetalleFactura> DetalleFactura { get; set; }
    }
}
