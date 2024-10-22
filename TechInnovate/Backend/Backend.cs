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
                        try
                        {
                            string[] datos = linea.Split(',');
                            string nombre = datos[0].ToString();
                            int cantidadDesarrolladores = int.Parse(datos[1]);
                            DateTime fechaInicio = DateTime.Parse(datos[2]);
                            Estado estadoProyecto = (Estado)Enum.Parse(typeof(Estado), datos[3]);
                            Tipo tipoDesarrollo = (Tipo)Enum.Parse(typeof(Tipo), datos[4]);
                            List<string> plataformas = datos[5].Split(';').ToList();

                            proyectosMovil.Add(new DesarrolloMovil(nombre, cantidadDesarrolladores, fechaInicio, estadoProyecto, tipoDesarrollo, plataformas));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error al procesar la línea: {linea} - {ex.Message}");
                        }
                    }
                }
            }

            if (File.Exists(archivoProyectosWeb))
            {
                using (StreamReader reader = new StreamReader(archivoProyectosWeb))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        string nombre = datos[0].ToString();
                        int cantidadDesarrolladores = int.Parse(datos[1]);
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
            Console.WriteLine("Proyectos móviles: \n");
            foreach (var proyecto in proyectosMovil)
            {
                // Imprimir los datos principales del proyecto
                Console.WriteLine($"Nombre: {proyecto.Nombre}\n" +
                                  $"Cantidad de desarrolladores: {proyecto.CantidadDesarrolladores}\n" +
                                  $"Fecha de inicio: {proyecto.FechaInicio.ToString("yyyy-MM-dd")}\n" +
                                  $"Estado: {proyecto.EstadoProyecto}\n" +
                                  $"Tipo: {proyecto.TipoDesarrollo}");

                // Imprimir las plataformas asociadas
                Console.WriteLine("Plataformas:");
                foreach (var plataforma in proyecto.ListaPlataformas)
                {
                    Console.WriteLine($"- {plataforma}");
                }

                // Línea separadora entre proyectos
                Console.WriteLine("\n----------------------------\n");
            }

        Console.WriteLine("\n");
            Console.WriteLine("Proyectos web: \n");
            foreach (var proyectoWeb in proyectosWeb)
            {
                Console.WriteLine($"Nombre:{proyectoWeb.Nombre}\nCantidad de desarrolladores: {proyectoWeb.CantidadDesarrolladores}\n" +
                    $"Fecha de inicio: {proyectoWeb.FechaInicio}\nEstado: {proyectoWeb.EstadoProyecto}\n" +
                    $"Tipo: {proyectoWeb.TipoDesarrollo}\nTecnologia asociada: {proyectoWeb.Tecnologia}\n");
            }
            Console.WriteLine("\n");
        }

        static public void CrearProyecto()
        {
            Console.WriteLine("Tipee que tipo de proyecto desea crear: A) Desarrolo Web o B) Desarrolo Movil");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower().Trim() == "a")
            {
                DesarrolloWeb unProyecto = new DesarrolloWeb();
                
                Console.WriteLine("Ingrese nombre del proyecto:");
                unProyecto.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad de desarrolladores que requiere:");
                unProyecto.CantidadDesarrolladores = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la fecha de inicio del proyecto:");
                unProyecto.FechaInicio = DateTime.Parse(Console.ReadLine());
                unProyecto.TipoDesarrollo= Tipo.DESARROLLO_WEB;
                Console.WriteLine("Ingrese el tipo de tecnologia asociada: 1.Angular , 2.React y 3.Vue_js");
                int opcion = int.Parse(Console.ReadLine());
                
                switch (opcion)
                {
                    case 1:
                    unProyecto.Tecnologia = Tecnologia.ANGULAR;
                    break;

                    case 2:
                    unProyecto.Tecnologia = Tecnologia.REACT;
                    break;

                    case 3:
                    unProyecto.Tecnologia = Tecnologia.VUE_JS;
                    break;

                    default:
                    break;
                }
                proyectosWeb.Add(unProyecto);

            }
            else if(respuesta.Trim().ToLower() == "b")
            {
                DesarrolloMovil unMovil = new DesarrolloMovil();
                Console.WriteLine("Ingrese nombre del proyecto:");
                unMovil.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad de desarrolladores que requiere:");
                unMovil.CantidadDesarrolladores = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la fecha de inicio del proyecto: (DD/MM/AAAA)");
                unMovil.FechaInicio = DateTime.Parse(Console.ReadLine());
                unMovil.TipoDesarrollo = Tipo.DESARROLLO_MOVIL;
                string seleccion = "";
                while(seleccion.Trim().ToLower() != "n")
                {
                    Console.WriteLine("Desea agregar alguna plataforma a la lista?: (S/N)");
                    string eleccion = Console.ReadLine();
                    if(eleccion.ToLower().Trim() == "n") { break; }
                    else
                    {
                        Console.WriteLine("Escriba el nombre de la plataforma: ");
                        string agregar = Console.ReadLine();
                        unMovil.ListaPlataformas.Add(agregar);
                    }
                    
                }
                proyectosMovil.Add(unMovil);
            }
            else
            {
                Console.WriteLine("Seleccion incorrecta...");
                Console.ReadLine();
            }
            Console.Clear();
        }
        static public void MostrarProyectosWeb()
        {
            foreach (var proyectoWeb in proyectosWeb)
            {
                Console.WriteLine(proyectoWeb.Nombre);
            }
        }
        static public void MostrarProyectosMovil()
        {
            foreach (var proyectoMovil in proyectosMovil)
            {
                Console.WriteLine(proyectoMovil.Nombre);
            }
        }

        static public void EliminarProyecto()
        {
            Console.WriteLine("Desea eliminar un proyecto web o movil? A) Web  B) Movil");
            string respuesta = Console.ReadLine();
            if(respuesta.Trim().ToLower() == "a")
            {
                MostrarProyectosWeb();
                bool encontrado = false;
                Console.WriteLine("Cual desea eliminar?");
                DesarrolloWeb proyecto = new DesarrolloWeb();
                string eliminacion = Console.ReadLine();
                foreach (var proyectoWeb in proyectosWeb)
                {
                    if(eliminacion.Trim().ToLower() == proyectoWeb.Nombre)
                    {
                        encontrado = true;
                        proyecto = proyectoWeb;
                        
                    }
                }
                if (!encontrado) { Console.WriteLine("No fue encontrado ese proyecto, escribalo correctamente."); }
                else 
                {
                    proyectosWeb.Remove(proyecto);
                    Console.WriteLine("Eliminado correctamente."); 
                }
            }
            else if(respuesta.Trim().ToLower() == "b")
            {
                MostrarProyectosMovil();
                bool encontrado = false;
                Console.WriteLine("Cual desea eliminar?");
                string eliminacion = Console.ReadLine();
                DesarrolloMovil proyecto = new DesarrolloMovil();
                foreach (var proyectoMovil in proyectosMovil)
                {
                    if (eliminacion.Trim().ToLower() == proyectoMovil.Nombre)
                    {
                        encontrado = true;
                        proyecto = proyectoMovil;
                    }
                }
                if (!encontrado) { Console.WriteLine("No fue encontrado ese proyecto, escribalo correctamente."); }
                else 
                {
                    proyectosMovil.Remove(proyecto);
                    Console.WriteLine("Eliminado correctamente."); 
                }
            }
            else { Console.WriteLine("Opcion incorrecta..."); Console.ReadKey(); }
            
        }

        static public void ModificarProyecto()

        {
            if (proyectosMovil == null) proyectosMovil = new List<DesarrolloMovil>();
            if (proyectosWeb == null) proyectosWeb = new List<DesarrolloWeb>();
            Console.WriteLine("Modificar proyecto:  A) Web    B) Movil");
            string respuesta = Console.ReadLine();
            if(respuesta.Trim().ToLower() == "a")
            {
                MostrarProyectosWeb();
                bool encontrado = false;
                Console.WriteLine("Escriba el nombre del proyecto a modificar:");
                string modificacion = Console.ReadLine();
                foreach(var proyectoWeb in proyectosWeb)
                {
                    if (modificacion.Trim().ToLower() == proyectoWeb.Nombre.Trim().ToLower())
                    {
                        encontrado = true;
                        Console.WriteLine("Ingrese el nombre del proyecto:");
                        proyectoWeb.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese la cantidad de desarrolladores: ");
                        proyectoWeb.CantidadDesarrolladores = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la fecha de inicio: (DD/MM/AAAA)");
                        proyectoWeb.FechaInicio = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el estado del proyecto:" +
                            "1. Planificacion" +
                            "2. En desarrollo" +
                            "3. En pruebas" +
                            "4. Completado" +
                            "5. Cancelado");
                        int opcion = int.Parse(Console.ReadLine());
                        switch (opcion)
                        {
                            case 1:
                                proyectoWeb.EstadoProyecto = Estado.PLANIFICACION;
                                break;
                            case 2:
                                proyectoWeb.EstadoProyecto = Estado.EN_DESARROLLO;
                                break;
                            case 3:
                                proyectoWeb.EstadoProyecto = Estado.EN_PRUEBAS;
                                break;
                            case 4:
                                proyectoWeb.EstadoProyecto = Estado.COMPLETADO;
                                break;
                            case 5:
                                proyectoWeb.EstadoProyecto = Estado.CANCELADO;
                                break;
                            default:
                                Console.WriteLine("Opcion invalida...");
                                break;
                        }
                        Console.WriteLine("Ingrese la tecnología del proyecto:" +
                            "1. Angular" +
                            "2. React" +
                            "3. Vue.Js ");
                        int opcionTecnologia = int.Parse(Console.ReadLine());
                        switch (opcionTecnologia)
                        {
                            case 1:
                                proyectoWeb.Tecnologia = Tecnologia.ANGULAR;
                                break;
                            case 2:
                                proyectoWeb.Tecnologia = Tecnologia.REACT;
                                break;
                            case 3:
                                proyectoWeb.Tecnologia = Tecnologia.VUE_JS;
                                    break;
                            default:
                                Console.WriteLine("Opcion incorrecta...");
                                break;

                        }
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("Proyecto no encontrado...");
                }
                else
                {
                    Console.WriteLine("Modificado con éxito!");
                }
                
            }
            else if(respuesta.Trim().ToLower() == "b")
            {
                MostrarProyectosMovil();
                Console.WriteLine("Seleccione el proyecto introduciendo el nombre: ");
                string nombre = Console.ReadLine();
                bool encontrado = false;
                foreach(var proyecto in proyectosMovil)
                {
                    if(proyecto.Nombre.Trim().ToLower() == nombre.Trim().ToLower())
                    {
                        encontrado = true;
                        Console.WriteLine("Ingrese el nombre del proyecto:");
                        proyecto.Nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese la cantidad de desarrolladores: ");
                        proyecto.CantidadDesarrolladores = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la fecha de inicio: (DD/MM/AAAA)");
                        proyecto.FechaInicio = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el estado del proyecto:" +
                            "1. Planificacion" +
                            "2. En desarrollo" +
                            "3. En pruebas" +
                            "4. Completado" +
                            "5. Cancelado");
                        int opcion = int.Parse(Console.ReadLine());
                        switch (opcion)
                        {
                            case 1:
                                proyecto.EstadoProyecto = Estado.PLANIFICACION;
                                break;
                            case 2:
                                proyecto.EstadoProyecto = Estado.EN_DESARROLLO;
                                break;
                            case 3:
                                proyecto.EstadoProyecto = Estado.EN_PRUEBAS;
                                break;
                            case 4:
                                proyecto.EstadoProyecto = Estado.COMPLETADO;
                                break;
                            case 5:
                                proyecto.EstadoProyecto = Estado.CANCELADO;
                                break;
                            default:
                                Console.WriteLine("Opcion invalida...");
                                break;
                        }
                        Console.WriteLine("¿Desea modificar las plataformas? (s/n)");
                        string modificarPlataformas = Console.ReadLine().Trim().ToLower();
                        if (modificarPlataformas == "s")
                        {
                            Console.WriteLine("Ingrese las plataformas separadas por ';':");
                            string plataformasInput = Console.ReadLine();
                            proyecto.ListaPlataformas = plataformasInput.Split(';').ToList();
                        }
                        break;
                    }
                }
                if (!encontrado) { Console.WriteLine("Proyecto no encontrado..."); }
                else
                {
                    Console.WriteLine("Modificado con éxito!");
                }
            }
            else
            {
                Console.WriteLine("Opcion invalida...");
                Console.ReadKey();
            }
            Console.Clear();
        }

        static public void GuardarDatos()
        {
            using (StreamWriter writer = new StreamWriter(archivoProyectosMovil))
            {
                foreach (var proyectoMovil in proyectosMovil)
                {
                    string plataformasConcatenadas = string.Join(";", proyectoMovil.ListaPlataformas);
                    writer.WriteLine($"{proyectoMovil.Nombre}," +
                                     $"{proyectoMovil.CantidadDesarrolladores}," +
                                     $"{proyectoMovil.FechaInicio.ToString("yyyy-MM-dd")}," +
                                     $"{proyectoMovil.EstadoProyecto}," +
                                     $"{proyectoMovil.TipoDesarrollo}," +
                                     $"{plataformasConcatenadas}");
                }
            }  
            using (StreamWriter writer2 = new StreamWriter(archivoProyectosWeb))
            {
                foreach (var proyectoWeb in proyectosWeb)
                {
                    writer2.WriteLine($"{proyectoWeb.Nombre},{proyectoWeb.CantidadDesarrolladores},{proyectoWeb.FechaInicio}," +
                                      $"{proyectoWeb.EstadoProyecto}," +
                                      $"{proyectoWeb.TipoDesarrollo}," +
                                      $"{proyectoWeb.Tecnologia}");
                }
            }

        }

    }
}
