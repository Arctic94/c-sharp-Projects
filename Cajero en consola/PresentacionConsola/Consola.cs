using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Prueba1;
namespace PresentacionConsola
{
    class Consola
    {
        static void Main(string[] args)
        {
            ArrayList c_ahorro = new ArrayList();
            ArrayList c_corriente = new ArrayList();
            ArrayList c_vista = new ArrayList();

            c_ahorro.Add(new Prueba1.Ahorro("empresa", "21555678-8", "bisis s.a", "maipu",5500000,new DateTime(2015,12,10),0,1,new DateTime(2012,10,09),50188888890));
            //c_ahorro.Add(new Prueba1.Ahorro("persona", "11555678-8", "juana", "tacna", 15000000, new DateTime(2016, 04, 11), 0, 3, new DateTime(2015, 12, 12), 50188788888));
            //c_ahorro.Add(new Prueba1.Ahorro("empresa", "25555678-8", "bisimoto", "maipu", 50000, new DateTime(2015, 12, 10), 0, 0, new DateTime(2010, 12, 12), 50188668888));

            c_corriente.Add(new Prueba1.Corriente("persona", "18905237-7", "pedro", "maria pinto", 800000, new DateTime(2015, 10, 09), 0, 1, new DateTime(2008, 10, 01), 60211111111, "juanito", "555-12345", "juanito@mail.cl"));

            c_vista.Add(new Prueba1.Vista("persona", "11555678-8", "camila", "pte alto", 12500000, new DateTime(2016, 01, 02), 0, 3, new DateTime(2005, 10, 09), 70488888890));
            /*foreach(Ahorro c in c_ahorro)
            {
               if(c.Rut.Equals("21555678-8"))
               {
                   Console.WriteLine(c.MostrarDatos());
                   Console.WriteLine(c.CantGiros);
                   c.Saldo=c.Giro(c.Saldo, c.FechaGiro);
                   Console.WriteLine(c.CantGiros);
                   Console.WriteLine(c.MostrarDatos());
                   c.AplicaIntereses(c);
                   Console.WriteLine(c.MostrarDatos());
               }
                
            }*/
            try
            {

                string opcion = string.Empty;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1: ingresar cuenta");
                Console.WriteLine("2: mostrar cuentas");
                Console.WriteLine("3: salir");
                opcion = Console.ReadLine();


                switch (opcion)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("1. Ingresar cuenta ahorro.");
                        Console.WriteLine("2. Ingresar cuenta corriente.");
                        Console.WriteLine("3. Ingresar cuenta vista.");
                        Console.WriteLine("4. Volver.");
                        opcion = Console.ReadLine();

                        switch (opcion)
                        {
                            case "1":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("por cada variable ingresada aprete enter e ingrese la siguiente");
                                Console.WriteLine("ingrese tipoCuenta, rut, nombre,  sucursal,  saldo,  fechaGiro,   monto girado durante hoy,  cantGiros,  fechaCuenta,  numCuenta en el orden dado");
                                string tc = Console.ReadLine();
                                string rut = Console.ReadLine();
                                string nmb = Console.ReadLine();
                                string sucur = Console.ReadLine();
                                string sald = Console.ReadLine();
                                string fechaG = Console.ReadLine();
                                string monto = Console.ReadLine();
                                string cantG = Console.ReadLine();
                                string fechC = Console.ReadLine();
                                string numC = Console.ReadLine();

                                c_ahorro.Add(new Prueba1.Ahorro(tc, rut, nmb, sucur, double.Parse(sald), DateTime.Parse(fechaG), int.Parse(monto), int.Parse(cantG), DateTime.Parse(fechC), long.Parse(numC)));
                                Console.WriteLine("cuenta agregada");
                                break;

                            case "2":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("por cada variable ingresada aprete enter e ingrese la siguiente");
                                Console.WriteLine("ingrese tipoCuenta, rut, nombre, sucursal, saldo, fechaGiro, monto girado durante hoy, cantGiros, fecha inicio Cuenta, numero Cuenta, nomb Ej, fono Ej, correo Ej en el orden dado");
                                string tc1 = Console.ReadLine();
                                string rut1 = Console.ReadLine();
                                string nmb1 = Console.ReadLine();
                                string sucur1 = Console.ReadLine();
                                string sald1 = Console.ReadLine();
                                string fechaG1 = Console.ReadLine();
                                string monto1 = Console.ReadLine();
                                string cantG1 = Console.ReadLine();
                                string fechC1 = Console.ReadLine();
                                string numC1 = Console.ReadLine();
                                string nE = Console.ReadLine();
                                string fE = Console.ReadLine();
                                string cE = Console.ReadLine();
                                c_ahorro.Add(new Prueba1.Corriente(tc1, rut1, nmb1, sucur1, double.Parse(sald1), DateTime.Parse(fechaG1), int.Parse(monto1), int.Parse(cantG1), DateTime.Parse(fechC1), long.Parse(numC1), nE, fE, cE));
                                Console.WriteLine("cuenta agregada");
                                break;
                            case "3":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("por cada variable ingresada aprete enter e ingrese la siguiente");
                                Console.WriteLine("ingrese tipoCuenta, rut, nombre,  sucursal,  saldo,  fechaGiro,  monto girado durante hoy ,  cantGiros,  fechaCuenta,  numCuenta en el orden dado");
                                string tc2 = Console.ReadLine();
                                string rut2 = Console.ReadLine();
                                string nmb2 = Console.ReadLine();
                                string sucur2 = Console.ReadLine();
                                string sald2 = Console.ReadLine();
                                string fechaG2 = Console.ReadLine();
                                string monto2 = Console.ReadLine();
                                string cantG2 = Console.ReadLine();
                                string fechC2 = Console.ReadLine();
                                string numC2 = Console.ReadLine();
                                c_vista.Add(new Prueba1.Vista(tc2, rut2, nmb2, sucur2, double.Parse(sald2), DateTime.Parse(fechaG2), int.Parse(monto2), int.Parse(cantG2), DateTime.Parse(fechC2), long.Parse(numC2)));
                                Console.WriteLine("cuenta agregada");
                                break;
                            case "4":

                                break;

                        }

                        break;

                    case "2":
                        Console.ForegroundColor = ConsoleColor.White;
                        foreach (Corriente c in c_corriente)
                        {
                            Console.WriteLine(c.MostrarDatos());

                        }
                        foreach (Ahorro c in c_ahorro)
                        {
                            Console.WriteLine(c.MostrarDatos());

                        }
                        foreach (Vista c in c_vista)
                        {
                            Console.WriteLine(c.MostrarDatos());

                        }
                        Console.ReadKey();

                        break;

                    case "3":
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("saliendo....");
                        Console.WriteLine("saliendo....");
                        Console.WriteLine("saliendo....");
                        Console.WriteLine("saliendo....aprete una tecla para salir");
                        Console.ReadKey();
                        break;

                }
            }
            catch (ArgumentException ae)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ae.Message);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }

            

            
            
        }
        

    }
}
