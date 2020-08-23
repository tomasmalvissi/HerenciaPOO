﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class DatosConexionDB
    {
        public SqlConnection conexion;
        public string cadenaconex = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = TPHERENCIA; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public DatosConexionDB()
        {
            conexion = new SqlConnection(cadenaconex);
        }

        public void AbrirConex()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }

        public void CerrarConex() 
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch(Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }


    }
}
