namespace bd.swrm.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ConfiguracionContabilidad
    {
        [Key]
        public int idConfiguracionContabilidad { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Cuenta Debe:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal ValorD { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Cuenta haber:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal ValorH { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Cuenta Haber")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdCatalogoCuentaH { get; set; }
        public virtual CatalogoCuenta CatalogoCuentaH { get; set; }

        [Display(Name = "Cuenta debe:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdCatalogoCuentaD { get; set; }
        public virtual CatalogoCuenta CatalogoCuentaD { get; set; }

        public virtual ICollection<MotivoAsiento> MotivoAsiento { get; set; }
    }
}
