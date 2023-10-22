using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Connection;
using Models.Models;

namespace Database.Entities
{
    public class Refacciones
    {
        ConnectionBD Connection = new ConnectionBD();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        public void Insertar(RefaccionesCls refaccion)
        {
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_InsertarRefaccion";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", refaccion.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", refaccion.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", refaccion.Precio);

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

        public void Actualizar(RefaccionesCls refaccion)
        {
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_ActualizarRefaccion";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RefaccionID", refaccion.RefaccionID);
                cmd.Parameters.AddWithValue("@Nombre", refaccion.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", refaccion.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", refaccion.Precio);

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
        public void Eliminar(int refaccionID)
        {
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_EliminarRefaccion";
                cmd.CommandType = CommandType.StoredProcedure;

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

        public List<RefaccionesCls> Consultar()
        {
            List<RefaccionesCls> refacciones = new List<RefaccionesCls>();
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_ConsultarRefacciones";
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    refacciones.Add(new RefaccionesCls
                    {
                        RefaccionID = Convert.ToInt32(reader["RefaccionID"]),
                        Nombre = reader["Nombre"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        Precio = Convert.ToDecimal(reader["Precio"])
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
            return refacciones;
        }
    }
}
