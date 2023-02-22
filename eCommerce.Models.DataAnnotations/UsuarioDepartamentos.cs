﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class UsuarioDepartamentos
    {
        public int Id { get; set; }

        [Required]
        public int UsuarioId { get; set; }
        [Required]
        public ICollection<Departamento> Departamentos { get; set; }

        public UsuarioDepartamentos()
        {
          
        }

    }
}
