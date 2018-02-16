using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppJanci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            bSend.Tag = 1;
            bSend2.Tag = 2;
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            string s = b.Tag + ": " + tbMessage.Text;

            Chat.Text += s + Environment.NewLine;

            tbMessage.Text = "";

        }

        
    }
}
