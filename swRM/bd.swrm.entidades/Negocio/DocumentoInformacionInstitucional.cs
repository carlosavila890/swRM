namespace bd.swrm.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;

    public partial class DocumentoInformacionInstitucional
    {
        [Key]
        public int IdDocumentoInformacionInstitucional { get; set; }

        [Required(ErrorMessage = "Debe introducir {0}")]
        [Display(Name = "Nombre fichero:")]
        [StringLength(250, MinimumLength = 2, ErrorMessage = "El {0} no puede tener m�s de {1} y menos de {2}")]
        public string Nombre { get; set; }

        [DataType(DataType.Url)]
        public string Url { get; set; }
    }
}
