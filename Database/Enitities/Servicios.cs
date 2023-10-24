using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Connection;
using Models.Models;

namespace Database.Entities
{
    public class Servicios
    {
        ConnectionBD Connection = new ConnectionBD();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        public void Insertar(ServicioCls servicio)
        {
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_InsertarServicio";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@VehiculoID", servicio.VehiculoID);
                cmd.Parameters.AddWithValue("@Fecha", servicio.Fecha);
                cmd.Parameters.AddWithValue("@Estatus", servicio.Estatus);

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


        public void Actualizar(ServicioCls servicio)
        {
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_ActualizarServicio";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ServicioID", servicio.ServicioID);
                cmd.Parameters.AddWithValue("@VehiculoID", servicio.VehiculoID);
                cmd.Parameters.AddWithValue("@Fecha", servicio.Fecha);
                cmd.Parameters.AddWithValue("@Estatus", servicio.Estatus);

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

        public void Eliminar(int servicioID)
        {
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_EliminarServicio";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ServicioID", servicioID);

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

        public List<ServicioCls> Consultar()
        {
            List<ServicioCls> servicios = new List<ServicioCls>();
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_ConsultarServicios";
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    servicios.Add(new ServicioCls
                    {
                        ServicioID = Convert.ToInt32(reader["ServicioID"]),
                        VehiculoID = Convert.ToInt32(reader["VehiculoID"]),
                        Fecha = Convert.ToDateTime(reader["Fecha"]),
                        Estatus = reader["Estatus"].ToString()
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
            return servicios;
        }
        public List<EstatusContadorCls> ContarPorEstatus()
        {
            List<EstatusContadorCls> conteos = new List<EstatusContadorCls>();
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_ContarPorEstatus";
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    conteos.Add(new EstatusContadorCls
                    {
                        Estatus = reader["Estatus"].ToString(),
                        Cantidad = Convert.ToInt32(reader["Cantidad"])
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
            return conteos;
        }


        public List<ServicioConVehiculoCls> ConsultarServiciosConVehiculos()
        {
            List<ServicioConVehiculoCls> serviciosConVehiculos = new List<ServicioConVehiculoCls>();
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_ConsultarServiciosConVehiculos";
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    serviciosConVehiculos.Add(new ServicioConVehiculoCls
                    {
                        ServicioID = Convert.ToInt32(reader["ServicioID"]),
                        Marca = reader["Marca"].ToString(),
                        Modelo = reader["Modelo"].ToString(),
                        Año = Convert.ToInt32(reader["Año"]),
                        Dueño = reader["Dueño"].ToString(),
                        Fecha = Convert.ToDateTime(reader["Fecha"]),
                        Estatus = reader["Estatus"].ToString()
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
            return serviciosConVehiculos;
        }
    }
}
