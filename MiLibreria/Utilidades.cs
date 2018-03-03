using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using primeraAplicacion;

namespace MiLibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string query)
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=agenda;Integrated Security=True");
            connection.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(query, connection);
            DP.Fill(DS);
            connection.Close();

            return DS;

        }
        public static void EjecutarInsert(string query)
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=agenda;Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public static List<Evento> EjecutarSelectAll(string query)
        {
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=agenda;Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader  reader = cmd.ExecuteReader();
            List<Evento> misEventos = new List<Evento>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                        reader.GetDateTime(1), reader.GetString(2));
                    Evento asd = new Evento(reader.GetInt32(0),
                        reader.GetDateTime(1), reader.GetString(2), reader.GetInt32(3));
                    misEventos.Add(asd);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            reader.Close();
            connection.Close();

            return misEventos;
        }
    }
}
