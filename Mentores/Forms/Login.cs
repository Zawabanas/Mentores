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
using Mentores.Forms;
using Npgsql;

namespace Mentores
{
    public partial class Login : KryptonForm
    {
        public Login()
        {
            InitializeComponent();
            this.Load += new EventHandler(Label);
        }

        private void Label(object sender, EventArgs e)
        {
            lbTitle.Select();
        }
        public void loginSesion()
        {
            Connection conexion = new Connection();

            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                lb_Mesagge.Visible = true;
                lb_Mesagge.Text = ("Por favor, ingrese un usuario");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lb_Mesagge.Visible = true;
                lb_Mesagge.Text = ("Por favor, ingrese una contraseña");
                return;
            }

            if (conexion.Conect())
            {
                var PgSQL = "SELECT * FROM usuarios WHERE nombre_usuario = @nombre_usuario AND contraseña = @contraseña";

                using (var cmd = new NpgsqlCommand(PgSQL, conexion.conn))
                {
                    cmd.Parameters.AddWithValue("nombre_usuario", txtUser.Text.Trim());
                    cmd.Parameters.AddWithValue("contraseña", txtPassword.Text.Trim());

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int User_id = reader.GetInt32(0);
                            var Name = reader.GetString(1);
                            var Lastname = reader.GetString(2);
                            var Username = reader.GetString(3);
                            var Email = reader.GetString(4);
                            var Password = reader.GetString(5);
                            var Role = reader.GetString(6);
                            lb_Mesagge.Visible = true;
                            CurrentUser.Id = User_id;
                            CurrentUser.Name = Name;
                            CurrentUser.LastName = Lastname;
                            CurrentUser.UserName = Username;
                            CurrentUser.Email = Email;
                            CurrentUser.Password = Password;
                            CurrentUser.Role = Role;

                            lb_Mesagge.Text = ("Bienvenido/a '" + Role + " " + Name + ":'");
                            if (Role == "Mentor/a")
                            {
                                btnLogin.Enabled = false;
                                btnSigin.Enabled = false;
                                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                                timer.Interval = 1000;
                                timer.Tick += new EventHandler(LoginMessage_Tick);
                                timer.Start();

                            }
                            else if (Role == "Alumno/a")
                            {
                                btnLogin.Enabled = false;
                                btnSigin.Enabled = false;
                                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                                timer.Interval = 1000;
                                timer.Tick += new EventHandler(LoginMessage_Tick);
                                timer.Start();

                            }
                        }
                        else
                        {
                            lb_Mesagge.Visible = true;
                            lb_Mesagge.Text = ("Usuario o Contraseña Incorrectos");
                        }
                    }
                }
                conexion.Desconectar();
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginSesion();
        }

        private void btnSigin_Click(object sender, EventArgs e)
        {
            Form formBuscar = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x.GetType() == typeof(Sigin));

            if (formBuscar != null)
            {
                formBuscar.Activate();
                formBuscar.Focus();
            }
            else
            {
                Sigin sigin = new Sigin();
                sigin.Show();
            }
        }

        private void LoginMessage_Tick(object sender, EventArgs e)
        {
            ((System.Windows.Forms.Timer)sender).Stop();

            this.Hide();

            Principal principal = new Principal();
            principal.Show();
        }

        private void lbLook_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
        }


        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Nombre de usuario")
            {
                txtUser.Clear();
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Clear();
            }
        }
    }
}
