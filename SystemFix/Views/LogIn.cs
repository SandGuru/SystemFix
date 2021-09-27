using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows;


namespace SystemFix
{

    //Clase del formulario del LogIn [Diseño]
    public partial class LogIn : Form
    {

        //Inicializa la vista del formulario
        public LogIn()
        {
            InitializeComponent();

        }

        private readonly Users User = new Users();

        //Botones para accionar en la aplicación
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //Cajas de texto para el ingreso de datos del usuario

        //Al entrar a la caja de texto, se limpia el placeholder "USUARIO"
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO") 
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.White;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "") {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA") {
                txtPass.Text = "";
                txtPass.ForeColor = Color.White;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "") {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
                txtPass.ForeColor = Color.DimGray;
            }
        }

        private void Message(string type, string message)
        {
            txtMessage.Visible = true;
            txtMessage.Text = $"{type}: {message}";
        }

        private bool Verify(string username, string password)
        {
            if (txtUser.Text.Length == 0 | txtPass.Text.Length == 0)
            {
                Message("Error", "Por favor llene todos los campos para continuar.");
                return false;
            }
            else
            {
                User.Username = username;
                User.Password = password;
                foreach (Users item in Global.UserData)
                {
                    if (item.Username.Contains(User.Username) | item.Username == User.Username)
                    {
                        if (item.Password.Contains(txtPass.Text) | item.Password == txtUser.Text)
                        {
                            return true;
                        }
                        return false;
                    }
                    else
                    {
                        txtUser.Text = "USUARIO";
                        txtUser.ForeColor = Color.DimGray;
                        txtPass.Text = "CONTRASEÑA";
                        txtPass.UseSystemPasswordChar = false;
                        txtPass.ForeColor = Color.DimGray;
                        return false;
                    }
                }
                return false;
            }
        }

        public void btnLogIn_Click(object sender, EventArgs e)
        {
            Main Principal = new Main();

            if (Verify(txtUser.Text, txtPass.Text))
            {
                this.Visible = false;
                Principal.Show();
            }
            else
                Message("¡Error!", "Las credenciales no son correctas.");
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Main Principal = new Main();
              
                if (Verify(txtUser.Text, txtPass.Text))
                {
                    this.Visible = false;
                    Principal.Show();
                }
                else
                    Message("¡Error!", "Las credenciales no son correctas.");
            }
        }
        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Main Principal = new Main();

                if (Verify(txtUser.Text, txtPass.Text))
                {
                    this.Visible = false;
                    Principal.Show();
                }
                else
                    Message("¡Error!", "Las credenciales no son correctas.");
            }
        }
    }
}