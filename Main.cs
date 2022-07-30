using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
// If You Use Anything On Code Please Credit ^^ Thank you !


using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;

namespace KeyAuthapp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void Main_Load(object sender, EventArgs e)
        {
            grabberSelf1.Hide();
            anyWebSourceCode1.Hide();
            grabber1.Hide();
        }

        private void sendmsg_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            grabberSelf1.Show();
            anyWebSourceCode1.Hide();
            grabber1.Hide();
        }

        private void grabberSelf1_Load(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            grabberSelf1.Hide();
            grabber1.Hide();
            anyWebSourceCode1.Show();
        }

        private void siticoneControlBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            grabber1.Show();
        }

        private void siticoneRoundedButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Need Any Help Or Question On Program Or Coding ? Contact Me Rexy#4170", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

