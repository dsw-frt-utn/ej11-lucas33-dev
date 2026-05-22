namespace Dsw2026Ej11.Collections;

using Dsw2026Ej11.Domain;

public class CasoDictionary
{
   
    private Dictionary<int, Alumno> _alumnos = new Dictionary<int, Alumno>();

   
    public void AgregarAlumno(Alumno alumno)
    {
        _alumnos.Add(alumno.Id, alumno);
    }

    public Alumno? BuscarPorId(int id)
    {
        _alumnos.TryGetValue(id, out Alumno? alumno);
        return alumno;
    }

   
    public Dictionary<int, Alumno> ObtenerDiccionario()
    {
        return _alumnos;
    }

   
    public void EliminarAlumno(int id)
    {
        _alumnos.Remove(id);
    }
}