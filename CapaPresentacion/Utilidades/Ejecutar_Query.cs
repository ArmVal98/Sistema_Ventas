using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Utilidades
{
    public class Ejecutar_Query
    {
        public DataTable Correr_Query(string in_query, NpgsqlConnection conn)
        {
            DataTable dt = new DataTable();

            NpgsqlCommand cmd = new NpgsqlCommand(in_query, conn);

            NpgsqlDataReader dr = cmd.ExecuteReader();

            dt.Load(dr);

            dr.Close();

            return dt;
        }
    }
}
