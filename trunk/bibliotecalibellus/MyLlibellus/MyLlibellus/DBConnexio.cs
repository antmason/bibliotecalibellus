﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLlibellus
{
    class DBConnexio
    {
        /// <summary>
        /// Obtenir cadena de connexió de la BD alumnes (MARC).
        /// </summary>
        /// <returns></returns>
        public static SqlConnection obtenirConnexioBibliotecaMarc()
        {
            string cadConnexio =
                ConfigurationManager.ConnectionStrings["MyLlibellus.Properties.Settings.ConnexioBiblioteca"].ConnectionString;
            System.Data.SqlClient.SqlConnection con = new SqlConnection(cadConnexio);
            return con;
        }
    }
}
