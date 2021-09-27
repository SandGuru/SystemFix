﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SystemFix
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //Permite desplazar la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void FormControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OpenForm(object formhija)
        {
            if (this.PanelContainer.Controls.Count > 0)
                this.PanelContainer.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContainer.Controls.Add(fh);
            this.PanelContainer.Tag = fh;
            fh.Show();

        }

        private void btnRegDevice_Click(object sender, EventArgs e)
        {
            OpenForm(new RegisterDevices());
        }





        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn Iniciar = new LogIn();

            if (MessageBox.Show("Está a punto de cerrar sesión, ¿Desea continuar?","¡Advertencia!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
                Iniciar.Show();
        }
    }
}
