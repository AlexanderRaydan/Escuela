using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Escuela.Models
{
    public class Curso:ObjetoEscuelaBase
    {   
        [StringLength(5 , ErrorMessage = "El nombre no puede ser mayor que 5 caracteres")]//longitud maxima de 5 caracteres
        [Required(ErrorMessage = "El nombre del curso es requerido")] //hace que el atributo al instanciar la clase no sea null
        [Display(Prompt = "Nombre correspondido" , Name = "Name")]
        public override string Nombre {get;set;}

        [Required]
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas{ get; set; }
        public List<Alumno> Alumnos{ get; set; }

        [Display(Prompt = "Direccion correspondida" , Name = "Address")]//permite poner marcas de agua en los formularios
        [MinLength(10 , ErrorMessage = "La longitud minima de la direccion es de 10 caracteres")]//longitud maxima de 5 caracteres
        public string Dirección { get; set; }

    }
}