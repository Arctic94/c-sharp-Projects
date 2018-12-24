using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Solucion.Datos
{
    public class Conexion
    {
        private MySqlConnection con;

        public Conexion()
        {
            con = new MySqlConnection();
            con.ConnectionString =
                "Server=localhost;Port=3306;" +
                "Database=sismologia;Uid=root;Pwd=sql";

        }

        public void EjecutarComando(string comando)
        {
            con.Open();

            MySqlCommand sqlcmd =
                new MySqlCommand(comando, con);

            sqlcmd.ExecuteNonQuery();
            con.Close();
        }

        public SismoBase ObtieneSismo(string consulta)
        {
            con.Open();
            MySqlCommand sqlcmd =
                new MySqlCommand(consulta, con);

            MySqlDataReader reader = sqlcmd.ExecuteReader();

            SismoBase sb = new SismoBase();

            if (reader.Read())
            {
                sb.ID = reader.GetInt32("ID");
                sb.Comuna = reader.GetInt32("COMUNA");
                sb.Descripcion = reader.GetString("DESCRIPCION");
                sb.FechaEvento = reader.GetDateTime("FECHA_EVENTO");
                sb.Profundidad = reader.GetFloat("PROFUNDIDAD");
                sb.Intensidad = reader.GetFloat("INTENSIDAD");

                con.Close();

                return sb;
            }
            else
            {
                con.Close();
                return null;
            }
        }

        public List<SismoBase> ObtieneListasb(string consulta)
        {
            List<SismoBase> lstTemp = new List<SismoBase>();

            con.Open();

            MySqlCommand sqlcmd = new MySqlCommand(consulta, con);
            MySqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read())
            {
                SismoBase sb = new SismoBase();
                sb.ID = reader.GetInt32("ID");
                sb.Comuna = reader.GetInt32("COMUNA");
                sb.Descripcion = reader.GetString("DESCRIPCION");
                sb.FechaEvento = reader.GetDateTime("FECHA_EVENTO");
                sb.Profundidad = reader.GetFloat("PROFUNDIDAD");
                sb.Intensidad = reader.GetFloat("INTENSIDAD");
                lstTemp.Add(sb);
            }

            con.Close();
            return lstTemp;

        }

        public ComunaBase ObtieneComuna(string consulta)
        {
            con.Open();
            MySqlCommand sqlcmd =
                new MySqlCommand(consulta, con);

            MySqlDataReader reader = sqlcmd.ExecuteReader();

            ComunaBase cb = new ComunaBase();

            if (reader.Read())
            {
                cb.ID = reader.GetInt32("ID");
                cb.Nombre = reader.GetString("NOMBRE");
                

                con.Close();

                return cb;
            }
            else
            {
                con.Close();
                return null;
            }
        }

        public List<ComunaBase> ObtieneListacb(string consulta)
        {
            List<ComunaBase> lstTemp = new List<ComunaBase>();

            con.Open();

            MySqlCommand sqlcmd = new MySqlCommand(consulta, con);
            MySqlDataReader reader = sqlcmd.ExecuteReader();

            while (reader.Read())
            {
                ComunaBase cb = new ComunaBase();
                cb.ID = reader.GetInt32("ID");
                cb.Nombre = reader.GetString("NOMBRE");

                lstTemp.Add(cb);
            }

            con.Close();
            return lstTemp;

        }


    }
}
