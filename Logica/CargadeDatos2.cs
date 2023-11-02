using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class OperacionesP
    {
        UniversidadEntidades db = new UniversidadEntidades();

        public IQueryable<ProfesorQuery> CargarProfesores()
        {
            var datos = db.Profesor.Select(x => new ProfesorQuery
            {
                IdProfesor = x.IdProfesor,
                NombreProfesor = x.NombreProfesor,
                ApellidoProfesor = x.ApellidoProfesor
            });

            return datos;
        }

        public IQueryable<ProfesorQuery> CargarProfesores(string NombreProfesor)
        {

            var seleccion = db.Profesor.Where(x => x.NombreProfesor.ToLower().Contains(NombreProfesor.ToLower()));
            var datos = seleccion.Select(x => new ProfesorQuery 
            { 
                IdProfesor = x.IdProfesor,
                NombreProfesor = x.NombreProfesor,
                ApellidoProfesor = x.ApellidoProfesor
            
            });

            return datos;
        }


        public void AgregarProfesor(string NombreProfesor, string ApellidoProfesor)
        {
            db.Profesor.Add(new Profesor
            {
                NombreProfesor = NombreProfesor,
                ApellidoProfesor = ApellidoProfesor

            });

            db.SaveChanges();
        }

        public void EliminarProfesor(int IdProfesor)
        {
            var profesor = db.Profesor.Find(IdProfesor);
            db.Profesor.Remove(profesor);
            db.SaveChanges();
        }

        public IQueryable<EstudianteQuery> CargarEstudiantes()
        {
            var datos = db.Estudiante.Select(x =>
               new EstudianteQuery
               {
                   Matricula = x.Matricula,
                   NombreEstudiante = x.NombreEstudiante,
                   ApellidoEstudiante = x.ApellidoEstudiante,
                   Carrera = x.Carrera.NombreCarrera
               }
                );
            return datos;
        }
        public IQueryable<EstudianteQuery> CargarEstudiantes(string NombreEstudiante)
        {

            var seleccion = db.Estudiante.Where(x => x.NombreEstudiante.ToLower().Contains(NombreEstudiante.ToLower()));
            var datos = seleccion.Select(x => new EstudianteQuery
            {
                NombreEstudiante = x.NombreEstudiante,
                ApellidoEstudiante = x.ApellidoEstudiante,
                Carrera = x.Carrera.NombreCarrera
              
            });

            return datos;
        }

        public void AgregarEstudiante(string NombreEstudiante, string ApellidoEstudiante, string Contraseña, int CodigoCarrera)
        {
            if (NombreEstudiante != string.Empty && ApellidoEstudiante != string.Empty && Contraseña != string.Empty)
            {
                db.Estudiante.Add(new Estudiante
                {
                    NombreEstudiante = NombreEstudiante,
                    ApellidoEstudiante = ApellidoEstudiante,
                    PasswordEstudiante = Contraseña,
                    CodigoCarrera = CodigoCarrera

                }
                );

                db.SaveChanges();
            }
        }


        public int DevolverIdCarrera(string NombreCarrera)
        {
            var seleccion = db.Carrera.Where(x => x.NombreCarrera.ToLower().Equals(NombreCarrera.ToLower()));
            var datos = seleccion.Select(x => new CarreraQuery
            {
                CodigoCarrera = x.CodigoCarrera
            });

            int ID = datos.ToList()[0].CodigoCarrera;
            return ID;

        }


    }
}
