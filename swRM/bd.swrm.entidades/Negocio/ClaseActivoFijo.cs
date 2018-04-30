namespace bd.swrm.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ClaseActivoFijo
    {
        [Key]
        public int IdClaseActivoFijo { get; set; }

        [Required(ErrorMessage = "Debe introducir la {0}")]
        [Display(Name = "Clase de activo fijo:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "La {0} no puede tener m�s de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Tipo de activo fijo:")]
        [Required(ErrorMessage = "Debe seleccionar el {0}")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdTipoActivoFijo { get; set; }

        public virtual TipoActivoFijo TipoActivoFijo { get; set; }

        [Display(Name = "Depreciaci�n")]
        [Required(ErrorMessage = "Debe seleccionar la {0}")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar la {0} ")]
        public int IdTablaDepreciacion { get; set; }

        public virtual TablaDepreciacion TablaDepreciacion { get; set; }

        public virtual ICollection<SubClaseActivoFijo> SubClaseActivoFijo { get; set; }
    }
}
