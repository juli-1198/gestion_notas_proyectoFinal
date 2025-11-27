using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Final_H2.Database
{
    public class DatabaseConnection
    {
        private readonly string connectionString;

        public DatabaseConnection()
        {
            connectionString =
                "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=gestion_notas;Search Path=gestion_notas;";
        }

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
