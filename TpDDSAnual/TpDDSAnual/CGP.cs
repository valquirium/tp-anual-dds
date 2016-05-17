using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpDDSAnual
{
    class CGP: Poi
    {
            //ATRIBUTOS//
      

        //METODOS PRINCIPALES//

        //CERCANIA con otra Coordenada (Sea coordenada de otro POI o de Consola)//
        public bool CercanoDe(Coordenada coordenadaDelOtroPunto, int comunaDelOtroPunto)
        { return (ZonaDeComuna == comunaDelOtroPunto); }
    }
}
