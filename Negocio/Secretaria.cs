using Entidades;
using Interfaces;

namespace Negocio
{
    public class Secretaria
    {
        public  IPersistencia Persistencia  { get; set; }
        public IFoo Foo { get; set; }
        //guardar los movimien tos
       
        public Secretaria(IPersistencia persistencia)
        {
            this.Persistencia = persistencia;
        }

        public Secretaria(IFoo foo)
        {
            this.Foo = foo;

        }


        public string Matricular(Estudiante estudiante, Curso curso)
        {
            Foo.Grabar(estudiante);
            Foo.Grabar(curso);
            Foo.Grabar(new EstudiantePorCurso{EstudianteId = estudiante.Id, CursoId = curso.Id });
            return string.Format("El estudiante se matriculo {0} {1} se matriculò en el curso de {2}",
                estudiante.Nombre,
                estudiante.Apellido,
                curso.Nombre);


        }
    }
}
