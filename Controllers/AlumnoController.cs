using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escuela.Areas.Identity.Data;
using Escuela.Data;
using Escuela.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Escuela.Controllers
{
    public class AlumnoController : Controller
    {

        private readonly EscuelaContext _context;
        private readonly UserManager<EscuelaUser> _userManager;
        private readonly SignInManager<EscuelaUser> _signInManager;

        public AlumnoController(EscuelaContext context,
            UserManager<EscuelaUser> userManager,
            SignInManager<EscuelaUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            var alumno = await getAlumnoAsync();

            ViewData["CursoId"] = new SelectList(_context.Cursos, "Id", "Nombre");

            return View(alumno);
        }

        //revisar bien esto para que se pueda editar el usuario
        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(Alumno _alumno)
        {
            var alumno = await getAlumnoAsync();

            alumno.Nombre= _alumno.Nombre;
            alumno.CursoId= _alumno.CursoId;

            _context.Update(alumno);
            await _context.SaveChangesAsync();

            ViewData["CursoId"] = new SelectList(_context.Cursos, "Id", "Nombre");

            return RedirectToAction(".");
        }

        private async Task<Alumno> getAlumnoAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            var alumno = _context.Alumnos.Find(user.AlumnoId);

            alumno.Curso = _context.Cursos.Find(alumno.CursoId);

            return alumno;
        }
    }


}
