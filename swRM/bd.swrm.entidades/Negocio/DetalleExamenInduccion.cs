namespace bd.swrm.entidades.Negocio
{
    using System.ComponentModel.DataAnnotations;
     

    
    public partial class DetalleExamenInduccion
    {
        [Key]
        public int IdDetalleExamenInduccion { get; set; }


        //Propiedades Virtuales Referencias a otras clases

        [Display(Name = "Examen de inducci�n:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int RealizaExamenInduccionId { get; set; }
        public virtual RealizaExamenInduccion RealizaExamenInduccion { get; set; }

        [Display(Name = "Pregunta:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? PreguntaId { get; set; }
        public virtual Pregunta Pregunta { get; set; }

        [Display(Name = "Respuesta:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int RespuestaId { get; set; }
        public virtual Respuesta Respuesta { get; set; }
        

       

        
    }
}
