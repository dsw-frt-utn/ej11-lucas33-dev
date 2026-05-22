namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;

public class CasoList
{
    private List<Alumno> _alumnos = new List<Alumno>();

    public void AgregarAlumno(Alumno alumno)
    {
        _alumnos.Add(alumno);
    }

    public IEnumerable<Alumno> ObtenerAlumnos()
    {
        return _alumnos;
    }

    public Alumno? BuscarPorNombre(string nombre)
    {
        return _alumnos.FirstOrDefault(a => a.Nombre == nombre);
    }

    public void EliminarAlumno(Alumno alumno)
    {
        _alumnos.Remove(alumno);
    }

    public void EliminarEnPosicion(int posicion)
    {
        _alumnos.RemoveAt(posicion);
    }
}