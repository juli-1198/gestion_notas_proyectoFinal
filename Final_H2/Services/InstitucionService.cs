using System;
using System.Collections.Generic;
using Npgsql;
using Final_H2.Database;
using Final_H2.Models;
using Final_H2.Utils;

namespace Final_H2.Services
{
    public class InstitucionService
    {
        private readonly DatabaseConnection _db;

        public InstitucionService()
        {
            _db = new DatabaseConnection();
        }

        
        //      CREAR INSTITUCIÓN
        public int CrearInstitucion(string nombre, int tipoInst, string codigoManual, string nombreDocente)
        {
            using var con = _db.GetConnection();
            con.Open();

            string codigoFinal = codigoManual;

            
            if (string.IsNullOrWhiteSpace(codigoManual))
            {
                do
                {
                    codigoFinal = CodigoGenerador.GenerarCodigo(5);
                }
                while (ExisteCodigoInstitucion(codigoFinal));
            }

            string sql = @"
                INSERT INTO institucion 
                (nombre_institucion, tipo_institucion, codigo_institucion, id_docente)
                VALUES (@n, @t, @c, @d)
                RETURNING id_institucion;
            ";

            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@n", nombre);
            cmd.Parameters.AddWithValue("@t", tipoInst);
            cmd.Parameters.AddWithValue("@c", codigoFinal);
            cmd.Parameters.AddWithValue("@d", nombreDocente); 

            return Convert.ToInt32(cmd.ExecuteScalar());
        }


        //   VERIFICAR CÓDIGO EXISTENTE
        public bool ExisteCodigoInstitucion(string codigo)
        {
            using var con = _db.GetConnection();
            con.Open();

            string sql = "SELECT COUNT(*) FROM institucion WHERE codigo_institucion = @c";

            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@c", codigo);

            return (long)cmd.ExecuteScalar() > 0;
        }


        //   OBTENER INSTITUCIONES DE DOCENTE
        public List<Institucion> ObtenerInstitucionesDocente(string nombreDocente)
        {
            List<Institucion> lista = new();

            using var con = _db.GetConnection();
            con.Open();

            string sql = @"
        SELECT id_institucion, nombre_institucion, tipo_institucion, codigo_institucion, id_docente
        FROM gestion_notas.institucion
        WHERE id_docente = @d;
    ";

            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@d", nombreDocente);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Institucion
                {
                    idInstitucion = Convert.ToInt32(reader["id_institucion"]),
                    nombre = reader["nombre_institucion"].ToString(),
                    tipoInstitucion = Convert.ToInt32(reader["tipo_institucion"]),
                    codigoInstitucion = reader["codigo_institucion"].ToString(),
                    idDocente = reader["id_docente"].ToString()
                });
            }

            return lista;
        }


        //   OBTENER ID POR NOMBRE
        public int ObtenerIdPorNombre(string nombreInst)
        {
            using var con = _db.GetConnection();
            con.Open();

            string sql = "SELECT id_institucion FROM institucion WHERE nombre_institucion = @n";

            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@n", nombreInst);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        
        //   BUSCAR POR CÓDIGO
        public Institucion BuscarPorCodigo(string codigo)
        {
            using var con = _db.GetConnection();
            con.Open();

            string sql = @"
                SELECT id_institucion, nombre_institucion, tipo_institucion, codigo_institucion, id_docente
                FROM institucion
                WHERE codigo_institucion = @c;
            ";

            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@c", codigo);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            return new Institucion
            {
                idInstitucion = reader.GetInt32(0),
                nombre = reader.GetString(1),
                tipoInstitucion = reader.GetInt32(2),
                codigoInstitucion = reader.GetString(3),
                idDocente = reader.GetString(4)
            };
        }
    }
}


