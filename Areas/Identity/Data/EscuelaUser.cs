using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escuela.Models;
using Microsoft.AspNetCore.Identity;

namespace Escuela.Areas.Identity.Data
{
    public class EscuelaUser : IdentityUser
    {
        public string AlumnoId { get; set; }
        
        public Alumno Alumno { get; set; }
    }
}
