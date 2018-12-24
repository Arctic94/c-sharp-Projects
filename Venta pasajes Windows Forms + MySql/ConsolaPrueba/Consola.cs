using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pasajes.Negocio;
using Pasajes.Datos;

namespace ConsolaPrueba
{
    public class Consola
    {
        static void Main(string[] args)
        {
            //PasajeAereo pasaje_Aereo_Prueba = new PasajeAereo(1,"juan", "123-1", "13/2/1990", "masculino", "calle111", "999555", "555999", "valdivia", "20/7/2016", "juangomesvenito", "Avion",2);
            //Pasaje pasajePrueba = new Pasaje(1, "maria", "222-2", "13/2/1990", "femenimo", "calle#123", "7890", "223344", "anotofagasta", "20/6/1016");

            //Pasaje psj = new Pasaje() { Id = 2 };

            PasajeAereo asd = new PasajeAereo() { Id = 12 };
            asd.EliminarPasajeAereo();

           // PasajeTerrestre pst = new PasajeTerrestre(15, "caca", "111", new DateTime(1990, 12, 12), "1", "fsdf", "555", "333", "stgo", new DateTime(2016, 12, 12), 1, "san borja", "22");
          //  pst.CreatePasajeTerrestre();

            //PasajeAereo psard = new PasajeAereo() { Id = 1, IdAereo=1 };
            
            //psard.ReadPasajeAereo();

            //Console.WriteLine("asd"+psard.NombreAeropuerto);



            /*psa.IdAereo = 1;
            psa.NombreAeropuerto = "jgb";
            psa.TipoAeronave = "avioneta";
            psa.RutPasajero = "7878";
            psa.NombrePasajero = "fabian";
            psa.Sexo = "0";
            psa.TelefonoAccidente = "123";
            psa.TelefonoPersonal = "321";
            psa.FechaNacimiento = new DateTime(1994, 30, 11);
            psa.FechaViaje = new DateTime(2016, 5, 7);
            psa.DestinoViaje = "valdivia";
            psa.DireccionPasajero = "santiago";*/

            //psa.CreatePasajeAereo();




            /*psj.RutPasajero = "18905";
            psj.NombrePasajero = "juanito";
            psj.Sexo = "1";
            psj.TelefonoAccidente = "911";
            psj.TelefonoPersonal = "777";
            psj.FechaNacimiento = DateTime.Parse("1995-03-13");
            psj.DireccionPasajero = "calle555";
            psj.DestinoViaje = "buenos aires";
            psj.FechaViaje = DateTime.Parse("2016-07-15");*/
            
           // psj.Read();
            //Console.WriteLine(psj.RutPasajero);
            //Console.WriteLine(psj.DestinoViaje);

            //psj.RutPasajero = "18954";
           // psj.FechaNacimiento=new DateTime(1984,9,14);

            //psj.Update();
            //Console.WriteLine(psj.RutPasajero);
            //Console.WriteLine(psj.FechaNacimiento);

            


            
            /*
            //psj.FechaNacimiento.GetDateTimeFormats('s');

            string fecha = psj.FechaNacimiento.ToString("u");
            fecha = fecha.Replace("Z", " ");
            fecha.Trim();
            
            
            psj.FechaNacimiento = Convert.ToDateTime(fecha);
            
            Console.WriteLine(psj.FechaNacimiento);

            Console.WriteLine(psj.Create());*/



            ColeccionPasaje cp = new ColeccionPasaje();
            

            foreach (Pasaje p in cp.ListarPasajes())
            {
                Console.WriteLine(p.RutPasajero);
            }

            Console.ReadKey();

            


        }

        private static void Base()
        {
            throw new NotImplementedException();
        }
    }
}
