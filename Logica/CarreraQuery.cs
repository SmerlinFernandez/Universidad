using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CarreraQuery
    {
        public int CodigoCarrera { get; set; }
        public string NombreCarrera { get; set; }

        public override string ToString()
        {
            return this.NombreCarrera;
        }
    }
}
