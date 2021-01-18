using System.Collections.Generic;
using System.IO;

namespace PersonajeDi
{
    class Comportamientos 
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
}
