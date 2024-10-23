namespace TechInnovate
{
    public class DesarrolloWeb : Proyecto
    {
        private Tecnologia _tecnologia;
        public DesarrolloWeb(string nombre, int cantidadDesarrolladores, DateTime fechaInicio,DateTime fechaFinalizacion, Estado estado, Tipo tipoProyecto, Tecnologia tecnologia)
            : base(nombre, cantidadDesarrolladores, fechaInicio, fechaFinalizacion, estado, tipoProyecto) 
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
            Console.WriteLine("Cuantos desarrolladores tendrá su proyecto?: ");
            int cantidadDesarrolladores = int.Parse(Console.ReadLine());
                 
            int horasTotalesProyecto = 500;
            float horasSemana = 40;
            float semanasDeTrabajo = horasTotalesProyecto / horasSemana;
            float DuracionProyecto = semanasDeTrabajo / cantidadDesarrolladores;

            Console.WriteLine($"El proyecto durara {DuracionProyecto} semanas");
            
        }
    }
}
