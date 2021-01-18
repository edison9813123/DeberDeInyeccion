namespace PersonajeDi
{
    class Movimientos
    {
        IComportamientos comportamientos;
        private Comportamientos comportamientos1;

        public Movimientos(IComportamientos comportamientos)
        {
            this.comportamientos = comportamientos;
        }

        public Movimientos(Comportamientos comportamientos1)
        {
            this.comportamientos1 = comportamientos1;
        }

        public string Accionar(Avatar avatar,Mover mover)
        {

            comportamientos.Grabar(avatar);
            comportamientos.Grabar(mover);
            return string.Format("El avatar se llama {0} {1}",
            avatar.Nombre,
            mover.Accion);
        }

    }
}
