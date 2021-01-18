using System.Collections.Generic;
using System.IO;
using Entidades;
using Interfaces;

namespace PersistenciaEdison
{
    //guardar los datos en texto
    public class Persistencia : IPersistencia
    {
        public bool Grabar(Estudiante estudiante)
        {
            //to do
            File.AppendAllLines("Estudiante.txt", new List<string> { estudiante.ToString() });
            return true;
        }
        public bool Grabar(Curso curso)
        {
            //to do
            File.AppendAllLines("Curso.txt", new List<string> { curso.ToString() });
            return true;
        } 
        public bool Grabar(EstudiantePorCurso estudiantePorCurso)
        {
            //to do
            File.AppendAllLines("EstudiantePorCurso.txt", new List<string> { estudiantePorCurso.ToString() });
            return true;
        }

    }

    class PersistenciaTres : IPersistencia
    {
        public bool Grabar(Estudiante estudiante)
        {
            //to do
            throw new System.NotImplementedException();
        }
        public bool Grabar(Curso curso)
        {
            //to do
            throw new System.NotImplementedException();
        }
        public bool Grabar(EstudiantePorCurso estudiantePorCurso)
        {
            //to do
            throw new System.NotImplementedException();
        }
    }
}


//inventar un personaje de un juego y lo que haga es inyectar conportamientos para caminar , trotar, pelear  