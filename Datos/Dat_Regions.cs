using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class Dat_Regions
    {



        public void Crear (Ent_Regions regions)
        {
            using (var conexionstring = new SqlConnection(Conexion.cadenaconexion))
            {
                SqlCommand cmd = new SqlCommand("sp_CreateRegion", conexionstring);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter = new("@RegionName", SqlDbType.VarChar, 50) { Value = regions.RegionName };
                cmd.Parameters.Add(parameter);

                SqlParameter parameter2 = new("@Enabled", SqlDbType.Bit) { Value = true };
                cmd.Parameters.Add(parameter2);
                conexionstring.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(Ent_Regions regions)
        {
            using (var connection = new SqlConnection(Conexion.cadenaconexion))
            {
                SqlCommand cmd = new("sp_DeleteRegion", connection) { CommandType = CommandType.StoredProcedure };
                SqlParameter parameter0 = new("@RegionId", SqlDbType.Int) { Value = regions.RegionId };
                cmd.Parameters.Add(parameter0);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void Editar(Ent_Regions region)
        {
            using (var connection = new SqlConnection(Conexion.cadenaconexion))
            {
                SqlCommand cmd = new("sp_UpdateRegion", connection) { CommandType = CommandType.StoredProcedure };
                SqlParameter parameter0 = new("@RegionId", SqlDbType.Int) { Value = region.RegionId };
                cmd.Parameters.Add(parameter0);
                SqlParameter parameter1 = new("@RegionName", SqlDbType.VarChar, 50) { Value = region.RegionName };
                cmd.Parameters.Add(parameter1);
                SqlParameter parameter2 = new("@Enabled", SqlDbType.Bit) { Value = true };
                cmd.Parameters.Add(parameter2);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }



        public List<Ent_Regions> Listar(string Nombre)
        {
            List<Ent_Regions> regions = new List<Ent_Regions>();

            using (var connection = new SqlConnection(Conexion.cadenaconexion))
            {
              
                SqlCommand cmd = new SqlCommand("SP_ReadRegions", connection);
                cmd.CommandType = CommandType.StoredProcedure;




                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

               
                while (reader.Read())
                {

                    int RegionId = reader["RegionId"] != DBNull.Value ? Convert.ToInt32(reader["RegionId"]) : 0;
                    string RegionName = reader["RegionName"] != DBNull.Value ? Convert.ToString(reader["RegionName"]) : "";

                    regions.Add(new Ent_Regions { RegionId = RegionId, RegionName = RegionName });


                }
                reader.Close();
            }
            return regions;

        }


    }
}
