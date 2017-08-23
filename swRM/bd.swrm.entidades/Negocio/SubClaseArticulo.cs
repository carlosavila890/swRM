namespace bd.swrm.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class SubClaseArticulo
    {
        [Key]
        public int IdSubClaseArticulo { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Sub clase de �rticulo:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Clase de �rticulo:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdClaseArticulo { get; set; }
        public virtual ClaseArticulo ClaseArticulo { get; set; }

        public virtual ICollection<Articulo> Articulo { get; set; }

    }
}
