namespace TechInnovate
{

    class Program
    {
        
        static void Main()
        {
            Backend.CargarDatos();
            int opcion = 0;

            while (opcion != 5)
            {
                Console.WriteLine("*|*|*|* Bienvenido a TechInnovate *|*|*|*");
                Console.WriteLine("1. Agregar nuevo proyecto\n2. Mostrar proyectos registrados\n" +
                    "3. Modificar un proyecto existente\n4. Eliminar proyecto registrado\n" +
                    "5. Guardar y Salir\n ");
                Console.WriteLine("Elija una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.Beep();
                        Backend.CrearProyecto();
                    break;

                    case 2:
                        Console.Clear();
                        Console.Beep();
                        Backend.MostrarProyectos();
                    break;

                    case 3:
                        Console.Clear();
                        Console.Beep();
                        Backend.ModificarProyecto();
                    break;

                    case 4:
                        Console.Clear();
                        Console.Beep();
                        Backend.EliminarProyecto();
                    break;

                    case 5:
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