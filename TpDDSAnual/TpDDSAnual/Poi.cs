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
        public double numero2;

                                //Metodos PRINCIPALES//
        //CERCANIA ENTRE DOS POI//
        public bool DistanciaMenorA(Poi puntoDeInteres, double metros)
        {
            if (GetDistance(coordenada, puntoDeInteres.coordenada) < metros)
            { return true; }
            else return false;
        }
     

    }
}



    


