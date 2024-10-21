namespace TechInnovate
{
    public class DesarrolloMovil : Proyecto
    {
        private string[] _listaPlataformas;

        public DesarrolloMovil(string nombre, string cantidadDesarrolladores, DateTime fechaInicio, Estado estado, Tipo tipoProyecto, string[] plataformas)
            : base(nombre, cantidadDesarrolladores, fechaInicio, estado, tipoProyecto)
        {
            _listaPlataformas = plataformas;
            tipoProyecto = Tipo.DESARROLLO_MOVIL;
        }

        public string[] Plataformas { get { return _listaPlataformas; } set { _listaPlataformas = value; } }
        
        public override void DuracionDelProyecto()
        {
           
        }
    }
}
