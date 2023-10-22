using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Connection;
using Models.Models;

namespace Database.Entities
{
    public class ServicioRefacciones
    {
        ConnectionBD Connection = new ConnectionBD();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        public void Insertar(ServicioRefaccionesCls servicioRefaccion)
        {
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_InsertarServicioRefaccion";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ServicioID", servicioRefaccion.ServicioID);
                cmd.Parameters.AddWithValue("@RefaccionID", servicioRefaccion.RefaccionID);
                cmd.Parameters.AddWithValue("@Cantidad", servicioRefaccion.Cantidad);

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
        public void Actualizar(ServicioRefaccionesCls servicioRefaccion)
        {
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_ActualizarServicioRefaccion";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ServicioID", servicioRefaccion.ServicioID);
                cmd.Parameters.AddWithValue("@RefaccionID", servicioRefaccion.RefaccionID);
                cmd.Parameters.AddWithValue("@Cantidad", servicioRefaccion.Cantidad);

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
        public void Eliminar(int servicioID, int refaccionID)
        {
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_EliminarServicioRefaccion";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ServicioID", servicioID);
                cmd.Parameters.AddWithValue("@RefaccionID", refaccionID);

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

        public List<ServicioRefaccionesCls> Consultar()
        {
            List<ServicioRefaccionesCls> servicioRefacciones = new List<ServicioRefaccionesCls>();
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_ConsultarServicioRefacciones";
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    servicioRefacciones.Add(new ServicioRefaccionesCls
                    {
                        ServicioID = Convert.ToInt32(reader["ServicioID"]),
                        RefaccionID = Convert.ToInt32(reader["RefaccionID"]),
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
            return servicioRefacciones;
        }
        public List<ServicioRefaccionesDetalladoCls> ConsultarDetallado()
        {
            List<ServicioRefaccionesDetalladoCls> listaDetallada = new List<ServicioRefaccionesDetalladoCls>();
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_ConsultarServicioRefaccionesDetallado";
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listaDetallada.Add(new ServicioRefaccionesDetalladoCls
                    {
                        ServicioID = Convert.ToInt32(reader["ServicioID"]),
                        Marca = reader["Marca"].ToString(),
                        Modelo = reader["Modelo"].ToString(),
                        Año = Convert.ToInt32(reader["Año"]),
                        Dueño = reader["Dueño"].ToString(),
                        FechaServicio = Convert.ToDateTime(reader["FechaServicio"]),
                        Refaccion = reader["Refaccion"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        Precio = Convert.ToDecimal(reader["Precio"]),
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
            return listaDetallada;
        }


    }
}
