using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuthapp;
using Newtonsoft;

namespace Loader
{
    public partial class GrabberSelf : UserControl
    {


        public GrabberSelf()
        {
            InitializeComponent();
        }
        private void sendmsg_Click(object sender, EventArgs e) // Get Ip Public
        {
            chatmsg.Clear();
            MessageBox.Show("Give Me A Second...", "Please Wait A Second", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string url = "http://checkip.dyndns.org";
            System.Net.WebRequest req = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            string response = sr.ReadToEnd().Trim();
            string[] ipAddressWithText = response.Split(':');
            string ipAddressWithHTMLEnd = ipAddressWithText[1].Substring(1);
            string[] ipAddress = ipAddressWithHTMLEnd.Split('<');
            string mainIP = ipAddress[0];
            chatmsg.Text = mainIP;

        }
        private void siticoneRoundedButton1_Click(object sender, EventArgs e) // Get Ip Local
        {
            IPHostEntry host;
            string localIp = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIp = ip.ToString();
                    chatmsg.Clear();
                    chatmsg.Text = localIp;
                }
            }
        }

        private void GrabberSelf_Load(object sender, EventArgs e)
        {

        }
    }
}