﻿using System;
using System.Collections.Generic;
using System.Text;

namespace bd.swrm.entidades.ObjectTransfer
{
    public class ActivoFijoDocumentoTransfer
    {
        public string Nombre { get; set; }
        public byte[] Fichero { get; set; }
        public int IdActivoFijo { get; set; }
    }
}
