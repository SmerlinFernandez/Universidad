using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class AsignaturaQuery
    {
        public int CodigoAsignatura { get; set; }
        public string NombreAsignatura { get; set; }
        public string HorarioAsignatura { get; set; }

        public override string ToString()
        {
            return this.NombreAsignatura;
        }
    }
}

