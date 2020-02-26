using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.AccesoDatos
{
    public class ConeccionDB
    {
        private string connectionString = /*@al inicio o doble \*/"Data source=UAM-HD-LBPF2-06\\SQL2016;Initial Catalog=PROGRA3;User ID=userPR3;password=1234";
        public void ConexionSQLNoQuery(string sql)
        {
            SqlConnection cnn;
            SqlCommand cmd;
           // string sql = "Your SQL Statemnt Here";

            cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                //SqlDataReader resultado = cmd.ExecuteReader();
                cmd.Dispose();
                Console.WriteLine(" ExecuteNonQuery in SqlCommand executed !!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
            }
            // Closing the connection  
            finally
            {
                cnn.Close();
            }
        }

        public SqlDataReader ConexionSQL(string sql)
        {
            SqlConnection cnn;
            SqlCommand cmd;
            //string sql = "Your SQL Statemnt Here";

            cnn = new SqlConnection(connectionString);

            try
            {
                cnn.Open();
                cmd = new SqlCommand(sql, cnn);
                //cmd.ExecuteNonQuery();
                SqlDataReader resultado = cmd.ExecuteReader();
                cmd.Dispose();

                if (resultado.HasRows)
                {
                    cnn.Close();
                    return resultado;                    
                }
                // Console.WriteLine(" ExecuteNonQuery in SqlCommand executed !!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
            }
            // Closing the connection  
            finally
            {
                cnn.Close();
            }
            return null;
          
        }


        public void ConexionADO(string querystring)
        {
            try
            {
               // string querystring = "Select * from Persona";
                SqlDataAdapter adapter = new SqlDataAdapter(querystring, connectionString);
                DataSet ds = new DataSet();
                adapter.Fill(ds /*, "Items"*/);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! " + ex.Message);
            }
        }
    }
}

