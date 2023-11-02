
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;


namespace Logica
{
    public class Operaciones
    {
        UniversidadEntidades db = new UniversidadEntidades();
        public IQueryable<CarreraQuery> CargarDatos()
        {
                
                var datos = db.Carrera.Select(x => new CarreraQuery {
                    CodigoCarrera = x.CodigoCarrera, 
                    NombreCarrera = x.NombreCarrera 
                });

                return datos;
        }

        public IQueryable<CarreraQuery> CargarDatos(string NombreCarrera)
        {
            var seleccion = db.Carrera.Where(x => x.NombreCarrera.ToLower().Contains(NombreCarrera.ToLower()));
            var datos = seleccion.Select(x => new CarreraQuery
            {
                    CodigoCarrera = x.CodigoCarrera,
                    NombreCarrera = x.NombreCarrera
                    
            });

            return datos;

        }



        public IQueryable<AsignaturaQuery> CargarAsignaturas(int IdCarrera)
        {
            var seleccion = db.Carrera_Asignatura.Where(x => x.CodigoCarrera == IdCarrera);
            var datos = seleccion.Select(x => new AsignaturaQuery
            {
                CodigoAsignatura = x.CodigoAsignatura,
                NombreAsignatura = x.Asignatura.NombreAsignatura,
                HorarioAsignatura = x.Asignatura.HorarioAsignatura
            });

            return datos;
        }

        public IQueryable<AsignaturaQuery> CargarAsignaturas(int IdCarrera,string NombreAsignatura)
        {
            var seleccion = db.Carrera_Asignatura.Where
                (x => x.CodigoCarrera == IdCarrera && x.Asignatura.NombreAsignatura.ToLower().Contains(NombreAsignatura.ToLower()));
            
            var datos = seleccion.Select(x => new AsignaturaQuery
            {
               CodigoAsignatura = x.CodigoAsignatura,
               NombreAsignatura = x.Asignatura.NombreAsignatura,
               HorarioAsignatura = x.Asignatura.HorarioAsignatura

            });

            return datos;

        }

        public void AgregarCarrera(string nombreCarrera)
        {
           if (nombreCarrera != string.Empty)
            {
                db.Carrera.Add(new Carrera { NombreCarrera = nombreCarrera });
                db.SaveChanges();
                
            }
                         
        }

        public void AgregarAsignatura(string NombreAsignatura, string HorarioAsignatura)
        {
            if(NombreAsignatura != string.Empty && HorarioAsignatura != string.Empty)
            {
                db.Asignatura.Add(new Asignatura
                { NombreAsignatura = NombreAsignatura,HorarioAsignatura = HorarioAsignatura             
                }
                );
                db.SaveChanges();
            }
        }

        public void AgregarAsignaturaCarrera(int CodigoCarrera, int CodigoAsignatura)
        {
            db.Carrera_Asignatura.Add(new Carrera_Asignatura { CodigoCarrera = CodigoCarrera,CodigoAsignatura = CodigoAsignatura });
            db.SaveChanges();
        }

        public void EliminarCarrera(int IDCarrera)
        {
            var datos = db.Carrera.Find(IDCarrera);
            db.Carrera.Remove(datos);
            db.SaveChanges();
        }

        public void EliminarAsignatura(int CodigoAsignatura)
        {
            var asignatura =  db.Asignatura.Find(CodigoAsignatura);
            var asignaturacarrera = db.Carrera_Asignatura.Where(x => x.CodigoAsignatura == CodigoAsignatura);
            var IdEntidad = asignaturacarrera.Select(x => new Carrera_Asignatura {ID = x.ID});
            int ID = asignaturacarrera.ToList()[0].ID;
            var Entidadaeliminar = db.Carrera_Asignatura.Find(ID);
            db.Asignatura.Remove(asignatura);
            db.Carrera_Asignatura.Remove(Entidadaeliminar);
            db.SaveChanges();
        }



        public string DevolverNombreCarrera(int IDCarrera)
        {

            var datos = db.Carrera.Find(IDCarrera);
            string nombre = datos.NombreCarrera.ToString();

            return nombre;
        }

        public IQueryable<AsignaturaQuery> CargarAsignaturas(string NombreAsignatura)
        {
            var seleccion = db.Asignatura.Where(x => x.NombreAsignatura.ToLower() == NombreAsignatura);

            var datos = seleccion.Select(x => new AsignaturaQuery
            {
                CodigoAsignatura =  x.CodigoAsignatura,
                NombreAsignatura = x.NombreAsignatura
            });

            return datos;

        }

    }


}
