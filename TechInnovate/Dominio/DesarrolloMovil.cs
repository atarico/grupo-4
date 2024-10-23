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
            Console.WriteLine("En cuantas plataformas será desarrollado? :");
            int plataformas = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantos archivos tendrá el proyecto aproximadamente?: ");
            int cantidadArchivos = int.Parse(Console.ReadLine());

            if(cantidadDesarrolladores*2 < cantidadArchivos)
            {
                Console.WriteLine("Según la fecha en la que inicie el proyecto, podría demorar:" +
                    $"{cantidadArchivos*2} semanas en ser completado correctamente.");
            }
            else { Console.WriteLine("Es probable que su proyecto no demore mucho mas de:" +
                $"{cantidadArchivos} semanas"); }
            if(plataformas >= 3 && cantidadDesarrolladores < cantidadArchivos)
            {
                Console.WriteLine("Es probable que su proyecto demore: " +
                    $"{cantidadDesarrolladores * cantidadArchivos} semanas");
            }
            if(cantidadArchivos == cantidadDesarrolladores)
            {
                Console.WriteLine($"Seguramente su proyecto dure entre una y dos semanas");
            }
        }
    }
}
