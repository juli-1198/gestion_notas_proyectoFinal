using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Final_H2.Database;
using Final_H2.Models;
using Final_H2.Utils;




namespace Final_H2.Services
{
    public class UsuarioService
    {
        private readonly DatabaseConnection _db;

        public UsuarioService()
        {
            _db = new DatabaseConnection();
        }

        // Verificar nombre disponible 
        public bool NombreUsuarioDisponible(string nombre)
        {
            using var con = _db.GetConnection();
            con.Open();

            string sql = "SELECT COUNT(*) FROM gestion_notas.usuario WHERE nombre_usuario=@u";

            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@u", nombre);

            long count = (long)cmd.ExecuteScalar();

            return count == 0;
        }

        // Registro 
        public int RegistrarUsuario(Usuario u)
        {
            using var con = _db.GetConnection();
            con.Open();

            using var tx = con.BeginTransaction();

            try
            {
                // INSERT EN LA TABLA USUARIO
                string sqlInsertUser = @"
INSERT INTO gestion_notas.usuario
(
    primer_nombre,
    segundo_nombre,
    primer_apellido,
    segundo_apellido,
    correo,
    nombre_usuario,
    contrasena_hash,
    rol,
    pregunta_seguridad,
    respuesta_seguridad_hash
)
VALUES
(
    @pn,
    @sn,
    @pa,
    @sa,
    @correo,
    @nu,
    @pass,
    @rol,
    @preg,
    @resp
)
RETURNING id_usuario;
";

                var cmd = new NpgsqlCommand(sqlInsertUser, con);

                cmd.Parameters.AddWithValue("@pn", u.PrimerNombre);
                cmd.Parameters.AddWithValue("@sn", u.SegundoNombre ?? "");
                cmd.Parameters.AddWithValue("@pa", u.PrimerApellido);
                cmd.Parameters.AddWithValue("@sa", u.SegundoApellido ?? "");
                cmd.Parameters.AddWithValue("@correo", u.Correo);
                cmd.Parameters.AddWithValue("@nu", u.NombreUsuario);
                cmd.Parameters.AddWithValue("@pass", u.ContrasenaHash);
                cmd.Parameters.AddWithValue("@rol", u.Rol);
                cmd.Parameters.AddWithValue("@preg", u.PreguntaSeguridad);
                cmd.Parameters.AddWithValue("@resp", u.RespuestaSeguridadHash);

                int id = Convert.ToInt32(cmd.ExecuteScalar());

                // INSERT DEPENDIENDO DEL ROL
                string tabla = (u.Rol == "DOCENTE") ? "docente" : "estudiante";
                string campo = (u.Rol == "DOCENTE") ? "id_docente" : "id_estudiante";

                string sqlInsertRol = $"INSERT INTO gestion_notas.{tabla} ({campo}) VALUES (@id)";

                var cmdRole = new NpgsqlCommand(sqlInsertRol, con);
                cmdRole.Parameters.AddWithValue("@id", id);
                cmdRole.ExecuteNonQuery();

                tx.Commit();
                return id;
            }
            catch (Exception)
            {
                tx.Rollback();
                return -1;
            }
        }

        // Login - validar usuario y contraseña
        public Usuario Login(string nombreUsuario, string hashContrasena)
        {
            using var con = _db.GetConnection();
            con.Open();

            string sql = "SELECT * FROM gestion_notas.usuario WHERE nombre_usuario=@u";

            var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@u", nombreUsuario);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            string hashBD = reader["contrasena_hash"].ToString();

            if (hashBD != hashContrasena)
                return null;

            return new Usuario
            {
                IdUsuario = Convert.ToInt32(reader["id_usuario"]),
                PrimerNombre = reader["primer_nombre"].ToString(),
                PrimerApellido = reader["primer_apellido"].ToString(),
                Rol = reader["rol"].ToString()
            };
        }

        //  Recuperación de contraseña I 
        public string ObtenerPregunta(string nombreUsuario)
        {
            using var con = _db.GetConnection();
            con.Open();

            string sql = @"
        SELECT pregunta_seguridad 
        FROM gestion_notas.usuario 
        WHERE nombre_usuario = @u;
        ";

            using var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@u", nombreUsuario);

            object result = cmd.ExecuteScalar();
            return result?.ToString();
        }

        //  Recuperación de contraseña - validar respuesta
        public bool ValidarRespuesta(string nombreUsuario, string respuestaHash)
        {
            using var con = _db.GetConnection();
            con.Open();

            string sql = @"
        SELECT respuesta_seguridad_hash
        FROM gestion_notas.usuario 
        WHERE nombre_usuario = @u;
        ";

            var cmd = new NpgsqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@u", nombreUsuario);

            string respuestaBD = cmd.ExecuteScalar()?.ToString();

            if (respuestaBD == null)
                return false;

            return respuestaBD == respuestaHash;
        }

        //  Recuperación de contraseña - actualizar contraseña
        public bool CambiarContrasena(string nombreUsuario, string nuevoHash)
        {
            using var con = _db.GetConnection();
            con.Open();

            string sql = @"
        UPDATE gestion_notas.usuario
        SET contrasena_hash = @c
        WHERE nombre_usuario = @u;
        ";

            using var cmd = new NpgsqlCommand(sql, con);

            
            cmd.Parameters.AddWithValue("@c", nuevoHash);
            cmd.Parameters.AddWithValue("@u", nombreUsuario);

            int rows = cmd.ExecuteNonQuery();


            return rows > 0;

        }

    }
}
