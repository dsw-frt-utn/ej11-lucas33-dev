namespace Dsw2026Ej11.Tests;

using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

internal class Ejemplos
{
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        // Agregar 3 alumnos
        casoList.AgregarAlumno(new Alumno(1, "Lucas", 8.5));
        casoList.AgregarAlumno(new Alumno(2, "María", 7.2));
        casoList.AgregarAlumno(new Alumno(3, "Pedro", 6.0));

        // Listar alumnos
        Console.WriteLine("=== Lista de alumnos ===");
        foreach (var a in casoList.ObtenerAlumnos())
            Console.WriteLine(a);

        // Buscar alumno que existe
        Console.WriteLine("\n=== Buscar 'María' ===");
        var encontrado = casoList.BuscarPorNombre("María");
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

        // Buscar alumno que no existe
        Console.WriteLine("\n=== Buscar 'Carlos' ===");
        var noEncontrado = casoList.BuscarPorNombre("Carlos");
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

        // Eliminar un alumno y listar
        Console.WriteLine("\n=== Eliminar a Pedro ===");
        casoList.EliminarAlumno(new Alumno(3, "Pedro", 6.0));
        foreach (var a in casoList.ObtenerAlumnos())
            Console.WriteLine(a);

        // Eliminar el primer elemento y listar
        Console.WriteLine("\n=== Eliminar primer elemento ===");
        casoList.EliminarEnPosicion(0);
        foreach (var a in casoList.ObtenerAlumnos())
            Console.WriteLine(a);
    }

    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();

       
        casoDictionary.AgregarAlumno(new Alumno(1, "Lucas", 8.9));
        casoDictionary.AgregarAlumno(new Alumno(2, "Ignacio", 7.8));
        casoDictionary.AgregarAlumno(new Alumno(3, "Thomas", 7.3));

     
        Console.WriteLine("=== Diccionario de alumnos ===");
        foreach (var par in casoDictionary.ObtenerDiccionario())
            Console.WriteLine($"Clave: {par.Key} - {par.Value}");

      
        Console.WriteLine("\n=== Buscar clave 2 ===");
        var encontrado = casoDictionary.BuscarPorId(2);
        Console.WriteLine(encontrado != null ? encontrado.ToString() : "No existe");

       
        Console.WriteLine("\n=== Buscar clave 99 ===");
        var noEncontrado = casoDictionary.BuscarPorId(99);
        Console.WriteLine(noEncontrado != null ? noEncontrado.ToString() : "No existe");

      
        Console.WriteLine("\n=== Eliminar clave 1 ===");
        casoDictionary.EliminarAlumno(1);
        foreach (var par in casoDictionary.ObtenerDiccionario())
            Console.WriteLine($"Clave: {par.Key} - {par.Value}");
    }

    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();
        List<Libro> libros = Libro.CrearLista();

        Console.WriteLine("=== Primer libro ===");
        Console.WriteLine(casoLinq.GetPrimero(libros));

        Console.WriteLine("\n=== Último libro ===");
        Console.WriteLine(casoLinq.GetUltimo(libros));

        Console.WriteLine("\n=== Total precios ===");
        Console.WriteLine(casoLinq.GetTotalPrecios(libros).ToString("C"));

        Console.WriteLine("\n=== Promedio precios ===");
        Console.WriteLine(casoLinq.GetPromedioPrecios(libros).ToString("C"));

        Console.WriteLine("\n=== Libros con Id mayor a 15 ===");
        foreach (var l in casoLinq.GetListById(libros))
            Console.WriteLine(l.Titulo);

        Console.WriteLine("\n=== Título y precio ===");
        foreach (var s in casoLinq.GetLibros(libros))
            Console.WriteLine(s);

        Console.WriteLine("\n=== Libro más caro ===");
        Console.WriteLine(casoLinq.GetMayorPrecio(libros));

        Console.WriteLine("\n=== Libro más barato ===");
        Console.WriteLine(casoLinq.GetMenorPrecio(libros));

        Console.WriteLine("\n=== Libros sobre el promedio ===");
        foreach (var l in casoLinq.GetMayorPromedio(libros))
            Console.WriteLine(l.Titulo);

        Console.WriteLine("\n=== Libros ordenados por título descendente ===");
        foreach (var l in casoLinq.GetOrdenadosPorTituloDesc(libros))
            Console.WriteLine(l.Titulo);
    }
}