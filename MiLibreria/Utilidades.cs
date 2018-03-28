using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb ;
using System.Data.SqlClient;
using primeraAplicacion;

namespace MiLibreria
{
    public class Utilidades
    {
        //private string con = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C: \\Users\\Cristian Mejia\\Source\\Repos\\Agenda3\\primeraAplicacion\\DBagenda.mdb";
        public static DataSet Ejecutar(string query)
        {

            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\pablo\\Documents\\programas\\cs\\Agenda3\\primeraAplicacion\\DBagenda.mdb");
            connection.Open();
            DataSet DS = new DataSet();
            OleDbDataAdapter DP = new OleDbDataAdapter(query, connection);
            DP.Fill(DS);
            connection.Close();
            return DS;
            /*
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=agenda;Integrated Security=True");
            SqlDataAdapter DP = new SqlDataAdapter(query, connection);
            
            

            
            */
        }
        public static void EjecutarInsert(string query)
        {
            OleDbConnection connection = new OleDbConnection ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\pablo\\Documents\\programas\\cs\\Agenda3\\primeraAplicacion\\DBagenda.mdb");
            connection.Open();
            OleDbCommand cmd = new OleDbCommand (query, connection);
            cmd.ExecuteNonQuery();
            connection.Close(); 
        }
        public static List<Evento> EjecutarSelectAll(string query)
        {

            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\pablo\\Documents\\programas\\cs\\Agenda3\\primeraAplicacion\\DBagenda.mdb");
            connection.Open();
            OleDbCommand cmd = new OleDbCommand(query, connection);
            OleDbDataReader reader = cmd.ExecuteReader();
            List<Evento> misEventos = new List<Evento>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                        reader.GetDateTime(1), reader.GetString(2));
                    Evento asd = new Evento(reader.GetInt32(0),
                        reader.GetDateTime(1), reader.GetString(2), reader.GetInt32(3),reader.GetString(4),reader.GetInt32(5));
                    misEventos.Add(asd);
                    Console.WriteLine(asd.repeatField);
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
