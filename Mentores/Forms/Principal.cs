using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Mentores.Classes;
using Npgsql;

namespace Mentores.Forms
{
    public partial class Principal : KryptonForm
    {
        public Principal()
        {
            InitializeComponent();

            lb_Usuario.Text = CurrentUser.Name;
            lb_rol.Text = CurrentUser.Role;
            tbNamePrincipal.Text = CurrentUser.Name;
            tbLastNamePrincipal.Text = CurrentUser.LastName;
            tbUserNamePrincipal.Text = CurrentUser.UserName;
            tbEmailPrincipal.Text = CurrentUser.Email;
            tbPasswordPrincipal.Text = CurrentUser.Password;
            CargarCursos();
            CargarInscripciones();
            CargarMaterias();
            CargarEventos();
            MostrarRecursos();
        }

        //Botones de pestaña
        private void CambiarPestaña(int indicePestaña)
        {
            tabControl1.SelectedIndex = indicePestaña;

            // Habilitar todos los botones de navegación
            btn_inicio.Enabled = true;
            btn_seleccionM.Enabled = true;
            btn_Actividades.Enabled = true;
            btn_ayuda.Enabled = true;
            btn_configuracion.Enabled = true;

            // Deshabilitar el botón correspondiente a la pestaña actual
            switch (indicePestaña)
            {
                case 0:
                    btn_inicio.Enabled = false;
                    break;
                case 1:
                    btn_seleccionM.Enabled = false;
                    break;
                case 2:
                    btn_Actividades.Enabled = false;
                    break;
                case 3:
                    btn_ayuda.Enabled = false;
                    break;
                case 4:
                    btn_configuracion.Enabled = false;
                    break;
            }
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button boton = (Guna.UI2.WinForms.Guna2Button)sender;
            int indicePestaña = Convert.ToInt32(boton.Tag);
            CambiarPestaña(indicePestaña);
        }

        private void btn_seleccionM_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button boton = (Guna.UI2.WinForms.Guna2Button)sender;
            int indicePestaña = Convert.ToInt32(boton.Tag);
            CambiarPestaña(indicePestaña);
        }

        private void btn_Actividades_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button boton = (Guna.UI2.WinForms.Guna2Button)sender;
            int indicePestaña = Convert.ToInt32(boton.Tag);
            CambiarPestaña(indicePestaña);
        }


        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button boton = (Guna.UI2.WinForms.Guna2Button)sender;
            int indicePestaña = Convert.ToInt32(boton.Tag);
            CambiarPestaña(indicePestaña);
        }

        private void btn_configuracion_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button boton = (Guna.UI2.WinForms.Guna2Button)sender;
            int indicePestaña = Convert.ToInt32(boton.Tag);
            CambiarPestaña(indicePestaña);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button boton = (Guna.UI2.WinForms.Guna2Button)sender;
            int indicePestaña = Convert.ToInt32(boton.Tag);
            CambiarPestaña(indicePestaña);
        }

        private void btnCloseSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }


        private void CargarCursos()
        {
            Connection conexion = new Connection();
            if (conexion.Conect())
            {
                string pgSql = "SELECT c.curso_id, m.nombre_materia, u.nombre AS nombre_profesor " +
                        "FROM cursos c " +
                        "INNER JOIN materias m ON c.materia_id = m.materia_id " +
                        "INNER JOIN usuarios u ON c.profesor_id = u.user_id";

                using (NpgsqlCommand command = new NpgsqlCommand(pgSql, conexion.conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewCursos.DataSource = dataTable;
                        dataGridViewCurso2.DataSource = dataTable;
                        dataGridevent.DataSource = dataTable;
                        dataGridViewcourse.DataSource = dataTable;
                    }
                }

                conexion.Desconectar();
            }
            else
            {
                Console.WriteLine("Error al conectar a la base de datos.");
            }
        }
        private void CargarInscripciones()
        {
            Connection conexion = new Connection();
            if (conexion.Conect())
            {
                string pgSql = "SELECT i.inscripcion_id, c.curso_id, m.nombre_materia, u.nombre AS nombre_profesor " +
                        "FROM inscripciones i " +
                        "INNER JOIN cursos c ON i.curso_id = c.curso_id " +
                        "INNER JOIN materias m ON c.materia_id = m.materia_id " +
                        "INNER JOIN usuarios u ON c.profesor_id = u.user_id " +
                        "WHERE i.alumno_id = " + CurrentUser.Id; // Utiliza CurrentUser.AlumnoId como condición en la cláusula WHERE

                using (NpgsqlCommand command = new NpgsqlCommand(pgSql, conexion.conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewInscripciones.DataSource = dataTable;
                    }
                }

                conexion.Desconectar();
            }
            else
            {
                Console.WriteLine("Error al conectar a la base de datos.");
            }
        }
        private void InsertarInscripcion(int cursoId, DateTime fechaInscripcion)
        {
            Connection conexion = new Connection();
            if (conexion.Conect())
            {
                string pgSql = "INSERT INTO inscripciones (curso_id, alumno_id, fecha_inscripcion) " +
                               "VALUES (@cursoId, @alumnoId, @fechaInscripcion)";

                using (NpgsqlCommand command = new NpgsqlCommand(pgSql, conexion.conn))
                {
                    // Agregar los parámetros necesarios
                    command.Parameters.AddWithValue("@cursoId", cursoId);
                    command.Parameters.AddWithValue("@alumnoId", CurrentUser.Id);
                    command.Parameters.AddWithValue("@fechaInscripcion", fechaInscripcion);

                    // Ejecutar la consulta
                    command.ExecuteNonQuery();
                }

                conexion.Desconectar();
            }
            else
            {
                Console.WriteLine("Error al conectar a la base de datos.");
            }
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView de cursos
            if (dataGridViewCursos.SelectedRows.Count > 0)
            {
                // Obtener el curso seleccionado
                DataGridViewRow cursoSeleccionado = dataGridViewCursos.SelectedRows[0];

                // Obtener el ID del curso seleccionado
                int cursoId = Convert.ToInt32(cursoSeleccionado.Cells["curso_id"].Value);

                // Obtener la fecha actual
                DateTime fechaInscripcion = DateTime.Now;

                // Insertar el nuevo registro en la tabla de inscripciones
                InsertarInscripcion(cursoId, fechaInscripcion);

                // Actualizar la visualización de las inscripciones
                CargarInscripciones();
            }
            else
            {
                MessageBox.Show("Selecciona un curso antes de agregar la inscripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBaja_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView de inscripciones
            if (dataGridViewInscripciones.SelectedRows.Count > 0)
            {
                // Obtener la inscripción seleccionada
                DataGridViewRow inscripcionSeleccionada = dataGridViewInscripciones.SelectedRows[0];

                // Obtener el ID de la inscripción seleccionada
                int inscripcionId = Convert.ToInt32(inscripcionSeleccionada.Cells["inscripcion_id"].Value);

                // Eliminar la inscripción de la tabla de inscripciones
                EliminarInscripcion(inscripcionId);

                // Actualizar la visualización de las inscripciones
                CargarInscripciones();
            }
            else
            {
                MessageBox.Show("Selecciona una inscripción antes de eliminarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EliminarInscripcion(int inscripcionId)
        {
            Connection conexion = new Connection();
            if (conexion.Conect())
            {
                string pgSql = "DELETE FROM inscripciones WHERE inscripcion_id = @inscripcionId";

                using (NpgsqlCommand command = new NpgsqlCommand(pgSql, conexion.conn))
                {
                    // Agregar el parámetro necesario
                    command.Parameters.AddWithValue("@inscripcionId", inscripcionId);

                    // Ejecutar la consulta
                    command.ExecuteNonQuery();
                }

                conexion.Desconectar();
            }
            else
            {
                Console.WriteLine("Error al conectar a la base de datos.");
            }
        }

        private void CargarMaterias()
        {
            Connection conexion = new Connection();
            if (conexion.Conect())
            {
                string pgSql = "SELECT materia_id, nombre_materia, descripcion FROM materias";

                using (NpgsqlCommand command = new NpgsqlCommand(pgSql, conexion.conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewMaterias.DataSource = dataTable;
                    }
                }

                conexion.Desconectar();
            }
            else
            {
                Console.WriteLine("Error al conectar a la base de datos.");
            }
        }

        private void CargarEventos()
        {
            Connection conexion = new Connection();
            if (conexion.Conect())
            {
                string pgSql = "SELECT e.evento_id, e.titulo, e.descripcion, e.fecha_inicio, e.fecha_fin, e.ubicacion " +
                               "FROM Eventos e " +
                               "INNER JOIN Cursos c ON e.curso_id = c.curso_id " +
                               "INNER JOIN Inscripciones i ON c.curso_id = i.curso_id " +
                               "WHERE i.alumno_id = " + CurrentUser.Id;

                using (NpgsqlCommand command = new NpgsqlCommand(pgSql, conexion.conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridEventos.DataSource = dataTable;
                    }
                }

                conexion.Desconectar();
            }
            else
            {
                Console.WriteLine("Error al conectar a la base de datos.");
            }
        }

        private void MostrarRecursos()
        {
            Connection conexion = new Connection();
            if (conexion.Conect())
            {
                string pgSql = "SELECT url, descripcion FROM recursos";

                using (NpgsqlCommand command = new NpgsqlCommand(pgSql, conexion.conn))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridRecursos.AutoGenerateColumns = false;
                        dataGridRecursos.Columns.Clear();

                        // Configurar la columna URL
                        DataGridViewTextBoxColumn urlColumn = new DataGridViewTextBoxColumn();
                        urlColumn.DataPropertyName = "url";
                        urlColumn.HeaderText = "URL";
                        urlColumn.Name = "urlColumn";
                        urlColumn.Visible = true;
                        dataGridRecursos.Columns.Add(urlColumn);

                        // Configurar la columna Descripcion
                        DataGridViewTextBoxColumn descripcionColumn = new DataGridViewTextBoxColumn();
                        descripcionColumn.DataPropertyName = "descripcion";
                        descripcionColumn.HeaderText = "Descripcion";
                        descripcionColumn.Name = "descripcionColumn";
                        descripcionColumn.Visible = true;
                        dataGridRecursos.Columns.Add(descripcionColumn);

                        dataGridRecursos.DataSource = dataTable;
                    }
                }

                conexion.Desconectar();
            }
            else
            {
                Console.WriteLine("Error al conectar a la base de datos.");
            }
        }





        private void NuevoRecurso(object sender, EventArgs e)
        {
            // Obtener los valores ingresados en los campos de texto
            string tipoRecurso = txtTiporecurso.Text;
            string url = txtUrl.Text;
            string descripcion = txtDescripcion.Text;

            // Obtener el ID del curso seleccionado en el dataGridViewCursos
            int cursoId = 0; // Variable para almacenar el ID del curso seleccionado

            if (dataGridViewCursos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewCursos.SelectedRows[0];
                if (selectedRow.Cells["curso_id"].Value != null)
                {
                    cursoId = Convert.ToInt32(selectedRow.Cells["curso_id"].Value);
                }
            }

            if (cursoId == 0)
            {
                MessageBox.Show("Seleccione un curso para asociar el recurso.");
                return;
            }

            // Insertar el recurso en la base de datos
            Connection conexion = new Connection();
            if (conexion.Conect())
            {
                string pgSql = "INSERT INTO Recursos (tipo_recurso, url, descripcion, curso_id) " +
                               "VALUES (@tipoRecurso, @url, @descripcion, @cursoId)";

                using (NpgsqlCommand command = new NpgsqlCommand(pgSql, conexion.conn))
                {
                    command.Parameters.AddWithValue("@tipoRecurso", tipoRecurso);
                    command.Parameters.AddWithValue("@url", url);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@cursoId", cursoId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Recurso insertado correctamente.");
                        // Actualizar la vista de eventos o realizar otras operaciones necesarias
                        CargarEventos();
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar el recurso.");
                    }
                }

                conexion.Desconectar();
            }
            else
            {
                Console.WriteLine("Error al conectar a la base de datos.");
            }
        }




        private void btnRegistrarMat_Click(object sender, EventArgs e)
        {
            string nombreMateria = txtMat.Text;
            string descripcion = txtDesc.Text;

            if (string.IsNullOrEmpty(nombreMateria) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            Connection conexion = new Connection();
            if (conexion.Conect())
            {
                string pgSql = "INSERT INTO materias (nombre_materia, descripcion) VALUES (@nombreMateria, @descripcion)";

                using (NpgsqlCommand command = new NpgsqlCommand(pgSql, conexion.conn))
                {
                    command.Parameters.AddWithValue("@nombreMateria", nombreMateria);
                    command.Parameters.AddWithValue("@descripcion", descripcion);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Materia agregada exitosamente.");
                        CargarMaterias(); // Actualizar la tabla de materias en el DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar la materia: " + ex.Message);
                    }
                }

                conexion.Desconectar();
            }
            else
            {
                Console.WriteLine("Error al conectar a la base de datos.");
            }
        }

        private void btnRgistrarCurso_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila
            if (dataGridViewMaterias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una materia.");
                return;
            }

            // Obtener el ID de la materia seleccionada
            int materiaId = Convert.ToInt32(dataGridViewMaterias.SelectedRows[0].Cells["materia_id"].Value);

            // Obtener el ID del usuario que inició sesión
            int usuarioId = CurrentUser.Id;

            Connection conexion = new Connection();
            if (conexion.Conect())
            {
                string pgSql = "INSERT INTO cursos (materia_id, profesor_id) VALUES (@materiaId, @profesorId)";

                using (NpgsqlCommand command = new NpgsqlCommand(pgSql, conexion.conn))
                {
                    command.Parameters.AddWithValue("@materiaId", materiaId);
                    command.Parameters.AddWithValue("@profesorId", usuarioId);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Curso registrado exitosamente.");
                        CargarCursos(); // Actualizar la tabla de cursos en el DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al registrar el curso: " + ex.Message);
                    }
                }

                conexion.Desconectar();
            }
            else
            {
                Console.WriteLine("Error al conectar a la base de datos.");
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // Obtener el rol de usuario actual
            string rolUsuario = CurrentUser.Role;

            // Verificar si el rol de usuario es "Alumno/a"
            if (rolUsuario == "Alumno/a")
            {
                // Mostrar el panel correspondiente solo para el rol de alumno

                panelAlumno.Visible = true;
                panelMentores.Visible = false;
                panelAlumnoRecursos.Visible = true;
                panelRecursosMentor.Visible = false;
            }
            else
            {
                // Ocultar el panel para otros roles

                panelAlumno.Visible = false;
                panelMentores.Visible = true;
                panelAlumnoRecursos.Visible = false;
                panelRecursosMentor.Visible = true;
            }
        }

        private void NuevoEvento_Click(object sender, EventArgs e)
        {
            btnNuevoRecursoActividades.Click += NuevoRecurso;
        }
    }
}
