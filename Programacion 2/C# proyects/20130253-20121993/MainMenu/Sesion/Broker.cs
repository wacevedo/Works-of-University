using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using Dominio;

namespace Sesion
{
    public class Broker
    {
        OleDbConnection connection;
        OleDbCommand command;
        private void ConnectTo()
        {
            connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\20130253-20121993\ClinicaDataBase.accdb;Persist Security Info=False");
            command = connection.CreateCommand();
        }
        public Broker()
        {
            ConnectTo();
        }

        #region Centro de Salud (LISTO)
        //Insert Centro Salud
        public void InsertCentroS(CentroSalud p)
        {
            
            try
            {
                command.CommandText = "INSERT INTO CENTRO_SALUD (Nombre, Direccion) VALUES('" + p.Nombre + "', '" + p.Direccion + "')";
                command.CommandType = CommandType.Text;

                connection.Open();

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
        }//final insert

        #endregion 
        
        #region Habitacion (LISTO)

        //Select devuelve todos los centros de salud
        public List<CentroSalud> ActualizarCentroSalud()
        {
            List<CentroSalud> CentroSalud = new List<CentroSalud>();
            try
            {
                command.CommandText = "SELECT * FROM CENTRO_SALUD";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                             
                while (reader.Read())
                {                 
                    CentroSalud p = new CentroSalud();
                    p.Id = Convert.ToInt32(reader["ID_CENTRO_SALUD"].ToString());
                    p.Nombre = reader["Nombre"].ToString();                    
                    p.Direccion = reader["Direccion"].ToString();
                    CentroSalud.Add(p);
                    
                }
                return CentroSalud;
                
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
        }//final actualizar combobox

        //Insert Habitacion
        public void InsertHabitacion(Habitacion p, CentroSalud cs)
        {
            try
            {
                command.CommandText = "INSERT INTO HABITACION (NUMERO_HABI, CAPACIDAD, DESCRIPCION, ID_CENTRO_SALUD) VALUES('" + p.Numero_habi + "', '" + p.Capacidad + "','" + p.Descripcion + "','" + cs.Id + "')";
                command.CommandType = CommandType.Text;
                connection.Open();
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
        }//final insert

        #endregion //LISTO

        #region Doctor (LISTO)       

        //Insert Doctor
        public void InsertDoctor(Doctor p)
        {
            try
            {
                command.CommandText = "INSERT INTO DOCTOR (NOMBRE, APELLIDO, CEDULA, SEXO, FECHA_NAC) VALUES('" + p.Nombre + "', '" + p.Apellido + "','" + p.Cedula + "','" + p.Sexo + "','" + p.Fechanac + "')";
                command.CommandType = CommandType.Text;
                connection.Open();
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
        }//final insert

        //Insert Resultante DOC_ESPACIALIDAD, los parametros son el doctor(para tomar el id) y el id de la especialidad.
        public void Insert_Doc_ESPACIALIDAD(Doctor p, int id)
        {
            try
            {
                command.CommandText = "INSERT INTO DOC_ESPACIALIDAD (ID_DOCTOR, ID_ESPECIALIDAD) VALUES('"+ p.Id + "','" + id + "')";
                command.CommandType = CommandType.Text;
                connection.Open();
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
        }//final insert


        //Select devuelve todas las especialidades
        public List<Especialidad> ActualizarEspecialidad()
        {
            List<Especialidad> ListaEspecial = new List<Especialidad>();
            try
            {
                command.CommandText = "SELECT * FROM ESPECIALIDAD";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Especialidad p = new Especialidad();
                    p.Id = Convert.ToInt32(reader["ID_ESPECIALIDAD"].ToString());
                    p.Nombre = reader["Nombre"].ToString();
                    p.Descripcion = reader["DESCRIPCION"].ToString();
                    ListaEspecial.Add(p);

                }
                return ListaEspecial;

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
        }//final actualizar combobox

        //Select devuelve todos los IDS de las especialidades
        public  List<int> IDsEspecialidades()
        {
            List<int> listaID = new List<int>();
            
            try
            {
                command.CommandText = "SELECT ID_ESPECIALIDAD FROM ESPECIALIDAD";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Especialidad p = new Especialidad();
                    p.Id = Convert.ToInt32(reader["ID_ESPECIALIDAD"].ToString());                    
                    listaID.Add(p.Id);

                }
                return listaID;

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
        }//final actualizar combobox

        //Select devuelve todos los doctores
        public List<Doctor> ActualizarDoctores()
        {
            List<Doctor> ListaDoc = new List<Doctor>();
            try
            {
                command.CommandText = "SELECT * FROM Doctor";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Doctor p = new Doctor();
                    p.Id = Convert.ToInt32(reader["ID_DOCTOR"].ToString());
                    p.Nombre = reader["NOMBRE"].ToString();
                    p.Apellido = reader["APELLIDO"].ToString();
                    p.Cedula = reader["CEDULA"].ToString(); 
                    p.Sexo = reader["SEXO"].ToString(); 
                    p.Fechanac = reader["FECHA_NAC"].ToString(); 
                    ListaDoc.Add(p);

                }
                return ListaDoc;

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
        }//final actualizar combobox

        #endregion

        #region Doctor Especialidad (resultante)
       
        //Select que devuelve Especialidades que un doctor tiene
        public List<Especialidad> Select_Especialidad_Doctor(Doctor doc)
        {
            string x;
            List<Especialidad> ListaEspecial = new List<Especialidad>();
            try
            {
                x = Convert.ToString(doc.Id);
                command.CommandText = "SELECT ESPECIALIDAD.ID_ESPECIALIDAD, ESPECIALIDAD.NOMBRE, ESPECIALIDAD.DESCRIPCION FROM ESPECIALIDAD, DOC_ESPACIALIDAD, DOCTOR WHERE ESPECIALIDAD.ID_ESPECIALIDAD = DOC_ESPACIALIDAD.ID_ESPECIALIDAD AND DOC_ESPACIALIDAD.ID_DOCTOR = DOCTOR.ID_DOCTOR AND DOCTOR.ID_DOCTOR = "  + x;
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Especialidad p = new Especialidad();
                    p.Id = Convert.ToInt32(reader["ID_ESPECIALIDAD"].ToString());
                    p.Nombre = reader["Nombre"].ToString();
                    p.Descripcion = reader["DESCRIPCION"].ToString();
                    ListaEspecial.Add(p);

                }
                return ListaEspecial;

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
        }//final actualizar combobox

        public List<Especialidad> Select_Especialidad_No_Doctor(Doctor id)
        {
            string x;
            List<Especialidad> ListaEspecial = new List<Especialidad>();
            try
            {
                x = Convert.ToString(id.Id);
                command.CommandText = "SELECT ESPECIALIDAD.ID_ESPECIALIDAD, ESPECIALIDAD.NOMBRE, ESPECIALIDAD.DESCRIPCION FROM ESPECIALIDAD, DOC_ESPACIALIDAD, DOCTOR WHERE ESPECIALIDAD.ID_ESPECIALIDAD = DOC_ESPACIALIDAD.ID_ESPECIALIDAD AND DOC_ESPACIALIDAD.ID_DOCTOR = DOCTOR.ID_DOCTOR AND DOCTOR.ID_DOCTOR <> " + x;
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Especialidad p = new Especialidad();
                    p.Id = Convert.ToInt32(reader["ID_ESPECIALIDAD"].ToString());
                    p.Nombre = reader["NOMBRE"].ToString();
                    p.Descripcion = reader["DESCRIPCION"].ToString();
                    ListaEspecial.Add(p);

                }
                return ListaEspecial;

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
        }//final actualizar combobox
        #endregion

        #region Paciente (LISTO)

        //Insert Paciente
        public void InsertPaciente(Paciente p)
        {
            try
            {
                command.CommandText = "INSERT INTO PACIENTE (NOMBRE, APELLIDO, DIRECCION, FECHA_NAC, CEDULA, PESO, SEXO) VALUES('" + p.Nombre + "', '" + p.Apellido + "','" + p.Direccion + "','" + p.Fechanac + "','" + p.Cedula + "','" + p.Peso + "','" + p.Sexo + "')";
                command.CommandType = CommandType.Text;
                connection.Open();
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
        }//final insert

        #endregion

        #region Especialidad (LISTO)
        
        //Insert Especialidad
        public void InsertEspecialidad(Especialidad p)
        {
            try
            {
                command.CommandText = "INSERT INTO ESPECIALIDAD (Nombre, DESCRIPCION) VALUES('" + p.Nombre + "', '" + p.Descripcion + "')";
                command.CommandType = CommandType.Text;
                connection.Open();
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
        }//final insert
        #endregion

        #region Patologia(LISTO)
        //Insert Patologia
        public void InsertPatologia(Patologia p)
        {
            try
            {
                command.CommandText = "INSERT INTO PATOLOGIA (NOMBRE, DESCRIPCION, SINTOMAS_USUALES) VALUES('" + p.Nombre + "', '" + p.Descripcion + "', '" + p.Sintomas_usuales + "')";
                command.CommandType = CommandType.Text;
                connection.Open();
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
        }//final insert
        
        #endregion

        #region Consulta

        //Select que devuelve las habitaciones que tiene un Centro de Salud
        public List<Habitacion> ActualizarHabitacion(CentroSalud cs)
        {
            List<Habitacion> ListaHab = new List<Habitacion>();
            try
            {
                command.CommandText = "SELECT * FROM HABITACION WHERE ID_CENTRO_SALUD = " + cs.Id.ToString() ;
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Habitacion p = new Habitacion();
                    p.Id = Convert.ToInt32(reader["ID_HABITACION"].ToString());
                    p.Numero_habi = reader["NUMERO_HABI"].ToString();
                    p.Capacidad = Convert.ToInt32(reader["CAPACIDAD"].ToString());
                    p.Descripcion = reader["DESCRIPCION"].ToString();
                    p.Id_centro_salud = Convert.ToInt32(reader["ID_CENTRO_SALUD"].ToString());                   
                    ListaHab.Add(p);


                }
                return ListaHab;

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
        }//final actualizar combobox habitacion

        //Select que devuleve todos los pacientes
        public List<Paciente> ActualizarPaciente()
        {
            List<Paciente> ListaPac = new List<Paciente>();
            try
            {
                command.CommandText = "SELECT * FROM PACIENTE";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Paciente p = new Paciente();
                    p.Id = Convert.ToInt32(reader["ID_PACIENTE"].ToString());
                    p.Nombre = reader["NOMBRE"].ToString();
                    p.Apellido = reader["APELLIDO"].ToString();
                    p.Cedula = reader["CEDULA"].ToString();
                    p.Sexo = reader["SEXO"].ToString();
                    p.Fechanac = reader["FECHA_NAC"].ToString();
                    p.Direccion = reader["DIRECCION"].ToString();
                    p.Peso=Convert.ToInt32(reader["PESO"].ToString());
                    ListaPac.Add(p);


                }
                return ListaPac;

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
        }//final actualizar combobox paciente

        //Insert de la consulta        
        public void InsertConsulta(Consulta p)
        {
            try
            {
                command.CommandText = "INSERT INTO CONSULTA(ID_PACIENTE, ID_DOCTOR, ID_HABITACION, SINTOMAS, TRATAMIENTO, FECHACONSULTA, FECHAALTA, ID_CENTRO_SALUD) VALUES('" + p.Id_paciente + "', '" + p.Id_doctor + "', '" + p.Id_habitacion + "', '" + p.Sintomas + "', '" + p.Tratamiento + "', '" + p.Fechaconsulta + "', '" + p.Fechadealta + "', '" + p.Id_centro_salud + "')";
                command.CommandType = CommandType.Text;
                connection.Open();
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
        }//final insert

        //Select devuelve todas las Patologias
        public List<Patologia> Actualizar_Patologia()
        {
            List<Patologia> ListaPat = new List<Patologia>();
            try
            {
                command.CommandText = "SELECT * FROM PATOLOGIA";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Patologia p = new Patologia();
                    p.Id = Convert.ToInt32(reader["ID_PATOLOGIA"].ToString());
                    p.Nombre = reader["Nombre"].ToString();
                    p.Sintomas_usuales = reader["SINTOMAS_USUALES"].ToString();
                    p.Descripcion = reader["DESCRIPCION"].ToString();
                    ListaPat.Add(p);

                }
                return ListaPat;
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
        }//final actualizar combobox

        //Select devuelve todos los IDS de las patologias
        public List<int> IDsPatologias()
        {
            List<int> listaID = new List<int>();

            try
            {
                command.CommandText = "SELECT ID_PATOLOGIA FROM PATOLOGIA";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Especialidad p = new Especialidad();
                    p.Id = Convert.ToInt32(reader["ID_PATOLOGIA"].ToString());
                    listaID.Add(p.Id);

                }
                return listaID;

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
        }//final actualizar combobox


        //Select devuelve todos las Consulta
        public List<Consulta> ActualizarConsulta()
        {
            List<Consulta> ListaCon = new List<Consulta>();
            try
            {
                command.CommandText = "SELECT * FROM CONSULTA";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Consulta p = new Consulta();
                    p.Id_consulta = Convert.ToInt32(reader["ID_CONSULTA"].ToString());
                    p.Id_paciente = Convert.ToInt32(reader["ID_PACIENTE"].ToString());
                    p.Id_doctor = Convert.ToInt32(reader["ID_DOCTOR"].ToString());
                    p.Id_habitacion = Convert.ToInt32(reader["ID_HABITACION"].ToString());
                    p.Id_centro_salud = Convert.ToInt32(reader["ID_CENTRO_SALUD"].ToString());
                    p.Sintomas = reader["SINTOMAS"].ToString();
                    p.Tratamiento = reader["TRATAMIENTO"].ToString();
                    p.Fechadealta= reader["FECHAALTA"].ToString();
                    p.Fechaconsulta = reader["FECHACONSULTA"].ToString();
                    
                    ListaCon.Add(p);


                }
                return ListaCon;

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
        }//final actualizar combobox CONSULTA
       
        
        //Insert Resultante PATOLOGIA_CONSULTA, los parametros son la CONSULTA (para tomar el id) y el id de la PATOLOGIA.
        public void Insert_PAT_CONSU(Consulta p, int id)
        {
            try
            {
                command.CommandText = "INSERT INTO PATOLOGIA_CONSULTA (ID_CONSULTA, ID_PATOLOGIA) VALUES('" + p.Id_consulta + "','" + id + "')";
                command.CommandType = CommandType.Text;
                connection.Open();
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
        }//final insert
        #endregion

        #region Reportes y Datos
        
        //Select que devuleve todos los pacientes con chiku
        public List<Paciente> ActualizarPacienteConChiku()
        {
            List<Paciente> ListaPac = new List<Paciente>();
            try
            {
                command.CommandText = "SELECT PACIENTE.NOMBRE, PACIENTE.APELLIDO, PACIENTE.DIRECCION, PACIENTE.FECHA_NAC, PACIENTE.CEDULA, PACIENTE.PESO, PACIENTE.SEXO FROM PATOLOGIA, PACIENTE, CONSULTA, PATOLOGIA_CONSULTA WHERE PACIENTE.ID_PACIENTE=CONSULTA.ID_PACIENTE AND CONSULTA.ID_CONSULTA=PATOLOGIA_CONSULTA.ID_CONSULTA AND PATOLOGIA_CONSULTA.ID_PATOLOGIA=PATOLOGIA.ID_PATOLOGIA AND PATOLOGIA.ID_PATOLOGIA=4";
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();
                int x = 1;
                while (reader.Read())
                {
                    
                    Paciente p = new Paciente();
                    p.Id= x;
                    p.Nombre = reader["NOMBRE"].ToString();
                    p.Apellido = reader["APELLIDO"].ToString();
                    p.Cedula = reader["CEDULA"].ToString();
                    p.Sexo = reader["SEXO"].ToString();
                    p.Fechanac = reader["FECHA_NAC"].ToString();
                    p.Direccion = reader["DIRECCION"].ToString();
                    p.Peso = Convert.ToInt32(reader["PESO"].ToString());
                    ListaPac.Add(p);
                    x++;
                }
                return ListaPac;

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
        }//final actualizar combobox paciente

        //Select devuelve todos las Consultas de un paciente
        public List<Consulta> ActualizarConsultadepaciente(Paciente pac)
        {
            List<Consulta> ListaCon = new List<Consulta>();
            try
            {
                string x;
                x = Convert.ToString(pac.Id);
                command.CommandText = "SELECT * FROM CONSULTA WHERE ID_PACIENTE ="+ x;
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Consulta p = new Consulta();
                    p.Id_consulta = Convert.ToInt32(reader["ID_CONSULTA"].ToString());
                    p.Id_paciente = Convert.ToInt32(reader["ID_PACIENTE"].ToString());
                    p.Id_doctor = Convert.ToInt32(reader["ID_DOCTOR"].ToString());
                    p.Id_habitacion = Convert.ToInt32(reader["ID_HABITACION"].ToString());
                    p.Id_centro_salud = Convert.ToInt32(reader["ID_CENTRO_SALUD"].ToString());
                    p.Sintomas = reader["SINTOMAS"].ToString();
                    p.Tratamiento = reader["TRATAMIENTO"].ToString();
                    p.Fechadealta = reader["FECHAALTA"].ToString();
                    p.Fechaconsulta = reader["FECHACONSULTA"].ToString();

                    ListaCon.Add(p);


                }
                return ListaCon;

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
        }//final actualizar combobox CONSULTA

        //Select devuelve las habitaciones todos las Consultas de un paciente
        public List<Habitacion> ActualizarHabitaciondepaciente(Consulta con)
        {
            List<Habitacion> ListaHab = new List<Habitacion>();
            try
            {
                string x;
                x = Convert.ToString(con.Id_habitacion);
                command.CommandText = "SELECT * FROM HABITACION WHERE ID_HABITACION =" + x;
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Habitacion p = new Habitacion();
                    p.Id = Convert.ToInt32(reader["ID_HABITACION"].ToString());
                    p.Numero_habi = reader["NUMERO_HABI"].ToString();
                    p.Capacidad = Convert.ToInt32(reader["CAPACIDAD"].ToString());
                    p.Descripcion = reader["DESCRIPCION"].ToString();
                    p.Id_centro_salud = Convert.ToInt32(reader["ID_CENTRO_SALUD"].ToString());                   

                    ListaHab.Add(p);


                }
                return ListaHab;

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
        }//final actualizar combobox CONSULTA

        //Select devuelve todos los IDS de las patologias
        public List<int> BuscarIDsPatologiasdeconsulta(Consulta con)
        {
            List<int> listaID = new List<int>();

            try
            {
                string x;
                x = Convert.ToString(con.Id_consulta);
                command.CommandText = "SELECT ID_PATOLOGIA FROM PATOLOGIA_CONSULTA WHERE ID_CONSULTA ="+ x;
                command.CommandType = CommandType.Text;
                connection.Open();

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Especialidad p = new Especialidad();
                    p.Id = Convert.ToInt32(reader["ID_PATOLOGIA"].ToString());
                    listaID.Add(p.Id);

                }
                return listaID;

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
        }//final actualizar combobox

        //Select devuelve todas las Patologias segun el id
        public List<Patologia> Actualizar_NombrePatologia(List<int> idpat)
        {
            List<Patologia> ListaPat = new List<Patologia>();
            try
            {
                foreach (int value in idpat)
                {
                    string x;
                    x = Convert.ToString(value);
                    command.CommandText = "SELECT * FROM PATOLOGIA WHERE ID_PATOLOGIA =" + x;
                    command.CommandType = CommandType.Text;
                    connection.Open();

                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Patologia p = new Patologia();
                        p.Id = Convert.ToInt32(reader["ID_PATOLOGIA"].ToString());
                        p.Nombre = reader["Nombre"].ToString();
                        p.Sintomas_usuales = reader["SINTOMAS_USUALES"].ToString();
                        p.Descripcion = reader["DESCRIPCION"].ToString();
                        ListaPat.Add(p);

                    }
                }
                return ListaPat;
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
        }//final actualizar combobox
        
        #endregion

        



    }
}
