using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpDDSAnual
{
    class Program
    { static void Main(string[] args)
        {
        }
    }

    class Poi
    {
        //Atributos de la clase//
        private string Nombre { get; set; }
        private Coordenada coordenada;
        private Direccion direccion;

        //Setters y getters de los atributos//
        //Structs de la clase//
        public struct Coordenada
        {
          public float latitud;
          public float longitud;
          public Coordenada (float lat, float longi)
            { latitud = lat;
              longitud = longi; }
         }
        public struct Direccion
        {
            public int altura;
            public string callePrincipal;
            public Direccion(int alt, string calle)
            {
                altura = alt;
                callePrincipal = calle;
            }

        }
     }
       
 
    

    
}
