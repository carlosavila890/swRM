namespace bd.swrm.entidades.Negocio.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class ImpuestoRentaParametros
    {
        [Key]
        public int IdImpuestoRentaParametros { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Fracci�n b�sica:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal FraccionBasica { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Exceso de hasta:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal ExcesoHasta { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Impuesto de fracci�n b�sica:")]
        public int? ImpuestoFraccionBasica { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Porcentaje de impuesto de fracci�n excedente:")]
        public int PorcentajeImpuestoFraccionExcedente { get; set; }
    }
}
