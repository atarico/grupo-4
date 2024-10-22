

namespace TechInnovate
{
    public class DesarrolloMovil : Proyecto
    {
        private List<string> _listaPlataformas = new List<string>();

        public DesarrolloMovil(string nombre, int cantidadDesarrolladores, DateTime fechaInicio, Estado estado, Tipo tipoProyecto, List<string> plataformas)
            : base(nombre, cantidadDesarrolladores, fechaInicio, estado, tipoProyecto)
        {
            _listaPlataformas = plataformas;
            tipoProyecto = Tipo.DESARROLLO_MOVIL;
        }
        public DesarrolloMovil() : base() { }
        public List<string> ListaPlataformas 
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
