using RazorPages.Modelos;
namespace RazorPages.Services

{
	public interface IAlumnoRepositorio
	{
		IEnumerable<Alumno> GetAllAlumnos();
		/**
		 Metodo que devuelve un alumno por su id.
		 Recibe un entero id y devuelve un objeto de tipo Alumno.
		*/
		Alumno GetAlumno(int id);

		Alumno Update(Alumno alumnoEdited);
	}

}
