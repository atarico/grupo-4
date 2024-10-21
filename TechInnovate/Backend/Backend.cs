using System.Diagnostics.Contracts;
using System.Reflection.PortableExecutable;

namespace TechInnovate
{
    public class Backend
    {
        static List<DesarrolloMovil> proyectosMovil = new List<DesarrolloMovil>();
        static List<DesarrolloWeb> proyectosWeb = new List<DesarrolloWeb>();
        static string archivoProyectosMovil = "proyectosMovil.txt";
        static string archivoProyectosWeb = "proyectosWeb.txt";
        static public void CargarDatos()
        {
            if (File.Exists(archivoProyectosMovil))
            {
                using (StreamReader reader = new StreamReader(archivoProyectosMovil))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] datos = linea.Split('|');
                        string nombre = datos[0];
                        string cantidadDesarrolladores = datos[1];
                        DateTime fechaInicio = DateTime.Parse(datos[2]);
                        Estado estadoProyecto = (Estado)Enum.Parse(typeof(Estado), datos[3]);
                        Tipo tipoDesarrollo = (Tipo)Enum.Parse(typeof(Tipo), datos[4]);
                        string[] plataformas = datos[5].Split(',');

                        proyectosMovil.Add(new DesarrolloMovil(nombre, cantidadDesarrolladores, fechaInicio, estadoProyecto, tipoDesarrollo, plataformas));
                    }
                }
            }

            if (File.Exists(archivoProyectosWeb))
            {
                using (StreamReader reader = new StreamReader(archivoProyectosWeb))
                {
                    string linea2;
                    while ((linea2 = reader.ReadLine()) != null)
                    {
                        string[] datos = linea2.Split('|');
                        string nombre = datos[0];
                        string cantidadDesarrolladores = datos[1];
                        DateTime fechaInicio = DateTime.Parse(datos[2]);
                        Estado estadoProyecto = (Estado)Enum.Parse(typeof(Estado), datos[3]);
                        Tipo tipoDesarrollo = (Tipo)Enum.Parse(typeof(Tipo), datos[4]);
                        Tecnologia tecnologia = (Tecnologia)Enum.Parse(typeof(Tecnologia), datos[5]);

                        proyectosWeb.Add(new DesarrolloWeb(nombre, cantidadDesarrolladores, fechaInicio, estadoProyecto, tipoDesarrollo, tecnologia));
                    }
                }
                
            }
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
            using (StreamWriter writer = new StreamWriter(archivoProyectosMovil))
            {
                foreach (var proyectoMovil in proyectosMovil)
                {
                    writer.WriteLine($"{proyectoMovil.Nombre}" +
                        $"{proyectoMovil.CantidadDesarrolladores}" +
                        $"{proyectoMovil.FechaInicio}" +
                        $"{proyectoMovil.EstadoProyecto}" +
                        $"{proyectoMovil.TipoDesarrollo}");
                    foreach(var plataforma in proyectoMovil.Plataformas)
                    {
                        writer.WriteLine(plataforma);
                    }
                }

                foreach(var proyectoWeb in proyectosWeb)
                {
                    writer.WriteLine($"{proyectoWeb.Nombre}" +
                        $"{proyectoWeb.CantidadDesarrolladores}" +
                        $"{proyectoWeb.FechaInicio}" +
                        $"{proyectoWeb.EstadoProyecto}" +
                        $"{proyectoWeb.TipoDesarrollo}" +
                        $"{proyectoWeb.Tecnologia}");
                }
            }
        }

    }
}
