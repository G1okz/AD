using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Modelos;
using RazorPages.Services;

namespace RazorPage1.Pages.Alumnos
{
	public class ViewModel : PageModel
    {
		private readonly IAlumnoRepositorio alumnoRepositorio;
		public Alumno alumno;
        public ViewModel(IAlumnoRepositorio alumnoRepositorio)
        {
			this.alumnoRepositorio = alumnoRepositorio;
		}
        public void OnGet(int id)
        {
            alumno = alumnoRepositorio.GetAlumno(id);
		}
    }
}
