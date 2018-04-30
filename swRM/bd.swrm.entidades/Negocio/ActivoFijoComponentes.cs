﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bd.swrm.entidades.Negocio
{
    public partial class ActivoFijoComponentes
    {
        [Key]
        public int IdAdicion { get; set; }

        [Display(Name = "ActivoFijo de origen:")]
        [Required(ErrorMessage = "Debe seleccionar el {0} ")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdActivoFijoOrigen { get; set; }
        public virtual ActivoFijo ActivoFijoOrigen { get; set; }

        [Display(Name = "Componente de ActivoFijo:")]
        [Required(ErrorMessage = "Debe seleccionar el {0} ")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdActivoFijoComponente { get; set; }
        public virtual ActivoFijo ActivoFijoComponente { get; set; }

        [Required(ErrorMessage = "Debe introducir la {0}")]
        [Display(Name = "Fecha de adición:")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaAdicion { get; set; }
    }
}