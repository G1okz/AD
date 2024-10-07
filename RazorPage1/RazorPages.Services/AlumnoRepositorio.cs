using RazorPages.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPages.Services
{
    public class AlumnoRepositorio : IAlumnoRepositorio

    {
        public List<Alumno> ListaAlumnos;
		public AlumnoRepositorio()
        {
            ListaAlumnos = new List<Alumno>()
            {
                new Alumno() {
                    Id = 1,
                    Nombre = "Javier Abad",
                    Email = "javierAbad@gmail.com",
                    Foto = "javier.jpg",
                    CursoId = Curso.H2
                },

                new Alumno() {
                    Id = 2,
                    Nombre = "Angeline Acevedo",
                    Email = "angelineAcevedo@gmail.com",
                    Foto = "angeline.jpg",
                    CursoId = Curso.H2
                },

                new Alumno() {
                    Id = 3,
                    Nombre = "Jorge Bernabeu",
                    Email = "jorgeBernabeu@gmail.com",
                    Foto = "jorge.jpg",
                    CursoId = Curso.H1
                },

                new Alumno() {
                    Id = 4,
                    Nombre = "Guillerno Bernal",
                    Email = "guillermoBernal@gmail.com",
                    Foto = "guillermo.jpg",
                    CursoId = Curso.E1
                },

                new Alumno()
                {
                    Id = 5,
                    Nombre = "Mariano Pepito",
                    Email = "",
                    Foto = ""            
                }
            };
        }
        public IEnumerable<Alumno> GetAllAlumnos()
        {
            return ListaAlumnos;
        }

        public Alumno GetAlumno(int id)
		{
			return ListaAlumnos.FirstOrDefault(a => a.Id == id);
		}

		/**
         *  Busca un alumno por su id y lo actualiza con los datos del alumno pasado como parámetro.
         */
		public Alumno Update(Alumno alumnoEdited)
        {
            Alumno alumno = ListaAlumnos.FirstOrDefault(a => a.Id == alumnoEdited.Id);
            alumno.Nombre = alumnoEdited.Nombre;
			alumno.Email = alumnoEdited.Email;
			alumno.CursoId = alumnoEdited.CursoId;
			return alumno;
		}
	}
}
