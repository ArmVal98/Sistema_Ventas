using CapaEntidad;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<Permiso> Listar(int id_usuario)
        {
            List<Permiso> Lista = new List<Permiso>();

            using (NpgsqlConnection conection = new NpgsqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT p.id_rol, p.nombre_menu FROM permiso p");
                    query.AppendLine("INNER JOIN rol r ON r.id_rol = p.id_rol");
                    query.AppendLine("INNER JOIN usuario u ON u.id_rol = r.id_rol");
                    query.AppendLine("WHERE u.id_usuario = @id_usuario");

                    NpgsqlCommand cmd = new NpgsqlCommand(query.ToString(), conection);
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conection.Open();

                    using (NpgsqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Permiso()
                            {
                                oRol = new Rol() { id_rol = Convert.ToInt32(dr["id_rol"]) },
                                nombre_menu = dr["nombre_menu"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Lista = new List<Permiso>();
                }
            }
            return Lista;
        }
    }
}
