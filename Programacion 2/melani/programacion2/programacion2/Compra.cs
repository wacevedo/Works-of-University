using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programacion2
{
    class Compra
    {
        int id_cliente;

        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }
        int id_compra;

        public int Id_compra
        {
            get { return id_compra; }
            set { id_compra = value; }
        }
        double taza;

        public double Taza
        {
            get { return taza; }
            set { taza = value; }
        }
        string tipo_moneda;

        public string Tipo_moneda
        {
            get { return tipo_moneda; }
            set { tipo_moneda = value; }
        }
        int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public override string ToString()
        {
            return Id_compra.ToString();
        }

    }
}
