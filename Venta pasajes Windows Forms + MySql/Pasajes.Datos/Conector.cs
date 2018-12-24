using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;

namespace Pasajes.Datos
{
    public class Conector
    {

        private MySqlConnection con;

        public Conector()
        {
            con=new MySqlConnection();
            con.ConnectionString = "Server=localhost;Port=3306;Database=PASAJES;Uid=root;Pwd=sql";
        }

        public void EjecutarComando(string comando)
        {
            con.Open();
            MySqlCommand sqlcmd = new MySqlCommand(comando, con);
            sqlcmd.ExecuteNonQuery();

            con.Close();
        }

        public DatoPasaje ObtienePasaje(string consulta)
        {
            con.Open();
            MySqlCommand sqlcmd = new MySqlCommand(consulta, con);
            MySqlDataReader reader =sqlcmd.ExecuteReader();
            DatoPasaje dp=new DatoPasaje();

            if (reader.Read())
            {
                dp.Id = (int)reader[0];
                dp.Nombre = reader[1].ToString();
                dp.Rut = reader[2].ToString();
                dp.Sexo = reader[3].ToString();
                dp.FechaNacimiento = (DateTime)reader[4];
                dp.Direccion = reader[5].ToString();
                dp.TelefonoAccidente = reader[6].ToString();
                dp.TelefonoPersonal = reader[7].ToString();
                dp.Destino = reader[8].ToString();
                dp.FechaViaje = (DateTime)reader[9];
                return dp;
            }
            else
            {
                con.Close();
                return null;
            }
        }

        public DatoPasajeAereo ObtienePasajeAereo(string consulta)
        {
            con.Open();
            MySqlCommand sqlcmd = new MySqlCommand(consulta, con);
            MySqlDataReader reader = sqlcmd.ExecuteReader();
            DatoPasajeAereo dpa = new DatoPasajeAereo();

            if (reader.Read())
            {

                dpa.Id_aereo = (int)reader[0];
                dpa.Id_pasaje = (int)reader[1];
                dpa.Nombre_aeropuerto = reader[2].ToString();
                dpa.Tipo_aeronave = reader[3].ToString();
                
                
                return dpa;
            }
            else
            {
                con.Close();
                return null;
            }
        }

        public List<DatoPasaje> ObtieneLista(string consulta)
        {
            List<DatoPasaje> lst = new List<DatoPasaje>();
            con.Open();

            MySqlCommand sqlcmd= new MySqlCommand(consulta,con);

            MySqlDataReader reader =sqlcmd.ExecuteReader();

            while(reader.Read())
            {
                DatoPasaje dp=new DatoPasaje();

                dp.Id = (int)reader[0];
                dp.Nombre = reader[1].ToString();
                dp.Rut = reader[2].ToString();
                dp.Sexo = reader[3].ToString();
                dp.FechaNacimiento = (DateTime)reader[4];
                dp.Direccion = reader[5].ToString();
                dp.TelefonoAccidente = reader[6].ToString();
                dp.TelefonoPersonal = reader[7].ToString();
                dp.Destino = reader[8].ToString();
                dp.FechaViaje = (DateTime)reader[9];

                lst.Add(dp);
            }
            con.Close();
            return lst;
        }


        
    }
}
