using System.Collections.Generic;
using System.IO;
using Interfaces;
using Entidades;

namespace DAtosOtro
{
    class PersistenciaDos : IPersistencia
    {
        public bool Grabar(Estudiante estudiante)
        {
            //to do
            File.AppendAllLines("Estudiante.txt", new List<string> { estudiante.Nombre});
            return true;
        }
        public bool Grabar(Curso curso)
        {
            //to do
            File.AppendAllLines("Curso.txt", new List<string> { curso.Nombre});
            return true;
        }
        public bool Grabar(EstudiantePorCurso estudiantePorCurso)
        {
            //to do
            File.AppendAllLines("EstudiantePorCurso.txt", new List<string> { estudiantePorCurso.CursoId.ToString() });
            return true;
        }

    }
}
