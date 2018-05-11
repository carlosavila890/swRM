namespace bd.swrm.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class RecepcionActivoFijoDetalle
    {
        public RecepcionActivoFijoDetalle()
        {
            ComponentesActivoFijoComponente = new HashSet<ComponenteActivoFijo>();
            ComponentesActivoFijoOrigen = new HashSet<ComponenteActivoFijo>();
            DepreciacionActivoFijo = new HashSet<DepreciacionActivoFijo>();
            DocumentoActivoFijo = new HashSet<DocumentoActivoFijo>();
            MantenimientoActivoFijo = new HashSet<MantenimientoActivoFijo>();
            UbicacionActivoFijo = new HashSet<UbicacionActivoFijo>();
        }

        [Key]
        public int IdRecepcionActivoFijoDetalle { get; set; }
        
        [Display(Name = "N�mero de p�liza:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        [RegularExpression(@"^\d*$", ErrorMessage = "El {0} solo puede contener n�meros.")]
        public string NumeroPoliza { get; set; }
        
        [Display(Name = "Serie:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Serie { get; set; }

        [Display(Name = "N�mero de chasis:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string NumeroChasis { get; set; }

        [Display(Name = "N�mero de motor:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string NumeroMotor { get; set; }

        [Display(Name = "Placa:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "La {0} no puede tener m�s de {1} y menos de {2}")]
        public string Placa { get; set; }

        [Display(Name = "N�mero de clave catastral:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string NumeroClaveCatastral { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Recepci�n de activo fijo:")]
        [Required(ErrorMessage = "Debe seleccionar el {0} ")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdRecepcionActivoFijo { get; set; }
        public virtual RecepcionActivoFijo RecepcionActivoFijo { get; set; }

        [Display(Name = "ActivoFijo:")]
        [Required(ErrorMessage = "Debe seleccionar el {0} ")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdActivoFijo { get; set; }
        public virtual ActivoFijo ActivoFijo { get; set; }

        [Display(Name = "Estado:")]
        [Required(ErrorMessage = "Debe seleccionar el {0} ")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEstado { get; set; }
        public virtual Estado Estado { get; set; }

        public virtual AltaActivoFijo AltaActivoFijo { get; set; }
        public virtual BajaActivoFijo BajaActivoFijo { get; set; }
        public virtual ICollection<ComponenteActivoFijo> ComponentesActivoFijoComponente { get; set; }
        public virtual ICollection<ComponenteActivoFijo> ComponentesActivoFijoOrigen { get; set; }
        public virtual ICollection<DepreciacionActivoFijo> DepreciacionActivoFijo { get; set; }
        public virtual ICollection<DocumentoActivoFijo> DocumentoActivoFijo { get; set; }
        public virtual ICollection<MantenimientoActivoFijo> MantenimientoActivoFijo { get; set; }
        public virtual ICollection<UbicacionActivoFijo> UbicacionActivoFijo { get; set; }
    }
}
