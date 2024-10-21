namespace TechInnovate
{

    class Program
    {
        static void Main()
        {
            int opcion = 0;

            while (opcion != 5)
            {
                Console.WriteLine("*|*|*|* Bienvenido a TechInnovate *|*|*|*");
                Console.WriteLine("1. Agregar nuevo proyecto\n2. Mostrar proyectos registrados\n" +
                    "3. Modificar un proyecto existente\n4. Eliminar proyecto registrado\n" +
                    "4. Cargar datos\n 5. Guardar y Salir\n ");
                Console.WriteLine("Elija una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                    break;

                    case 2:
                    break;

                    case 3:
                    break;

                    case 4:
                    break;

                    case 5:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                    default:
                    Console.WriteLine("La opcion ingresada no es correcta, intentelo de nuevo");
                    break;
                }

            }
            
            //mateo: cargar, guardar y modificar ,desarrollo movil y desarrollo web

            //jor: agregar, mostrar y eliminar, enums, proyecto , y el menu
        }

    }
}