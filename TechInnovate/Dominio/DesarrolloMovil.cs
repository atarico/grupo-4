namespace TechInnovate
{
    public class DesarrolloMovil : Proyecto
    {
        private List<string> _listaPlataformas = new List<string>();

        public DesarrolloMovil(string nombre, int cantidadDesarrolladores, DateTime fechaInicio, DateTime fechaFinalizacion, Estado estado, Tipo tipoProyecto, List<string> plataformas)
            : base(nombre, cantidadDesarrolladores, fechaInicio, fechaFinalizacion, estado, tipoProyecto)
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
            Console.WriteLine("Cuantos desarrolladores tendrá su proyecto?: ");
            int cantidadDesarrolladores = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantas plataformas tendra su proyecto?:");
            int cantidadPlataformas = int.Parse(Console.ReadLine());

            int horasParcialesProyecto = 500;
            int horasPorPlataforma = 20;
            int horasTotalesPlataformas = horasPorPlataforma * cantidadPlataformas;
            int horasTotalesProyecto = horasParcialesProyecto + horasTotalesPlataformas;
            float horasSemana = 40;
            float semanasDeTrabajo = horasTotalesProyecto / horasSemana;
            float DuracionProyecto = semanasDeTrabajo / cantidadDesarrolladores;

            Console.WriteLine($"El proyecto durara {DuracionProyecto} semanas");
        }
    }
}
