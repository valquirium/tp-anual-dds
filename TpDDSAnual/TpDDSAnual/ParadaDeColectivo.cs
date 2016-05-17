﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpDDSAnual
{
    class ParadaDeColectivo: Poi
    {               //ATRIBUTOS//
        public double CriterioDeCercania { get; set; }
        
                    //METODOS PRINCIPALES//

       //Disponibilidad horaria//
       public bool EstaDisponible()
        { return true; }

        //Cercania con otra Coordenada (Sea coordenada de otro POI o de Consola)//
        public bool CercanoDe(Coordenada coordenadaDelOtroPunto)
        { return (DistanciaMenorA(coordenadaDelOtroPunto, 100)); }


    }
    
            
    }
}
