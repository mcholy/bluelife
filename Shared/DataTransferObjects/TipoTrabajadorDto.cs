﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public class TipoTrabajadorDto
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string? Estado { get; set; }
    }
}
