using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    public class Corriente:Cuenta
    {
        private int _cantGiros;
        private DateTime _fechaCuenta;
        private long _numCuenta;
        private string _nombreE;
        private string _fonoE;
        private string _correoE;

        public Corriente(string tipoCuenta,string rut,string nombre, string sucursal, double saldo, DateTime fechaGiro, int monto, int cantGiros, DateTime fechaCuenta, long numCuenta, string nE, string fE, string cE)
            : base(tipoCuenta, rut, nombre ,sucursal , saldo, fechaGiro, monto)
        {
            NumCuenta = numCuenta;
            FechaCuenta = fechaCuenta;
            CantGiros = cantGiros;
            NombreE = nE;
            FonoE = fE;
            CorreoE = cE;
        }

	public string CorreoE
	{
		get { return _correoE;}
		set { _correoE = value;}
	}
	

	public string FonoE
	{
		get { return _fonoE;}
		set { _fonoE = value;}
	}
	

	public string NombreE
	{
		get { return _nombreE;}
		set { _nombreE = value;}
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
            
            if (ah.DiasCuenta(FechaCuenta) > 365  && ah.CantGiros <= 2)
            {
                ah.Saldo = ah.Saldo + ah.Saldo * 0.037;
            }
            else { Console.WriteLine("error: antiguedad de cuenta:"+ah.DiasCuenta(FechaCuenta)+"cantidad de giros: "+ah.CantGiros); }
        }*/

        public void AplicaComisiones(Corriente co)
        {
            if(DiasCuenta(co.FechaCuenta)>30)
            {
                co.Saldo = co.Saldo - ((DiasCuenta(co.FechaCuenta) / 30) * 2500);
            }
        }

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

                if (MontoGiro + monto <= 300000)
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
                return saldo;
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
            sb.AppendLine(string.Format("nombre ejectuvo: {0}", NombreE));
            sb.AppendLine(string.Format("fono ejecutivo: {0}", FonoE));
            sb.AppendLine(string.Format("correo ejecutivo: {0}", CorreoE));
            sb.AppendLine(string.Format("--------------------------"));

            return sb.ToString();
        }

        
    }
    }

