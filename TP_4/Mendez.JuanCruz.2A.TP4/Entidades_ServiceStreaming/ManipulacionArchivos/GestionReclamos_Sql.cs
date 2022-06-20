using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace BookCloud_Entidades
{
    public static class GestionReclamos_Sql
    {
        private static String ruta;
        private static SqlConnection conexion;
        private static SqlCommand comando;
        private static SqlDataReader reader;

        static GestionReclamos_Sql()
        {
            GestionReclamos_Sql.ruta = @"Server=localhost;Database=RECLAMOS_DB;Trusted_Connection=True;";
            GestionReclamos_Sql.conexion = new SqlConnection(ruta);
            GestionReclamos_Sql.comando = new SqlCommand();
            GestionReclamos_Sql.comando.Connection = GestionReclamos_Sql.conexion;
            GestionReclamos_Sql.comando.CommandType = CommandType.Text;
        }

        public static void ProbarConexion()
        {
            try
            {
                GestionReclamos_Sql.conexion.Open();
            }
            catch (Exception ex)
            {
                throw new SqlTypeExcepcion($"Error al conectarse con la base de datos RECLAMOS.DB, reintente..\nError: {ex.Message}",ex);
            }
            finally
            {
                if (GestionReclamos_Sql.conexion.State == ConnectionState.Open)
                {
                    GestionReclamos_Sql.conexion.Close();
                }
            }
        }

        public static Dictionary<Int32, String> Leer_Reclamos()
        {
            Dictionary<Int32 , String> reclamosPendietes = new();
            String consulta;
            Int32 id;
            String reclamo;

            try
            {
                GestionReclamos_Sql.comando.Parameters.Clear();
                consulta = "SELECT * FROM RECLAMOS_PENDIENTES";

                GestionReclamos_Sql.conexion.Open();
                GestionReclamos_Sql.comando.CommandText = consulta;
                using (GestionReclamos_Sql.reader = GestionReclamos_Sql.comando.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        id = (Int32)reader["ID"];
                        reclamo = reader["RECLAMO"].ToString();

                        reclamosPendietes.Add(id , reclamo);
                    }
                }             
            }
            catch(Exception ex)
            {
                throw new SqlTypeExcepcion($"Error al conseguir la informacion de reclamos, de la base RECLAMOS.DB , reintente..\nError: {ex.Message}", ex);
            }
            finally
            {
                if(GestionReclamos_Sql.conexion.State == ConnectionState.Open)
                {
                    GestionReclamos_Sql.conexion.Close();
                }
            }

            return reclamosPendietes;
        }

        public static bool Liberar_Reclamo(int id)
        {
            bool rta = true;
            String consulta;

            try
            {
                GestionReclamos_Sql.comando.Parameters.Clear();
                GestionReclamos_Sql.comando.Parameters.AddWithValue("@id", id);
                consulta = "DELETE FROM RECLAMOS_PENDIENTES WHERE ID = @id";
                GestionReclamos_Sql.comando.CommandText = consulta;                

                GestionReclamos_Sql.conexion.Open();

                int filasAfectadas = GestionReclamos_Sql.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception ex)
            {
                throw new SqlTypeExcepcion($"Error al eliminar el reclamo, de la base RECLAMOS.DB , reintente..\nError: {ex.Message}", ex);
            }
            finally
            {
                if (GestionReclamos_Sql.conexion.State == ConnectionState.Open)
                {
                    GestionReclamos_Sql.conexion.Close();
                }
            }

            return rta;
        }

        public static bool Agregar_Reclamo(String reclamo)
        {
            bool rta = true;
            String consulta;

            try
            {
                GestionReclamos_Sql.comando.Parameters.Clear();
                consulta = $"INSERT INTO dbo.RECLAMOS_PENDIENTES (RECLAMO) VALUES ( @reclamo )";
                GestionReclamos_Sql.comando.Parameters.AddWithValue("@reclamo", reclamo);
                GestionReclamos_Sql.comando.CommandText = consulta;

                GestionReclamos_Sql.conexion.Open();

                int filasAfectadas = GestionReclamos_Sql.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception ex)
            {
                throw new SqlTypeExcepcion($"Error al agregar el reclamo, en la base RECLAMOS.DB , reintente..\nError: {ex.Message}", ex);
            }
            finally
            {
                if (GestionReclamos_Sql.conexion.State == ConnectionState.Open)
                {
                    GestionReclamos_Sql.conexion.Close();
                }
            }
            return rta;
        }
    }
}
