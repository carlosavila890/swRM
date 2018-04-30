namespace bd.swrm.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ActivoFijo
    {
        public ActivoFijo()
        {
            ActivosFijosComponentes = new HashSet<ActivoFijoComponentes>();
            ActivosFijosOrigen = new HashSet<ActivoFijoComponentes>();
            BajaActivosFijosDetalles = new HashSet<BajaActivoFijoDetalle>();
            AltaActivosFijosDetalles = new HashSet<AltaActivoFijoDetalle>();
            DepreciacionActivoFijo = new HashSet<DepreciacionActivoFijo>();
            EmpleadoActivoFijo = new HashSet<EmpleadoActivoFijo>();
            MantenimientoActivoFijo = new HashSet<MantenimientoActivoFijo>();
            RecepcionActivoFijoDetalle = new HashSet<RecepcionActivoFijoDetalle>();
            TransferenciaActivoFijoDetalle = new HashSet<TransferenciaActivoFijoDetalle>();
        }

        [Key]
        public int IdActivoFijo { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Activo fijo:")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Serie:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Serie { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Valor de compra:")]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal ValorCompra { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Ubicaci�n:")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Ubicacion { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Sub clase de activo fijo:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdSubClaseActivoFijo { get; set; }
        public virtual SubClaseActivoFijo SubClaseActivoFijo { get; set; }

        [Display(Name = "Libro de activo fijo:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdLibroActivoFijo { get; set; }
        public virtual LibroActivoFijo LibroActivoFijo { get; set; }

        [Display(Name = "Ciudad:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdCiudad { get; set; }
        public virtual Ciudad Ciudad { get; set; }

        [Display(Name = "Unidad de medida:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdUnidadMedida { get; set; }
        public virtual UnidadMedida UnidadMedida { get; set; }

        [Display(Name = "C�digo de activo fijo")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdCodigoActivoFijo { get; set; }
        public virtual CodigoActivoFijo CodigoActivoFijo { get; set; }

        [Display(Name = "Modelo:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdModelo { get; set; }
        public virtual Modelo Modelo { get; set; }

        public virtual ICollection<AltaActivoFijoDetalle> AltaActivosFijosDetalles { get; set; }

        public virtual ICollection<BajaActivoFijoDetalle> BajaActivosFijosDetalles { get; set; }

        public virtual ICollection<EmpleadoActivoFijo> EmpleadoActivoFijo { get; set; }

        public virtual ICollection<DepreciacionActivoFijo> DepreciacionActivoFijo { get; set; }

        public virtual ICollection<MantenimientoActivoFijo> MantenimientoActivoFijo { get; set; }

        public virtual ICollection<RecepcionActivoFijoDetalle> RecepcionActivoFijoDetalle { get; set; }

        public virtual ICollection<TransferenciaActivoFijoDetalle> TransferenciaActivoFijoDetalle { get; set; }

        public virtual ICollection<ActivoFijoComponentes> ActivosFijosComponentes { get; set; }

        public virtual ICollection<ActivoFijoComponentes> ActivosFijosOrigen { get; set; }
    }
}