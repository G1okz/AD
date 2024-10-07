using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Modelos;
using RazorPages.Services;

namespace RazorPage1.Pages.Alumnos
{
    public class EditModel : PageModel
    {
		private readonly IAlumnoRepositorio alumnoRepositorio;
		public Alumno alumno;
		public IFormFile Photo { get; set; }
		public EditModel(IAlumnoRepositorio alumnoRepositorio)
		{
			this.alumnoRepositorio = alumnoRepositorio;
		}
		public void OnGet(int id)
		{
			alumno = alumnoRepositorio.GetAlumno(id);
		}

		public IActionResult OnPost(Alumno alumno)
		{
			alumnoRepositorio.Update(alumno);
			return RedirectToPage("Index");
		}
		
	}
}
