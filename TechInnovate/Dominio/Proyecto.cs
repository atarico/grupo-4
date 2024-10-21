namespace TechInnovate
{
    abstract public class Proyecto
    {

        private string _nombreProyecto;
        private int _cantidadDesarrolladores;
        private DateTime _fechaInicio;
        private Estado _estadoProyecto;
        private Tipo _tipoDesarrollo;
        public Proyecto(string nombre, int cantidadDesarrolladores, DateTime fechaInicio, Estado estado, Tipo tipo){}

        abstract public void DuracionDelProyecto();
    }
}
