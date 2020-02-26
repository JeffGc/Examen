using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba.Entidades;

namespace Prueba.AccesoDatos
{
    
    public class OperacionesPersona : IOperaciones<Persona>
    {
        private ConeccionDB coneccionDB = new ConeccionDB();

        public Persona Buscar(int Id)
        {
            // Query que se va a consultar
             string query = string.Format("Select * from Persona where id ={0}",Id);

            // Recibe un objeto SQLDataReader de la consulta
            SqlDataReader resultado = coneccionDB.ConexionSQL(query);

            // Valida si el retorno no fue nulo y retorna una persona
            if (resultado != null)
            {
                while (resultado.NextResult())
                {
                    return new Persona(resultado.GetInt32(0), resultado.GetString(1).Trim(), resultado.GetString(2).Trim());
                }
            }

            return null;
        }

        public List<Persona> BuscarTodos()
        {
            List<Persona> personas = new List<Persona>();

            string query = string.Format("Select * from Persona");

            // Recibe un objeto SQLDataReader de la consulta
            SqlDataReader resultado = coneccionDB.ConexionSQL(query);

            // Valida si el retorno no fue nulo y retorna una persona
            if (resultado != null)
            {
                while (resultado.NextResult())
                {
                    //return new Persona(resultado.GetInt32(0), resultado.GetString(1).Trim(), resultado.GetString(2).Trim());

                    personas.Add(new Persona(resultado.GetInt32(0), resultado.GetString(1).Trim(), resultado.GetString(2).Trim()));
                }
            }

            return personas;
           
        }

        public void Eliminar(Persona Item)
        {
           

            throw new NotImplementedException();
        }

        public void Insertar(Persona Item)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Persona Item)
        {
            throw new NotImplementedException();
        }
    }
}
