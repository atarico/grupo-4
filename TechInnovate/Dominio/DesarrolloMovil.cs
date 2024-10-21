

namespace TechInnovate
{
    public class DesarrolloMovil : Proyecto
    {
        private string [] _listaPlataformas;

        public DesarrolloMovil(string nombre, string cantidadDesarrolladores, DateTime fechaInicio, Estado estado, Tipo tipoProyecto, string[] plataformas)
            : base(nombre, cantidadDesarrolladores, fechaInicio, estado, tipoProyecto)
        {
            _listaPlataformas = plataformas;
            tipoProyecto = Tipo.DESARROLLO_MOVIL;
        }
        public DesarrolloMovil() : base() { }
        public string [] ListaPlataformas 
        { 
            get { return _listaPlataformas; } 
            set { _listaPlataformas = value; } 
        }
        public void ListarPlataformas()
        {
            foreach (var plataforma in  _listaPlataformas)
            {
                Console.WriteLine(plataforma);
            }
        }
        
        public override void DuracionDelProyecto()
        {
           
        }
    }
}
