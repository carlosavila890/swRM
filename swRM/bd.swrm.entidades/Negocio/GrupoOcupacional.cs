namespace bd.swrm.entidades.Negocio
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class GrupoOcupacional
    {
        [Key]
        public int IdGrupoOcupacional { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Grupo ocupacional:")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Nombre { get; set; }

        //Propiedades Virtuales Referencias a otras clases
        public virtual ICollection<EscalaGrados> EscalaGrados { get; set; }
    }
}
