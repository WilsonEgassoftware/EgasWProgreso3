using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgasWProgreso3.Modelos
{
    class Recetas
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Ingredientes { get; set; }    
        public string Instrucciones { get; set; }

        public int TiempodePreparacion { get; set; }

        public bool EsVegetariana { get; set; }
    }
}
