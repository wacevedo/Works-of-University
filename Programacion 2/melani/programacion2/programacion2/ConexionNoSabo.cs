using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//agregar librerias
using System.Data.OleDb;
using System.Data;


namespace programacion2
{
    
    class ConexionNoSabo
    {
        OleDbConnection conectar;
        OleDbCommand comando;

        public void conectando() 
        {

            conectar = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Willson Acevedo\Desktop\programacion2\no sabo.accdb;Persist Security Info=False");
            comando = conectar.CreateCommand();
        }

        public ConexionNoSabo()
        {
            conectando();
        }
        public void InsertCliente(Cliente c)
        {
            try
            {
                comando.CommandText = "INSERT INTO Cliente (Nombre, Cedula) VALUES('" + c.Nombre + "','" + c.Cedula + "')";
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
                { conectar.Close();
                }
            }

        }
        public void InsertCompra(Compra cp,Cliente c)
        {
            try
            {
                comando.CommandText = "INSERT INTO Compra(id_cliente,taza, tipo_moneda, cantidad) VALUES("+c.Id+",'" + cp.Taza.ToString() + "','" + cp.Tipo_moneda + "','" + cp.Cantidad.ToString() + "')";
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
        public void InsertVenta(Venta v,Cliente c)
        {
            try
            {
                comando.CommandText = "INSERT INTO Venta(id_cliente,taza, tipo_moneda, cantidad) VALUES("+c.Id+",'" + v.Taza.ToString() + "','" + v.Tipo_moneda + "','" + v.Cantidad.ToString() + "')";
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
        public List<Cliente> SelectCliente()
        {
            List<Cliente> Cliente = new List<Cliente>();
            try
            {
                comando.CommandText = "SELECT * FROM Cliente";
                comando.CommandType = CommandType.Text;
                conectar.Open();

                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Cliente c = new Cliente();
                    c.Id = Convert.ToInt32(reader["id_cliente"].ToString());
                    c.Nombre = reader["Nombre"].ToString();
                    c.Cedula = reader["Cedula"].ToString();
                    Cliente.Add(c);

                }
                return Cliente;
            }
            catch (Exception)
            {throw;

            }
            finally
            { if(conectar!=null)
            {
                conectar.Close();
            }

            }
            }
        public List<int> SelectIdCliente()
        {
            List<int> Cliente = new List<int>();
            try
            {
                comando.CommandText = "SELECT id_cliente FROM Cliente";
                comando.CommandType = CommandType.Text;
                conectar.Open();

                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    int c;
                    c = Convert.ToInt32(reader["id_cliente"].ToString());                    
                    Cliente.Add(c);

                }
                return Cliente;
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
        public List<Compra> SelectCompra()
        {
            List<Compra> Compra = new List<Compra>();
            try
            {
                comando.CommandText = "SELECT * FROM Compra";
                comando.CommandType = CommandType.Text;
                conectar.Open();

                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Compra cp = new Compra();
                    cp.Id_cliente = Convert.ToInt32(reader["id_cliente"].ToString());
                    cp.Id_compra = Convert.ToInt32(reader["id_compra"].ToString());
                    cp.Taza = Convert.ToInt32(reader["taza"].ToString());
                    cp.Tipo_moneda = reader["tipo_moneda"].ToString();
                    cp.Cantidad = Convert.ToInt32(reader["cantidad"].ToString());
                    Compra.Add(cp);

                }
                return Compra;
            }
            catch (Exception)
            {throw;

            }
            finally
            { if(conectar!=null)
            {
                conectar.Close();
            }

            }
            }

        public List<Venta> SelectVenta()
        {
            List<Venta> Venta = new List<Venta>();
            try
            {
                comando.CommandText = "SELECT * FROM Venta";
                comando.CommandType = CommandType.Text;
                conectar.Open();

                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Venta v = new Venta();
                    v.Id_cliente = Convert.ToInt32(reader["id_cliente"].ToString());
                    v.Id_venta = Convert.ToInt32(reader["id_venta"].ToString());
                    v.Taza = Convert.ToInt32(reader["taza"].ToString());
                    v.Tipo_moneda = reader["tipo_moneda"].ToString();
                    v.Cantidad = Convert.ToInt32(reader["cantidad"].ToString());
                    Venta.Add(v);

                }
                return Venta;
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

        public List<Venta> BuscarVentasCliente(string id_cliente)
        {
            List<Venta> listaVenta = new List<Venta>();
            try
            {
                comando.CommandText = "SELECT * FROM Venta where id_cliente=" + id_cliente;
                comando.CommandType = CommandType.Text;
                conectar.Open();

                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Venta v = new Venta();
                    v.Id_cliente = Convert.ToInt32(reader["id_cliente"].ToString());
                    v.Id_venta = Convert.ToInt32(reader["id_venta"].ToString());
                    v.Taza = Convert.ToInt32(reader["Taza"].ToString());
                    v.Tipo_moneda = reader["Tipo_moneda"].ToString();
                    v.Cantidad = Convert.ToInt32(reader["Cantidad"].ToString());
                    listaVenta.Add(v);

                }
                return listaVenta;
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
        /*public int ObtenerIdCliente()
        {
           int idcliente=0;
            try
            {
                comando.CommandText = "SELECT MAX(id_cliente) FROM Cliente";
                comando.CommandType = CommandType.Text;
                conectar.Open();

                OleDbDataReader reader = comando.ExecuteReader();
                 while (reader.Read())
                {
                    idcliente = Convert.ToInt32(reader["id_cliente"].ToString());
                }


                    return idcliente;
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
        }*/
    }
}
