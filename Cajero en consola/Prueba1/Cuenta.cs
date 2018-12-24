using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba1
{
    public abstract class Cuenta
    {
        
        private string _tipoCuenta;
        private string _rut;
        private string _nombre;
        private string _sucursal;
        private double _saldo;
        private DateTime _fechaGiro;
        private int _montoGiro;

        public int MontoGiro
        {
            get { return _montoGiro; }
            set { _montoGiro = value; }
        }
        

        public DateTime FechaGiro
        {
            get { return _fechaGiro; }
            set { _fechaGiro = value; }
        }
        

        public Cuenta(string tipoCuenta, string rut, string nombre, string sucursal, double saldo, DateTime fecha, int monto)
        {
            TipoCuenta = tipoCuenta;
            Rut = rut;
            Nombre = nombre;
            Sucursal = sucursal;
            Saldo = saldo;
            FechaGiro = fecha;
            MontoGiro = monto;
            
        }

       

        


        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }


        public string Sucursal
        {
            get { return _sucursal; }
            set { _sucursal = value; }
        }


        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        public string Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }


        public string TipoCuenta
        {
            get { return _tipoCuenta; }
            set 
            {
                if (value.Equals("empresa") || value.Equals("persona"))
                {
                    
                    _tipoCuenta = value;
                }
                else { Console.WriteLine("error, valido empresa o persona"); }
                
            }
        }




        public abstract double Giro(double saldo, DateTime fecha);
        public abstract int Deposito(int saldo);
        

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            
            sb.AppendLine(string.Format("Tipo de cuenta: {0}", _tipoCuenta));
            sb.AppendLine(string.Format("Rut: {0}", _rut));
            sb.AppendLine(string.Format("Nombre: {0}", _nombre));
            sb.AppendLine(string.Format("Sucursal: {0}", _sucursal));
            sb.AppendLine(string.Format("Saldo: {0}", _saldo));

            return sb.ToString();
        }

    }
}
