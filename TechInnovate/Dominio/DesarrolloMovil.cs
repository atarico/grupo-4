namespace TechInnovate
{
    public class DesarrolloMovil : Proyecto
    {
        private List<PlataformaMovil> _listaPlataformas;

        public DesarrolloMovil(string nombre, int cantidadDesarrolladores, DateTime fechaInicio, Estado estado, Tipo tipoProyecto, List<PlataformaMovil> plataformas)
            : base(nombre, cantidadDesarrolladores, fechaInicio, estado, tipoProyecto)
        {
            _listaPlataformas = plataformas;
        }

        public override void DuracionDelProyecto()
        {
           
        }
    }
}
