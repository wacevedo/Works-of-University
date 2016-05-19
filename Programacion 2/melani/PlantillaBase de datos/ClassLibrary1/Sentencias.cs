using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using Entidades;

namespace ClassLibrary1
{
    public class Sentencias
    {
        OleDbCommand comando;
        OleDbConnection conectar;
        
        
        
        public void conectando()
        {
            conectar = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/PlantillaBase de datos/PlantillaBase de datos/bin/Debug/nosabo.accdb;Persist Security Info=False");
            comando = conectar.CreateCommand();
        }

        public Sentencias() 
        {
            conectando();
        }
        
        public void InsertPaciente(Paciente p)
        {
            try
            {
                comando.CommandText = "INSERT INTO Registro (Nombre, Apellido, Cedula, Tipo_sangre, Peso) VALUES('" + p.Nombres1 + "','" + p.Apellidos1 + "','" + p.Cedula1 + "','" + p.TipoSangre1 + "','" + p.Peso1 + "')";
                comando.CommandType = CommandType.Text;
                conectar.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conectar != null)
                {
                    conectar.Close();
                }
            }
        }

        public List<Paciente> SelectPaciente()
        {
            List<Paciente> p = new List<Paciente>();
            try
            {
                comando.CommandText = "SELECT * FROM Registro";
                comando.CommandType = CommandType.Text;
                conectar.Open();

                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Paciente pac = new Paciente();
                    pac.ID_Paciente1 = Convert.ToInt32(reader["ID"].ToString());
                    pac.Nombres1 = reader["Nombre"].ToString();
                    pac.Apellidos1 = reader["Apellido"].ToString();
                    pac.Cedula1 = reader["Cedula"].ToString();
                    pac.TipoSangre1 = reader["Tipo_sangre"].ToString();
                    pac.Peso1 = Convert.ToDouble(reader["Peso"].ToString());                    
                    p.Add(pac);

                }
                return p;
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                if (conectar != null)
                {
                    conectar.Close();
                }

            }

        }     

    }
}
