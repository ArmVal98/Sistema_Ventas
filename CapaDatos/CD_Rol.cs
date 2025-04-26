using CapaEntidad;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Rol
    {
        public List<Rol> Listar()
        {
            List<Rol> Lista = new List<Rol>();

            using (NpgsqlConnection conection = new NpgsqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("SELECT id_rol, descripcion FROM rol");

                    NpgsqlCommand cmd = new NpgsqlCommand(query.ToString(), conection);
                    cmd.CommandType = System.Data.CommandType.Text;

                    conection.Open();

                    using (NpgsqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Rol
                            {
                                id_rol = Convert.ToInt32(dr["id_rol"]),
                                descripcion = dr["descripcion"].ToString()
                            }) ;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Lista = new List<Rol>();
                }
            }
            return Lista;
        }
    }
}
