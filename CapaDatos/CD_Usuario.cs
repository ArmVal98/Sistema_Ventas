using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Npgsql;
using CapaEntidad;
using System.Runtime.Remoting.Messaging;
using System.Collections;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuario> Listar()
        {
            List<Usuario> Lista = new List<Usuario>();

            using (NpgsqlConnection conection = new NpgsqlConnection(Conexion.cadena))
            {
                try
                {
                    
                    string query = "select u.id_usuario, u.usuario_login, u.nombre_completo, u.correo, u.clave, u.telefono, u.estado, r.id_rol,r.descripcion from usuario u inner join rol r on r.id_rol = u.id_rol order by u.estado desc, u.nombre_completo ";

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conection);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conection.Open();

                    using (NpgsqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Usuario()
                            {
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                usuario_login = dr["usuario_login"].ToString(),
                                nombre_completo = dr["nombre_completo"].ToString(),
                                correo = dr["correo"].ToString(),
                                clave = dr["clave"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"]),
                                telefono = dr["telefono"].ToString(),
                                oRol = new Rol() { id_rol = Convert.ToInt32(dr["id_rol"]), descripcion = dr["descripcion"].ToString() }
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Lista = new List<Usuario>();
                }
            }
            return Lista;
        }

        /*public int Registrar(Usuario obj,out string mensaje)
        {
            int idUsuarioGenerado = 0;
            mensaje = string.Empty;
            string query = string.Empty;
            try
            {
                using (NpgsqlConnection conection = new NpgsqlConnection(Conexion.cadena))
                {
                    List<Usuario> lista_usuario = new CD_Usuario().Listar();

                    query = "SELECT out_estado, out_mensaje FROM fun_usuarios(1," + lista_usuario.id_usuario + " 
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conection);
                    cmd.Parameters.AddWithValue("id_usuario",obj.)
                    conection.Open();
                }
            }
            catch (Exception ex)
            {
                idUsuarioGenerado = 0;
                mensaje = ex.Message;
            }

            return idUsuarioGenerado;
        }*/
    }
}


