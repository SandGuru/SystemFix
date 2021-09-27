using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemFix
{
    public partial class RegisterDevices : Form
    {
        public RegisterDevices()
        {
            InitializeComponent();
        }

        private bool RegisterClient(string name, string lastname)
        {
            if (getName.Text.Length == 0 | getLastName.Text.Length == 0 | getID.Text.Length == 0)
            {
                //Message("Error", "Por favor llene todos los campos para continuar.");
                //return false;
            }
            else
            {
                Client.Name = name;
                Client.LastName = lastname;
            }
            foreach (Clients item in Clients.ClientData)
            {
                if (item.ID.Contains(Client.ID) | item.ID == Client.ID)
                {
                    if (item.ID == getID.Text)
                    {
                        return true;
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            List<Clients> Client = new List<Clients>();
            Client.Add(new Clients() { Name = Convert.ToString(getName) });
        }

        private readonly Clients Client = new Clients();

        private void RegisterDevices_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
