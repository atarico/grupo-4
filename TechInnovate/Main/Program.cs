namespace TechInnovate
{
    class Program
    {
        
        static void Main()
        {
            Backend.CargarDatos();
            int opcion = 0;

            while (opcion != 7)
            {
                Console.WriteLine("-------------Bienvenido a TechInnovate-------------");
                Console.WriteLine("" +
                    "1. Agregar nuevo proyecto\n" +
                    "2. Mostrar proyectos registrados\n" +
                    "3. Modificar un proyecto existente\n" +
                    "4. Eliminar proyecto registrado\n" +
                    "5. Mostrar proyectos completados\n" +
                    "6. Estimar duración del proyecto\n" +
                    "7. Guardar y Salir\n ");
                Console.WriteLine("Elija una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Backend.CrearProyecto();
                    break;

                    case 2:
                        Console.Clear();
                        Backend.MostrarProyectos();
                    break;

                    case 3:
                        Console.Clear();
                        Backend.ModificarProyecto();
                    break;

                    case 4:
                        Console.Clear();
                        Backend.EliminarProyecto();
                    break;

                    case 5:
                        Console.Clear();
                        Backend.MostrarProyectosCompletados();
                        break;

                    case 6:
                        Console.Clear();
                        Backend.EstimarDuracionProyecto();    
                    break;

                    case 7:
                        Backend.GuardarDatos();
                        Console.WriteLine("Guardando y saliendo del sistema...");
                    break;

                    default:
                    Console.WriteLine("La opcion ingresada no es correcta, intentelo de nuevo");
                    break;
                }

            }
            
        }

    }
}