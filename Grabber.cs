using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loader
{
    public partial class Grabber : UserControl
    {

        public Grabber()
        {
            InitializeComponent();
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e) // Get Computer Names
        {
            string ComputerName = Environment.MachineName;
            chatmsg.Text = ComputerName;
        }

        private void Grabber_Load(object sender, EventArgs e)
        {

        }
        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        { // that info of processor and graphic card ^^
            SelectQuery Sq = new SelectQuery("Win32_Processor");
            ManagementObjectSearcher objOSDetails = new ManagementObjectSearcher(Sq);
            ManagementObjectCollection osDetailsCollection = objOSDetails.Get();
            StringBuilder sb = new StringBuilder();
            foreach (ManagementObject mo in osDetailsCollection)
            {
                sb.AppendLine(string.Format(" {0}", (string)mo["Name"]));
            }
            chatmsg.Text = sb.ToString();
            ManagementObjectSearcher searcher
     = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");

            string graphicsCard = string.Empty;
            foreach (ManagementObject mo in searcher.Get())
            {
                foreach (PropertyData property in mo.Properties)
                {
                    if (property.Name == "Description")
                    {
                        graphicsCard = property.Value.ToString();
                    }
                }
                Thread.Sleep(2500);
                chatmsg.Text = graphicsCard;

            }
        }
    }
}