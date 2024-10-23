namespace TechInnovate
{
    abstract public class Proyecto
    {

        private string _nombreProyecto;
        private int _cantidadDesarrolladores;
        private DateTime _fechaInicio;
        private DateTime _fechaFinalizacion;
        private Estado _estadoProyecto;
        private Tipo _tipoDesarrollo;
        public Proyecto(string nombre, int cantidadDesarrolladores, DateTime fechaInicio, DateTime fechaFinalizacion, Estado estado, Tipo tipo)
        {
            _nombreProyecto = nombre;
            _cantidadDesarrolladores = cantidadDesarrolladores;
            _fechaInicio = fechaInicio;
            _fechaFinalizacion = fechaFinalizacion;
            _estadoProyecto = estado;
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
            set { if(!(value<=0) || !(value == null))_cantidadDesarrolladores = value;
                else 
                { Console.WriteLine("No puede elegir una cantidad de desarrolladores " +
                    "menor o igual a 0");
                    Console.ReadLine();
                    value = 1;
                }
                }
        }

        public DateTime FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }

        public DateTime FechaFinalizacion
        {
            get { return _fechaFinalizacion; }
            set { _fechaFinalizacion= value; }           
       
        }

        public Estado EstadoProyecto { get { return _estadoProyecto; } set { _estadoProyecto = value; } }
        public Tipo TipoDesarrollo { get { return _tipoDesarrollo; } set { _tipoDesarrollo = value; } }

        abstract public void DuracionDelProyecto();
    }
}
