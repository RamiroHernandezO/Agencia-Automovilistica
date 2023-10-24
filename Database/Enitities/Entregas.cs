using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Connection;
using Models.Models;

namespace Database.Entities
{
    public class Entregas
    {
        ConnectionBD Connection = new ConnectionBD();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        public void Insertar(EntregaCls entrega)
        {
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_InsertarEntrega";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ServicioID", entrega.ServicioID);
                cmd.Parameters.AddWithValue("@AdminID", entrega.AdminID);
                cmd.Parameters.AddWithValue("@FechaEntrega", entrega.FechaEntrega);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cmd.Connection = Connection.CloseConecction();
            }
        }
        public void Actualizar(EntregaCls entrega)
        {
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_ActualizarEntrega";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ServicioID", entrega.ServicioID);
                cmd.Parameters.AddWithValue("@AdminID", entrega.AdminID);
                cmd.Parameters.AddWithValue("@FechaEntrega", entrega.FechaEntrega);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cmd.Connection = Connection.CloseConecction();
            }
        }
        public void Eliminar(int servicioID, int adminID)
        {
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_EliminarEntrega";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ServicioID", servicioID);
                cmd.Parameters.AddWithValue("@AdminID", adminID);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cmd.Connection = Connection.CloseConecction();
            }
        }
        public List<EntregaCls> Consultar()
        {
            List<EntregaCls> entregas = new List<EntregaCls>();
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_ConsultarEntregas";
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    entregas.Add(new EntregaCls
                    {
                        ServicioID = Convert.ToInt32(reader["ServicioID"]),
                        AdminID = Convert.ToInt32(reader["AdminID"]),
                        FechaEntrega = Convert.ToDateTime(reader["FechaEntrega"])
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cmd.Connection = Connection.CloseConecction();
            }
            return entregas;
        }
        public List<EntregaDetalladoCls> ConsultarDetallado()
        {
            List<EntregaDetalladoCls> entregasDetalladas = new List<EntregaDetalladoCls>();
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_ConsultarEntregasDetallado";
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    entregasDetalladas.Add(new EntregaDetalladoCls
                    {
                        ServicioID = Convert.ToInt32(reader["ServicioID"]),
                        FechaServicio = Convert.ToDateTime(reader["FechaServicio"]),
                        Estatus = reader["Estatus"].ToString(),
                        Usuario = reader["Usuario"].ToString(),
                        FechaEntrega = Convert.ToDateTime(reader["FechaEntrega"])
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cmd.Connection = Connection.CloseConecction();
            }
            return entregasDetalladas;
        }
    }
}
