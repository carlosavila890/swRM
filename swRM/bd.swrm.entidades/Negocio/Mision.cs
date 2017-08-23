namespace bd.swrm.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
     

    public partial class Mision
    {
        [Key]
        public int IdMision { get; set; }

        [Required(ErrorMessage = "Debe introducir  {0}")]
        [DataType(DataType.Text)]
        [Display(Name = "Misi�n:")]
        public string Descripcion { get; set; }

        public virtual ICollection<MisionIndiceOcupacional> MisionIndiceOcupacional { get; set; }
    }
}
