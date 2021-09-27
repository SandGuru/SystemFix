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
        private void button1_Click(object sender, EventArgs e)
        {
            Clients clients = new Clients(getName.Text, getLastName.Text, getID.Text, getPhone.Text, getAddress.Text, getTempPay.Text, getMark.Text, getReference.Text, getDetails.Text, getType_Device.Text);
            Global.lista.Add(clients);

            getName.Text = "";
            getLastName.Text = "";
            getPhone.Text = "";
            getID.Text = "";
            getAddress.Text = "";
            getTempPay.Text = "";
            getMark.Text = "";
            getDetails.Text = "";
            getReference.Text = "";
            getType_Device.ValueMember = "";
        }
    }
}
