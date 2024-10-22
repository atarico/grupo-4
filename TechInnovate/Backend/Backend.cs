﻿namespace TechInnovate
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
                            string nombre = datos[0];
                            string cantidadDesarrolladores = datos[1];
                            DateTime fechaInicio = DateTime.Parse(datos[2]);
                            Estado estadoProyecto = (Estado)Enum.Parse(typeof(Estado), datos[3]);
                            Tipo tipoDesarrollo = (Tipo)Enum.Parse(typeof(Tipo), datos[4]);
                            string[] plataformas = datos[5].Split(';');

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
            Console.WriteLine("Proyectos movil: \n");
            foreach(var proyecto in proyectosMovil)
            {
                Console.WriteLine($"Nombre:{proyecto.Nombre}\nCantidad de desarrolladores: {proyecto.CantidadDesarrolladores}\n" +
                    $"Fecha de inicio: {proyecto.FechaInicio}\nEstado: {proyecto.EstadoProyecto}\n" +
                    $"Tipo: {proyecto.TipoDesarrollo}\n");
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
                unProyecto.CantidadDesarrolladores = Console.ReadLine();
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
                unMovil.CantidadDesarrolladores = Console.ReadLine();
                Console.WriteLine("Ingrese la fecha de inicio del proyecto:");
                unMovil.FechaInicio = DateTime.Parse(Console.ReadLine());
                unMovil.TipoDesarrollo = Tipo.DESARROLLO_MOVIL;
                int ingreso = 0;
                Console.WriteLine("Ingrese cuantas plataformas tendra el proyecto: ");
                ingreso = int.Parse(Console.ReadLine());

                for (int i = 0; i < ingreso; i++)
                {
                    Console.WriteLine("Ingrese el o los nombres de plataformas que desee agregar");
                    unMovil.ListaPlataformas[i] = Console.ReadLine();
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

        static public void EliminarProyecto()
        {
            Console.WriteLine("Desea eliminar un proyecto web o movil? A) Web  B) Movil");
            string respuesta = Console.ReadLine();
            if(respuesta.Trim().ToLower() == "a")
            {
                foreach (var proyectoWeb in proyectosWeb)
                {
                    Console.WriteLine(proyectoWeb.Nombre);
                }
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
                foreach (var proyectoMovil in proyectosMovil)
                {
                    Console.WriteLine(proyectoMovil.Nombre);
                }
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
            Console.Clear();
        }

        static public void GuardarDatos()
        {
            using (StreamWriter writer = new StreamWriter(archivoProyectosMovil))
            {
                foreach (var proyectoMovil in proyectosMovil)
                {
                    writer.WriteLine($"{proyectoMovil.Nombre}," +
                        $"{proyectoMovil.CantidadDesarrolladores}," +
                        $"{proyectoMovil.FechaInicio}," +
                        $"{proyectoMovil.EstadoProyecto}," +
                        $"{proyectoMovil.TipoDesarrollo}");
                    foreach (var plataforma in proyectoMovil.ListaPlataformas)
                    {
                        writer.WriteLine(plataforma + ",");
                    }
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
