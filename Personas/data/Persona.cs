using Microsoft.Win32;
using MySql.Data.MySqlClient;
using Personas.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personas.data
{
    internal class ConexionMysql
    {
        private string connectionString = "server=localhost;Database=db_universidad;Uid=root; Pwd=BryanJRH0801";
        MySqlConnection connection;
        public ConexionMysql()
        {
            connection = new MySqlConnection(connectionString);
        }
        public DataTable LeerPersonajes()
        {
            DataTable usuariosPersona = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM usuarios_persona";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(usuariosPersona);
                    }
                }
            }
            return usuariosPersona;
        }
            public void Insertar(PersonaModel prs)
        {
            try
            {
                string query = "INSERT INTO usuarios_persona (id_persona, nombre, apellido, persona, estado, asociacion, arma, juego) VALUES (@id_persona, @nombre, @apellido, @persona, @estado, @asociacion, @arma, @juego)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id_persona", prs.id_persona);
                cmd.Parameters.AddWithValue("@nombre", prs.nombre);
                cmd.Parameters.AddWithValue("@apellido", prs.apellido);
                cmd.Parameters.AddWithValue("@persona", prs.persona);
                cmd.Parameters.AddWithValue("@estado", prs.estado);
                cmd.Parameters.AddWithValue("@asociacion", prs.asociacion);
                cmd.Parameters.AddWithValue("@arma", prs.arma);
                cmd.Parameters.AddWithValue("@juego", prs.juego);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public int ActualizarConfidente(PersonaModel prs)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea actualizar este confidente?", "Confirmación de actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        string query = "UPDATE usuarios_persona SET nombre = @nombre, apellido = @apellido, persona = @persona, estado = @estado, asociacion = @asociacion, arma = @arma, juego = @juego WHERE id_persona = @id_persona";
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@id_persona", prs.id_persona);
                            cmd.Parameters.AddWithValue("@nombre", prs.nombre);
                            cmd.Parameters.AddWithValue("@apellido", prs.apellido);
                            cmd.Parameters.AddWithValue("@persona", prs.persona);
                            cmd.Parameters.AddWithValue("@estado", prs.estado);
                            cmd.Parameters.AddWithValue("@asociacion", prs.asociacion);
                            cmd.Parameters.AddWithValue("@arma", prs.arma);
                            cmd.Parameters.AddWithValue("@juego", prs.juego);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Tu vinculo fue actualizado correctamente.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }
             finally
            {
                connection.Close();
            }

            return 0;
        }
        public void EliminarConfidente(int id)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres eliminar este confidente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string sql = "DELETE FROM usuarios_persona WHERE id_persona = @id_persona";
                        using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@id_persona", id);

                            int mensaje = cmd.ExecuteNonQuery();
                            if (mensaje == 0)
                            {
                                MessageBox.Show("No se encontró ningún registro con el ID proporcionado.");
                            }
                            else
                            {
                                MessageBox.Show("Se rompio el vinculo eficientemente.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro: " + ex.Message);
            }
        }

        public PersonaModel BuscarPorId(int id)
        {
            PersonaModel persona = null;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM usuarios_persona WHERE id_persona = @id_persona";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id_persona", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                persona = new PersonaModel
                                {
                                    id_persona = reader.GetInt32("id_persona"),
                                    nombre = reader.GetString("nombre"),
                                    apellido = reader.GetString("apellido"),
                                    persona = reader.GetString("persona"),
                                    estado = reader.GetString("estado"),
                                    asociacion = reader.GetString("asociacion"),
                                    arma = reader.GetString("arma"),
                                    juego = reader.GetString("juego")
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar por ID: " + ex.Message);
            }

            return persona;
        }
    }
}




