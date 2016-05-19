using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Dominio;

namespace Sesion
{
    public class Broker
    {
        OleDbConnection connection;
        OleDbCommand command;
        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\20121993\BaseDatosPA\DataBase.accdb;Persist Security Info=False");
            command = connection.CreateCommand();
        }

        public Broker()
        {
            ConnectTo();
        }

        public void insert(Persona p)
        {
            try
            {
                command.CommandText = "INSERT INTO tPersona(Nombre, Apellido, Dirrecion, Telefono, Sexo, Estado) VALUE('" + p.Nombres + "','" + p.Apellido + "','" + p.Direccion + "','" + p.Telefono + "','" + p.Sexo + "', '" + p.Estado + "')";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
               
            }
 
        } //final del insert

        public List<Persona> ActualiazarCombobox()
        {
            List<Persona> personslist = new List<Persona>();
            try
            {
                command.CommandText = "SELECT * FROM tPersona";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Persona p = new Persona();
                    p.Id = Convert.ToInt32(reader["ID"].ToString());
                    p.Nombres = reader["Nomebre"].ToString();
                    p.Apellido = reader["Apellido"].ToString();
                    p.Direccion = reader["Dirrecion"].ToString();
                    p.Sexo = reader["Sexo"].ToString();
                    p.Telefono = reader["Telefono"].ToString();

                    personslist.Add(p);
                }
                return personslist;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }

            }

        }

        public void update(Persona viejapersona, Persona nuevapersona)
        {
            try
            {
                command.CommandText = "UPDATE tPersona SER Nombre='" + p.Nombres + "', Apellido='" + p.Apellido + "', Dirrecion='" + p.Direccion + "', Telefono='" + p.Telefono + "', Sexo='" + p.Sexo + "', Estado='" + p.Estado + "' WHERE Id ="+viejapersona.Id;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }

            }
        }

        public void Delete(Persona p)
        {
            try
            {
                command.CommandText = "DELETE FROM tPersona WHERE Id =" + p.Id;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }

            }
        }
    }
}
