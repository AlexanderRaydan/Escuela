using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escuela.Models;
using Escuela.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Escuela.Data
{
    public class EscuelaContext : IdentityDbContext<EscuelaUser>
    {
        //ver si en la base de datos se guarda la tabla como "Alumnos"
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Asignatura>Asignaturas{ get; set; }


        public EscuelaContext(DbContextOptions<EscuelaContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            var cursos = CargarCursos();

            var Asignaturas = CargarAsignaturas(cursos);

          //  var Alumnos = CargarAlumnos(cursos);


            builder.Entity<Curso>().HasData(cursos.ToArray());
            builder.Entity<Asignatura>().HasData(Asignaturas.ToArray());
           // builder.Entity<Alumno>().HasData(Alumnos.ToArray());

        }


        private static List<Asignatura> CargarAsignaturas(List<Curso> cursos)
        {

            var ListaCompleta = new List<Asignatura>();

            foreach (var cur in cursos)
            {

                ListaCompleta.AddRange(

                    new List<Asignatura>(){
                    new Asignatura{Nombre="Matemáticas" , CursoId = cur.Id } ,
                    new Asignatura{Nombre="Educación Física" , CursoId = cur.Id },
                    new Asignatura{Nombre="Castellano" , CursoId = cur.Id},
                    new Asignatura{Nombre="Ciencias Naturales" , CursoId = cur.Id },
                    new Asignatura{Nombre="Programación" , CursoId = cur.Id }

                 }); 

                //cur.Asignaturas = temList; esta comentado porque hicimos todo por convencion , y le agrega la asignatura a los cursos automaticamente
            }

            return ListaCompleta;
        }

        private static List<Curso> CargarCursos()
        {
            var esuCursos = new List<Curso>{

                    new Curso(){
                        Nombre = "101" ,
                        Jornada = TiposJornada.Mañana,
                    },
                        new Curso(){
                        Nombre = "102" ,
                        Jornada = TiposJornada.Tarde,
                    },
                        new Curso(){
                        Nombre = "103" ,
                        Jornada = TiposJornada.Mañana
                    },
                        new Curso(){
                        Nombre = "104" ,
                        Jornada = TiposJornada.Noche,
                    }
                };

            return esuCursos;
        }


        //se crearan los alumnos cuando se cree en usuario
        private List<Alumno> GenerarAlumnosAlAzar(int cantidad, Curso curso, List<Asignatura> asignaturas)
        {

            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro",  };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno
                               {
                                   Nombre = $"{n1} {n2} {a1}",
                                   CursoId = curso.Id,
                                   Asignaturas = asignaturas,
                               };

            return listaAlumnos.OrderBy((al) => al.Id).Take(cantidad).ToList();
        }

        private List<Alumno> CargarAlumnos(List<Curso> cursos)
        {
            var listaAlumnos = new List<Alumno>();

            Random rnd = new Random();
            foreach (var curso in cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                var tmplist = GenerarAlumnosAlAzar(cantRandom, curso, curso.Asignaturas);
                listaAlumnos.AddRange(tmplist);
            }
            return listaAlumnos;
        }

    }
}
