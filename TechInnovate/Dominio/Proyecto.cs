namespace TechInnovate
{
    abstract public class Proyecto
    {

        private string _nombreProyecto;
        private int _cantidadDesarrolladores;
        private DateTime _fechaInicio;
        private Estado _estadoProyecto;
        private Tipo _tipoDesarrollo;
        public Proyecto(string nombre, int cantidadDesarrolladores, DateTime fechaInicio, Estado estado, Tipo tipo)
        {
            _nombreProyecto = nombre;
            _cantidadDesarrolladores = cantidadDesarrolladores;
            _fechaInicio = fechaInicio;
        }
        public Proyecto() { }
        public string Nombre
        {
            get { return _nombreProyecto; }
            set { _nombreProyecto = value; }
        }

        public int CantidadDesarrolladores
        {
            get { return _cantidadDesarrolladores; }
            set { _cantidadDesarrolladores = value; }
        }

        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }

        public Estado EstadoProyecto { get { return _estadoProyecto; } set { _estadoProyecto = value; } }
        public Tipo TipoDesarrollo { get { return _tipoDesarrollo; } set { _tipoDesarrollo = value; } }

        abstract public void DuracionDelProyecto();
    }
}
