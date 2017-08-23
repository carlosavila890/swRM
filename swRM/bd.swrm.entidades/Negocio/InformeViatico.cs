namespace bd.swrm.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class InformeViatico
    {
        [Key]
        public int IdInformeViatico { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Descripci�n:")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Descripcion { get; set; }

        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Itinerario de vi�tico:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdItinerarioViatico { get; set; }
        public virtual ItinerarioViatico ItinerarioViatico { get; set; }
    }
}
