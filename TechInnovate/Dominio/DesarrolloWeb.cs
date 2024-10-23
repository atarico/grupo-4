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
            Console.WriteLine("Cuantos desarrolladores tendrá su proyecto?: ");
            int cantidadDesarrolladores = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantos archivos tendrá el proyecto aproximadamente?: ");
            int cantidadArchivos = int.Parse(Console.ReadLine());

            if (cantidadDesarrolladores * 2 < cantidadArchivos)
            {
                Console.WriteLine("Según la fecha en la que inicie el proyecto, podría demorar:" +
                    $"{cantidadArchivos} semanas en ser completado correctamente.");
            }
            else
            {
                Console.WriteLine("Es probable que su proyecto no demore mucho mas de:" +
                $"{cantidadArchivos-1} semanas");
            }
            if (cantidadArchivos == cantidadDesarrolladores)
            {
                Console.WriteLine($"Seguramente su proyecto dure entre una y dos semanas");
            }
        }
    }
}
