using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpDDSAnual
{
    public struct Coordenada
    {
        public double latitud;
        public double longitud;
        public Coordenada(double lat, double longi)
        {
            latitud = lat;
            longitud = longi;
        }
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
