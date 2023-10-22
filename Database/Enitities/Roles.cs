using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Connection;
using Models.Models;

namespace Database.Entities
{
    public class Roles
    {
        ConnectionBD Connection = new ConnectionBD();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        public void Insertar(RolesCls rol)
        {
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_InsertarRol";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", rol.Nombre);

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

        public void Actualizar(RolesCls rol)
        {
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_ActualizarRol";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RolID", rol.RolID);
                cmd.Parameters.AddWithValue("@Nombre", rol.Nombre);

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
        public void Eliminar(int rolID)
        {
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_EliminarRol";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@RolID", rolID);

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
        public List<RolesCls> Consultar()
        {
            List<RolesCls> roles = new List<RolesCls>();
            try
            {
                cmd.Connection = Connection.OpenConecction();
                cmd.CommandText = "sp_ConsultarRoles";
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    roles.Add(new RolesCls
                    {
                        RolID = Convert.ToInt32(reader["RolID"]),
                        Nombre = reader["Nombre"].ToString()
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
            return roles;
        }
    }
}
