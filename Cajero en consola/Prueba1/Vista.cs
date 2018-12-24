using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    public class Vista : Cuenta
    {
        private int _cantGiros;
        private DateTime _fechaCuenta;
        private long _numCuenta;

        public Vista(string tipoCuenta, string rut, string nombre, string sucursal, double saldo, DateTime fechaGiro, int monto, int cantGiros, DateTime fechaCuenta, long numCuenta)
            : base(tipoCuenta, rut, nombre, sucursal, saldo, fechaGiro, monto)
        {
            NumCuenta = numCuenta;
            FechaCuenta = fechaCuenta;
            CantGiros = cantGiros;

        }

        public long NumCuenta
        {
            get { return _numCuenta; }
            set
            {

                _numCuenta = value;


            }
        }


        public DateTime FechaCuenta
        {
            get { return _fechaCuenta; }
            set { _fechaCuenta = value; }
        }




        public int CantGiros
        {
            get { return _cantGiros; }
            set { _cantGiros = value; }
        }

        public int DiasCuenta(DateTime fecha)
        {
            TimeSpan dias;
            dias = DateTime.Now - fecha;
            return dias.Days;
        }

       /* public void AplicaIntereses(Ahorro ah)
        {

            if (ah.DiasCuenta(FechaCuenta) > 365 && ah.CantGiros <= 2)
            {
                ah.Saldo = ah.Saldo + ah.Saldo * 0.037;
            }
            else { Console.WriteLine("error: antiguedad de cuenta:" + ah.DiasCuenta(FechaCuenta) + "cantidad de giros: " + ah.CantGiros); }
        }*/

        public override double Giro(double saldo, DateTime fechaG)
        {

            Console.WriteLine("ingrese monto a girar");
            String monto1 = Console.ReadLine();
            int monto;


            if (int.TryParse(monto1, out monto))
            {
                if (fechaG.DayOfYear != DateTime.Today.DayOfYear)
                {
                    MontoGiro = 0;
                }

                if (MontoGiro + monto <= 250000)
                {
                    saldo = saldo - monto;
                    CantGiros++;
                    FechaGiro = DateTime.Today;
                    MontoGiro = MontoGiro + monto;
                }
                else
                {
                    Console.WriteLine("monto diario superado");
                    return saldo;
                }
                return saldo-100;
            }
            else
            {
                Console.WriteLine("monto invalido");
                return saldo;
            }
        }

        public override int Deposito(int saldo)
        {

            Console.WriteLine("ingrese monto a depositar");
            string monto = Console.ReadLine();
            saldo = saldo + int.Parse(monto);
            return saldo;

        }


        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(string.Format("Numero de cuenta: {0}", NumCuenta));
            sb.AppendLine(string.Format("Dias de apertura: {0}", DiasCuenta(FechaCuenta)));
            sb.AppendLine(string.Format("--------------------------"));

            return sb.ToString();
        }



    }
}
