using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace PersistenciaEdison
{
    public class Foo : IFoo
    {
        // this property is automatically populated!
        public IBar MyBar { get; set; }

        public void DoFooStuff()
        {
            MyBar.DoBarStuff();
            Console.WriteLine("Foo está haciendo una actividad.");
        }
        public bool Grabar(Estudiante estudiante)
        {
            //to do
            File.AppendAllLines("Estudiante.txt", new List<string> { estudiante.Nombre });
            return true;
        }
        public bool Grabar(Curso curso)
        {
            //to do
            File.AppendAllLines("Curso.txt", new List<string> { curso.Nombre });
            return true;
        }
        public bool Grabar(EstudiantePorCurso estudiantePorCurso)
        {
            //to do
            File.AppendAllLines("EstudiantePorCurso.txt", new List<string> { estudiantePorCurso.ToString() });
            return true;
        }
    }
}
