using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TpDDSAnual
{
    partial class Poi
    {
                                //Atributos de la clase//
        public string Nombre { get; set; }
        public Coordenada coordenada;
        public Direccion direccion;
        public int ZonaDeComuna { get; set; }

                        //Metodos PRINCIPALES//

        //Cercania con otra Coordenada//
        public bool CercanoDe(Coordenada coordenadaDelOtroPunto,int comunaDelOtroPunto)
        { return (DistanciaMenorA(coordenadaDelOtroPunto, 500)); }


     
     

    }
}






    //asdasdasd
