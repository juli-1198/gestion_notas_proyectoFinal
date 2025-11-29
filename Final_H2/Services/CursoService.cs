using System;
using System.Collections.Generic;
using Npgsql;
using Final_H2.Database;
using Final_H2.Models;
using Final_H2.Utils;

namespace Final_H2.Services
{
    public class CursoService
    {
        private readonly DatabaseConnection _db;

        public CursoService()
        {
            _db = new DatabaseConnection();
        }

        
        //      CREAR CURSO
        public int CrearCurso(
            string nombre,
            int grupo,
            string salon,
            string docente,
            int idInstitucion)
        {
            using var con = _db.GetConnection();
            con.Open();

            // Generar código único
            string codigoCurso;
            do
            {
                codigoCurso = CodigoGenerador.GenerarCodigo(5);
            }
            while (ExisteCodigoCurso(codigoCurso));

            string sql = @"
                INSERT INTO curso 
                (nombre_curso, codigo_curso, numero_grupo, salon, id_docente, id_institucion)
                VALUES (@n, @c, @g, @s, @d, @i)
                RETURNING id_curso;
            ";

            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@n", nombre);
            cmd.Parameters.AddWithValue("@c", codigoCurso);
            cmd.Parameters.AddWithValue("@g", grupo);
            cmd.Parameters.AddWithValue("@s", salon);
            cmd.Parameters.AddWithValue("@d", docente);
            cmd.Parameters.AddWithValue("@i", idInstitucion);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        
        //   VERIFICAR CÓDIGO ÚNICO
        public bool ExisteCodigoCurso(string codigo)
        {
            using var con = _db.GetConnection();
            con.Open();

            string sql = "SELECT COUNT(*) FROM curso WHERE codigo_curso = @c";

            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@c", codigo);

            return (long)cmd.ExecuteScalar() > 0;
        }


        //   OBTENER CURSOS DE UNA INSTITUCIÓN
        public List<Curso> ObtenerCursosInstitucion(int idInstitucion)
        {
            List<Curso> lista = new();

            using var con = _db.GetConnection();
            con.Open();

            string sql = @"
        SELECT id_curso, nombre_curso, codigo_curso, numero_grupo, salon, id_docente
        FROM gestion_notas.curso
        WHERE id_institucion = @id;
    ";

            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", idInstitucion);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Curso
                {
                    idCurso = Convert.ToInt32(reader["id_curso"]),
                    nombreCurso = reader["nombre_curso"].ToString(),
                    codigoCurso = reader["codigo_curso"].ToString(),
                    numeroGrupo = Convert.ToInt32(reader["numero_grupo"]),
                    salon = reader["salon"].ToString(),
                    idDocente = reader["id_docente"].ToString(),
                    idInstitucion = idInstitucion
                });
            }

            return lista;
        }


        public List<Curso> ObtenerCursosDocente(string nombreDocente)
        {
            var lista = new List<Curso>();

            using var con = _db.GetConnection();
            con.Open();

            string sql = @"
        SELECT id_curso, nombre_curso, codigo_curso, numero_grupo, salon, id_institucion
        FROM gestion_notas.curso
        WHERE id_docente = @doc;
    ";

            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@doc", nombreDocente);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Curso
                {
                    idCurso = reader.GetInt32(0),
                    nombreCurso = reader.GetString(1),
                    codigoCurso = reader.GetString(2),
                    numeroGrupo = reader.GetInt32(3),
                    salon = reader.GetString(4),
                    idDocente = nombreDocente,
                    idInstitucion = reader.GetInt32(5)
                });
            }

            return lista;
        }




    }
}

