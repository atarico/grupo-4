namespace TechInnovate
{
    public class Backend
    {
        static public void CargarDatos()
        {

        }

        static public void MostrarProyectos()
        {

        }

        static public void CrearProyecto()
        {
            Console.WriteLine("Tipee que tipo de proyecto desea crear: Desarrolo Web o Desarrolo Movil");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower().Trim() == "desarrolloweb")
            {
                Console.WriteLine("Ingrese nombre del proyecto:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad de desarrolladores que requiere:");
                int cantidadDesarrolladores = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la fecha de inicio del proyecto:");
                DateTime fechaInicio = DateTime.Parse(Console.ReadLine());


                
            }


        }

        static public void EliminarProyecto()
        {

        }

        static public void ModificarProyecto()
        {

        }

        static public void GuardarDatos()
        {

        }

    }
}
