using System;
using System.ComponentModel.Design;
using Entidades;
using Interfaces;
using Negocio;
using PersistenciaEdison;
using LightInject;
using Di.LightInject;

namespace Di
{
    class Program
    {

        static void Main(string[] args)
        {
            var container = new LightInject.ServiceContainer();

            container.Register<IFoo, Foo>();
            var instance = container.GetInstance<IFoo>();
            //Assert.IsInstanceOfType(instance, typeof(Foo));
            container.Register<IBar, Bar>();
            var foo = container.GetInstance<IFoo>();
            foo.DoFooStuff();

            Console.WriteLine("Hello World!");
            //IPersistencia persistencia = new Persistencia();
            //IPersistencia persistencia = null; //deberia instanciarse
            Secretaria secretaria = new Secretaria(foo);
            Estudiante estudiante = new Estudiante("Edison", "Molina");
            // crear los movimientos en el avatar
            Curso curso = new Curso("Programacion");

            //se  graba donde se indique el objeto persistencia

           secretaria.Matricular(estudiante, curso);
        }
    }
}
