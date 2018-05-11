namespace bd.swrm.entidades.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TransferenciaActivoFijo
    {
        [Key]
        public int IdTransferenciaActivoFijo { get; set; }

        [Display(Name = "Empleado que registra:")]
        [Required(ErrorMessage = "Debe seleccionar el {0} ")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEmpleadoRegistra { get; set; }
        public virtual Empleado EmpleadoRegistra { get; set; }

        [Display(Name = "Responsable de env�o:")]
        [Required(ErrorMessage = "Debe seleccionar el {0} ")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEmpleadoResponsableEnvio { get; set; }
        public virtual Empleado EmpleadoResponsableEnvio { get; set; }

        [Display(Name = "Responsable de recibo:")]
        [Required(ErrorMessage = "Debe seleccionar el {0} ")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdEmpleadoResponsableRecibo { get; set; }
        public virtual Empleado EmpleadoResponsableRecibo { get; set; }

        [Display(Name = "Empleado que recibe:")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int? IdEmpleadoRecibo { get; set; }
        public virtual Empleado EmpleadoRecibo { get; set; }

        [Display(Name = "Motivo de transferencia:")]
        [Required(ErrorMessage = "Debe seleccionar el {0} ")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar el {0} ")]
        public int IdMotivoTransferencia { get; set; }
        public virtual MotivoTransferencia MotivoTransferencia { get; set; }

        [Required(ErrorMessage = "Debe introducir la {0}")]
        [Display(Name = "Fecha de transferencia:")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime FechaTransferencia { get; set; }

        [Display(Name = "Observaciones:")]
        public string Observaciones { get; set; }

        [Display(Name = "Ubicaci�n de origen:")]
        [Required(ErrorMessage = "Debe seleccionar la {0} ")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar la {0} ")]
        public int IdUbicacionActivoFijoOrigen { get; set; }
        public virtual UbicacionActivoFijo UbicacionActivoFijoOrigen { get; set; }

        [Display(Name = "Ubicaci�n de destino:")]
        [Required(ErrorMessage = "Debe seleccionar la {0} ")]
        [Range(1, double.MaxValue, ErrorMessage = "Debe seleccionar la {0} ")]
        public int IdUbicacionActivoFijoDestino { get; set; }
        public virtual UbicacionActivoFijo UbicacionActivoFijoDestino { get; set; }
    }
}
