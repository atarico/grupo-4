namespace TechInnovate
{
    public class DesarrolloWeb : Proyecto
    {
        private Tecnologia _tecnologia;
        public DesarrolloWeb(string nombre, string cantidadDesarrolladores, DateTime fechaInicio, Estado estado, Tipo tipoProyecto, Tecnologia tecnologia)
            : base(nombre, cantidadDesarrolladores, fechaInicio, estado, tipoProyecto) 
        {
            _tecnologia = tecnologia;
            tipoProyecto = Tipo.DESARROLLO_WEB;
        }

        public Tecnologia Tecnologia
        {
            get { return _tecnologia; }
            set {  _tecnologia = value; }
        }
        public override void DuracionDelProyecto()
        {
            
        }
    }
}
