using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //to DllImport

namespace ApagarMonitor
{
    public partial class Form1 : Form
    {
        Boolean handled = false;
        Boolean estaEncendido = true;
        private const int MONITOR_ON = -1;
        private const int MONITOR_STANBY = 1;
        private const int MONITOR_OFF = 2;
        public int WM_SYSCOMMAND = 0x0112;
        public int SC_MONITORPOWER = 0xF170; //Using the system pre-defined MSDN constants that can be used by the SendMessage() function .
        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);
        //To call a DLL function from C#, you must provide this declaration .
        //*****************************************************************************************
        // Constantes para SetWindowsPos
        //   Valores de wFlags
        const int SWP_NOSIZE = 0x1;
        const int SWP_NOMOVE = 0x2;
        const int SWP_NOACTIVATE = 0x10;
        const int wFlags = SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE;
        //   Valores de hwndInsertAfter
        const int HWND_TOPMOST = -1;
        const int HWND_NOTOPMOST = -2;
        [DllImport("user32.DLL")]
        private extern static void SetWindowPos(
               int hWnd, int hWndInsertAfter,
               int X, int Y,
               int cx, int cy,
               int wFlags);

        //******************************************************************************
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SetWindowPos(this.Handle.ToInt32(), HWND_TOPMOST, 0, 0, 0, 0, wFlags);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (handled)
            {
                handled = false;   //deshabilita para el boton Space
                return;
            }
            if (estaEncendido)
            {
                estaEncendido = false;
                SendMessage(this.Handle.ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_OFF);                
            }else{
                // System.Threading.thread.sleep(28800000);
                estaEncendido = true;
                SendMessage(this.Handle.ToInt32(), WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_ON);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) //cerrar Ventana con boton Middle Mouse
            {
                Application.ExitThread();
            }
        }
        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space )   //deshabilita boton
            {
                handled = true;
            }           
        }        
    }
}