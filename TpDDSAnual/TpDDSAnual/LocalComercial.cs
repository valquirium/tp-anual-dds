using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpDDSAnual
{
    class LocalComercial: Poi 
    {
                 //ATRIBUTOS//
        public double CriterioDeCercania { get; set; }
        double[][] horarioDeAtencion;

                    //METODOS PRINCIPALES//
        //Cercania con otra Coordenada (Sea coordenada de otro POI o de Consola)//
        public bool CercanoDe(Coordenada coordenadaDelOtroPunto)
        { return (DistanciaMenorA(coordenadaDelOtroPunto, CriterioDeCercania)); }

    }
}
