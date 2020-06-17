using System;
using System.ComponentModel.DataAnnotations;

namespace Escuela.Models
{
    public abstract class ObjetoEscuelaBase
    {
        public string Id { get; set; }
        
        [Required]
        public virtual string Nombre { get; set; } //el virtual permite que los objetos hijos puedan reescribir los atributos( en este caso)

        public override string ToString()
        {
            return $"{Nombre},{Id}";
        }

        public ObjetoEscuelaBase()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}