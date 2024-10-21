namespace TechInnovate
{
    abstract public class Proyecto
    {
        private string _nombreProyecto;
        private int _cantidadDesarrolladores;
        private DateTime _fechaInicio;
        private Estado _estadoProyecto;
        private Tipo _tipoDesarrollo;

        abstract public void DuracionDelProyecto();
    }
}
