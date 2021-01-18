using PersonajeDi;
using System;
using System.Collections.Generic;
using System.IO;

namespace PersonajeDi
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Bienvenidos al juego");

           Comportamientos comportamientos = new Comportamientos();
           Movimientos movimientos = new Movimientos(comportamientos);
           Avatar avatar = new Avatar("Santy");
           Mover mover = new Mover("Correr");

           movimientos.Accionar(avatar,mover);


        }
    }
}
    interface IComportamientos
    {
        public bool Grabar(Avatar avatar)
        {
            //to do
            File.AppendAllLines("Avatar.txt", new List<string> { avatar.ToString() });
            return true;
        }
        public bool Grabar(Mover mover)
        {
            //to do
            File.AppendAllLines("Accion.txt", new List<string> { mover.ToString() });
            return true;
        }

    }

