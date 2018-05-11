﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bd.swrm.entidades.Negocio
{
    public partial class UbicacionActivoFijo
    {
        public UbicacionActivoFijo()
        {
            TransferenciasActivoFijoDestino = new HashSet<TransferenciaActivoFijo>();
            TransferenciasActivoFijoUbicacion = new HashSet<TransferenciaActivoFijo>();
        }

        [Key]
        public int IdUbicacionActivoFijo { get; set; }

        [Display(Name = "Empleado:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdEmpleado { get; set; }
        public virtual Empleado Empleado { get; set; }

        [Display(Name = "Bodega:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar la {0} ")]
        public int? IdBodega { get; set; }
        public virtual Bodega Bodega { get; set; }

        [Display(Name = "Detalle de Recepción de Activo Fijo:")]
        [Required(ErrorMessage = "Debe seleccionar el {0} ")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdRecepcionActivoFijoDetalle { get; set; }
        public virtual RecepcionActivoFijoDetalle RecepcionActivoFijoDetalle { get; set; }

        [Display(Name = "Libro de activo fijo:")]
        [Required(ErrorMessage = "Debe seleccionar el {0} ")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdLibroActivoFijo { get; set; }
        public virtual LibroActivoFijo LibroActivoFijo { get; set; }

        [Required(ErrorMessage = "Debe introducir la {0}")]
        [Display(Name = "Fecha de ubicación:")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaUbicacion { get; set; }

        public virtual ICollection<TransferenciaActivoFijo> TransferenciasActivoFijoDestino { get; set; }
        public virtual ICollection<TransferenciaActivoFijo> TransferenciasActivoFijoUbicacion { get; set; }
    }
}
