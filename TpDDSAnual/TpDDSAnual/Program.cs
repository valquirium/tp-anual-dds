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
            //CREO UN PUNTO DE INTERES CON SUS ATRIBUTOS//
            Poi kiosko= new Poi();
            kiosko.Nombre = "carlitos";
            kiosko.coordenada = new Coordenada(100, 506);
            kiosko.direccion = new Direccion(1682, "lerroux");
           
            //MUESTRO POR PANTALLA RESULTADOS//
            Console.Write("El punto de interes se llama: ");
            Console.WriteLine(kiosko.Nombre);
            Console.Write("Las coordenadas del punto de interes son:");
            Console.WriteLine("latitud: {0}, longitud:{1}",kiosko.coordenada.latitud, kiosko.coordenada.longitud);
            Console.Write("La direccion es:");
            Console.WriteLine("{0} {1}",kiosko.direccion.callePrincipal, kiosko.direccion.altura);



        }
    }

    
}
