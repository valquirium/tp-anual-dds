using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpDDSAnual
{
    class Consola
    {   //ATRIBUTOS//
        public Coordenada coordenada;
        public int Comuna { get; set; }

        //METODOS PRINCIPALES//
        public bool consultarCercania(Poi puntoDeInteres)
        {
            return puntoDeInteres.estaCerca(coordenada);
              
        }

    }
}
