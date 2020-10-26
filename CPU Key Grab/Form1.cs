using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JRPC_Client;
using XDevkit;

namespace CPU_Key_Grab
{
    public partial class Form1 : Form
    {
        IXboxConsole Console;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.Connect(out Console);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.CheckState == CheckState.Checked)
            {
                textBox1.Text = Console.GetCPUKey();
                Clipboard.SetText(textBox1.Text);
            }
            else if(checkBox1.CheckState == CheckState.Unchecked)
            {
                textBox1.Text = Console.GetCPUKey();
            }
        }
    }
}
