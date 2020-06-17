using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escuela.Data;
using Escuela.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Escuela.Controllers
{
    public class CursoController : Controller
    {

        private readonly EscuelaContext _context;

        public CursoController(EscuelaContext context)
        {
            _context = context;
        }

        // GET: CursoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CursoController/Details/5
        public ActionResult Details(string id)
        {

            if(!cursoExiste(id))
            {
                return NotFound();//hacer una ventana de "curso no existe"
            }

            var curso = _context.Cursos.Find(id);

            curso.Asignaturas = getAsignaturas(id);
            curso.Alumnos = getAlumnos(id);

            return View(curso);
        }

        // GET: CursoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CursoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CursoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CursoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CursoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CursoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private List<Asignatura> getAsignaturas(string id)
        {

            var asignaturas = from asig in _context.Asignaturas
                              where asig.CursoId == id
                              select asig;

            return asignaturas.ToList();
        }

        private List<Alumno> getAlumnos(string id)
        {

            var alumnos = from alum in _context.Alumnos
                              where alum.CursoId == id
                              select alum;

            return alumnos.ToList();
        }

        private bool cursoExiste(string id)
        {
            if (id == null)
                return false;

            return _context.Cursos.Any(e => e.Id == id); ;
        }
    }
}
