using PPAI_THE_LAST_DANCE.entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_THE_LAST_DANCE.AccesoADatos
{
    public class ADGestor
    {
        //public List<Bodega> buscarBodegasConActualizacionDisp()
        //{
        //    string cadenaConexion = ConfigurationManager.AppSettings["CadenaBD"];
        //    List<Bodega> bodegas = new List<Bodega>();

        //    using (SqlConnection cn = new SqlConnection(cadenaConexion))
        //    {
        //        try
        //        {
        //            string consulta = "SELECT * FROM Bodega";

        //            using (SqlCommand cmd = new SqlCommand(consulta, cn))
        //            {
        //                cmd.CommandType = CommandType.Text;
        //                cn.Open();

        //                using (SqlDataReader reader = cmd.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        Bodega bodega = new Bodega
        //                        (
        //                            reader["CoordenadasUbicacion"].ToString(),
        //                            reader["Descripcion"].ToString(),
        //                            reader.GetDateTime(reader.GetOrdinal("FechaUltimaActualizacion")),
        //                            reader["Historia"].ToString(),
        //                            reader["Nombre"].ToString(),
        //                            reader.GetInt32(reader.GetOrdinal("PeriodoActualizacion"))
        //                        );
        //                        bodegas.Add(bodega);
        //                    }
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //    }

        //    return bodegas;
        //}

        public DataTable buscarBodegasConActualizacionDisp()                                                                    //Hace una consulta a la base de datos y retorna una tabla conteniendo los datos obtenidos
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();


                string consulta = "Select * FROM Bodega";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }

        }
    }
}
