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
                    string query = "select id_usuario, usuario_login, nombre_completo, correo, clave, estado from usuario";

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
                                estado = Convert.ToBoolean(dr["estado"])
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
    }
}


