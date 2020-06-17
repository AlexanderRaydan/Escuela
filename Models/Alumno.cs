using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Escuela.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Asignatura> Asignaturas { get; set; }
        public string CursoId {get; set;}
        public Curso Curso  {get; set;}
    }
}