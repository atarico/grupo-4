namespace TechInnovate
{
    public class DesarrolloWeb : Proyecto
    {
        private Tecnologia _tecnologia;
        public DesarrolloWeb(string nombre, int cantidadDesarrolladores, DateTime fechaInicio, Estado estado, Tipo tipoProyecto, Tecnologia tecnologia)
            : base(nombre, cantidadDesarrolladores, fechaInicio, estado, tipoProyecto) 
        {
            _tecnologia = tecnologia;
            tipoProyecto = Tipo.DESARROLLO_WEB;
        }
        public DesarrolloWeb() : base() { }
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
