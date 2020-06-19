using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace admin_FcoGuerrero
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\System32\\Taskmgr.exe");
            //SendKeys.SendWait("TAB");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\system32\\notepad.exe");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Process.Start("C:\\Windows\\System32\\cmd.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\System32\\control.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\system32\\services.msc");
        }

        private void button6_Click(object sender, EventArgs e)
        {
           Process.Start("C:\\Windows\\system32\\eventvwr.msc");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\system32\\WF.msc");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\system32\\compmgmt.msc");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\system32\\cleanmgr.exe");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\fcis\\AppData\\Local\\Temp");         
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\System32\\dcomcnfg.exe");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\System32\\msconfig.exe");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\System32\\msinfo32.exe"); 
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\System32\\mstsc.exe"); 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\System32\\psr.exe");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\System32\\resmon.exe");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Windows\\System32\\certmgr.exe");
        }

        private void button19_Click(object sender, EventArgs e)
        {
           Process.Start("C:\\Windows\\System32\\diskmgmt.msc");
        }
    }
}
