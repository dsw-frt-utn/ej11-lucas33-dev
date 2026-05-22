namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;

public class CasoLinq
{
    // 1. Obtener el primer libro
    public Libro GetPrimero(List<Libro> libros)
    {
        return libros.First();
    }

    // 2. Obtener el último libro
    public Libro GetUltimo(List<Libro> libros)
    {
        return libros.Last();
    }

    // 3. Obtener la suma de precios
    public decimal GetTotalPrecios(List<Libro> libros)
    {
        return libros.Sum(l => l.Precio);
    }

    // 4. Obtener el promedio de precios
    public decimal GetPromedioPrecios(List<Libro> libros)
    {
        return libros.Average(l => l.Precio);
    }

    // 5. Obtener libros con Id mayor a 15
    public List<Libro> GetListById(List<Libro> libros)
    {
        return libros.Where(l => l.Id > 15).ToList();
    }

    // 6. Obtener lista con título y precio en formato moneda
    public List<string> GetLibros(List<Libro> libros)
    {
        return libros.Select(l => $"{l.Titulo} - {l.Precio:C}").ToList();
    }

    // 7. Obtener el libro con el precio más alto
    public Libro? GetMayorPrecio(List<Libro> libros)
    {
        return libros.MaxBy(l => l.Precio);
    }

    // 8. Obtener el libro con el precio más bajo
    public Libro? GetMenorPrecio(List<Libro> libros)
    {
        return libros.MinBy(l => l.Precio);
    }

    // 9. Obtener libros cuyo precio sea mayor al promedio
    public List<Libro> GetMayorPromedio(List<Libro> libros)
    {
        decimal promedio = libros.Average(l => l.Precio);
        return libros.Where(l => l.Precio > promedio).ToList();
    }

    // 10. Obtener libros ordenados por título de forma descendente
    public List<Libro> GetOrdenadosPorTituloDesc(List<Libro> libros)
    {
        return libros.OrderByDescending(l => l.Titulo).ToList();
    }
}