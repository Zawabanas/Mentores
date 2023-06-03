using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Mentores.Classes;
using Npgsql;

namespace Mentores.Forms
{
    public partial class Sigin : KryptonForm
    {
        public Sigin()
        {
            InitializeComponent();
            cbUserRole.SelectedIndex = 0;
            this.Load += new EventHandler(label);
        }

        private void label(object sender, EventArgs e)
        {
            lb_Title.Select();
        }

        public void Register()
        {
            Connection Conn = new Connection();

            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                lbMesagge.Visible = true;
                lbMesagge.Text = ("Por favor, ingrese un nombre");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                lbMesagge.Visible = true;
                lbMesagge.Text = ("Por favor, ingrese un apellido");
                return;
            }


            if (string.IsNullOrWhiteSpace(tbUserName.Text))
            {
                lbMesagge.Visible = true;
                lbMesagge.Text = ("Por favor, ingrese un nombre de usuario");
                return;
            }
            string email = tbEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                lbMesagge.Visible = true;
                lbMesagge.Text = "Por favor, ingrese una dirección de correo electrónico";
                return;
            }

            bool isValidEmail = false;

            try
            {
                MailAddress mailAddress = new MailAddress(email);
                if (mailAddress.Host.ToLower() == "delicias.tecnm.mx")
                {
                    isValidEmail = true;
                }
                else
                {
                    lbMesagge.Visible = true;
                    lbMesagge.Text = "Por favor, ingrese una dirección de correo electrónico con dominio @delicias.tecnm.mx";
                    return;
                }
            }
            catch (FormatException)
            {
                isValidEmail = false;
            }

            if (!isValidEmail)
            {
                lbMesagge.Visible = true;
                lbMesagge.Text = "Por favor, ingrese una dirección de correo electrónico válida";
                return;
            }


            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                lbMesagge.Visible = true;
                lbMesagge.Text = ("Por favor, ingrese una contraseña");
                return;
            }

            if (cbUserRole.SelectedIndex < 1)
            {
                lbMesagge.Visible = true;
                lbMesagge.Text = "Seleccione una opción válida en el tipo de usuario";
                return;
            }


            String Seleccion = cbUserRole.SelectedItem.ToString();


            if (Conn.Conect())
            {
                var PgSQL = "INSERT INTO usuarios (nombre, apellido, nombre_usuario, correo_electronico, contraseña, roles) " +
                    "VALUES ('" + tbName.Text + "', '" + tbLastName.Text + "', '" + tbUserName.Text + "', '" + tbEmail.Text +
                    "', '" + tbPassword.Text + "', '" + cbUserRole.SelectedItem.ToString() + "')";

                var checkEmailQuery = "SELECT COUNT(*) FROM usuarios WHERE correo_electronico = @correo_electronico";
                using (var checkUserCmd = new NpgsqlCommand(checkEmailQuery, Conn.conn))
                {
                    checkUserCmd.Parameters.AddWithValue("correo_electronico", tbEmail.Text.Trim());
                    int userCount = Convert.ToInt32(checkUserCmd.ExecuteScalar());
                    if (userCount > 0)
                    {
                        lbMesagge.Visible = true;
                        lbMesagge.Text = "El correo ya fue registrado. Por favor, elija otro.";
                        return;
                    }
                }
                var checkUserQuery = "SELECT COUNT(*) FROM usuarios WHERE nombre_usuario = @nombre_usuario";
                using (var checkUserCmd = new NpgsqlCommand(checkUserQuery, Conn.conn))
                {
                    checkUserCmd.Parameters.AddWithValue("nombre_usuario", tbUserName.Text.Trim());
                    int userCount = Convert.ToInt32(checkUserCmd.ExecuteScalar());
                    if (userCount > 0)
                    {
                        lbMesagge.Visible = true;
                        lbMesagge.Text = "El nombre de usuario ya existe. Por favor, elija otro.";
                        return;
                    }
                }

                using (var cmd = new NpgsqlCommand(PgSQL, Conn.conn))
                {
                    cmd.Parameters.AddWithValue("nombre", tbName.Text.Trim());
                    cmd.Parameters.AddWithValue("apellidos", tbLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("nombre_usuario", tbUserName.Text.Trim());
                    cmd.Parameters.AddWithValue("correo_electronico", tbEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("contraseña", tbPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("roles", cbUserRole.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                }
                Conn.Desconectar();
                lbMesagge.Visible = true;
                lbMesagge.Text = ("Usuario registrado con exito");
                btnSingup.Enabled = false;

                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 5000;
                timer.Tick += new EventHandler(signinMessage_Tick);
                timer.Start();


            }

        }

        private void btnSingup_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void signinMessage_Tick(object sender, EventArgs e)
        {
            ((System.Windows.Forms.Timer)sender).Stop();

            this.Close();

            Form formBuscar = Application.OpenForms.Cast<Form>()
                                    .FirstOrDefault(x => x.GetType() == typeof(Login));

            if (formBuscar != null)
            {
                formBuscar.Activate();
                formBuscar.Focus();
            }
            else
            {
                Login login = new Login();
                login.Show();
            }
        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            if (tbName.Text == "Nombre")
            {
                tbName.Clear();
            }
        }

        private void tbLastName_Enter(object sender, EventArgs e)
        {
            if (tbLastName.Text == "Apellido")
            {
                tbLastName.Clear();
            }
        }

        private void tbUserName_Enter(object sender, EventArgs e)
        {
            if (tbUserName.Text == "Nombre de usuario")
            {
                tbUserName.Clear();
            }
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "E-mail")
            {
                tbEmail.Clear();
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Contraseña")
            {
                tbPassword.Clear();
            }
        }
    }
}
