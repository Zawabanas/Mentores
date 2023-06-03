using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Mentores.Classes
{
    public class Connection
    {
        public NpgsqlConnection conn;
        private string connString;

        public Connection()
        {
            connString = "Server = localhost; Port = 5432; Username = postgres; Password = 12345; Database = mentores";
            conn = new NpgsqlConnection(connString);
        }

        public bool Conect()
        {
            try
            {
                conn.Open();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return false;
            }
        }

        public void Desconectar()
        {
            conn.Close();
        }
    }
}
