﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
