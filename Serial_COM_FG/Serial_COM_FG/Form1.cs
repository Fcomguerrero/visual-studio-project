using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports; //used for scanning the serial ports

delegate void StringArgReturningVoidDelegate(string text); //used for fixing multithreading problems

namespace serial_communication
{
    public partial class serial_connection : Form
    {
        public serial_connection()
        {
            InitializeComponent();
            updateDataTimerr.Interval = 1000;
            int itemsFound = 0; //how many active ports are found

            //finding available serial ports and filling up the combo box with found port names
            foreach (string s in SerialPort.GetPortNames())
            {
                portComboBox1.Items.Add(s);//adding port name to combo box
                itemsFound++;//incrementing the items found variable
            }

            if (itemsFound < 1)
                MessageBox.Show("NO ITEMS FOUND");//if no serial devices have been found, an error message window will show up
            else
                portComboBox1.SelectedIndex = 0;//if there were found active ports, than the first one is going to be automatically selected in the combo box

        }

        private void scanButtonn_Click(object sender, EventArgs e)
        {
            int itemsFound = 0; //how many active ports are found
            portComboBox1.Items.Clear(); //limpiar
            //finding available serial ports and filling up the combo box with found port names
            foreach (string s in SerialPort.GetPortNames())
            {
                portComboBox1.Items.Add(s);//adding port name to combo box
                itemsFound++;//incrementing the items found variable
            }

            if (itemsFound < 1)
                MessageBox.Show("NO ITEMS FOUND");//if no serial devices have been found, an error message window will show up
            else
                portComboBox1.SelectedIndex = 0;//if there were found active ports, than the first one is going to be automatically selected in the combo box
        }

        private void portComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort11.IsOpen)
            {
                serialPort11.Close();
                label1.Text = "Estado: Desconectado";
            }
            serialPort11.PortName = portComboBox1.Text;         //if the value of the combo box was changed then the serial port component port name will be updated

        }

        private void connectButtonn_Click(object sender, EventArgs e)
        {
            //a try-catch statement is used for not crashing the program if the serial connection is impossible to realize 
            try
            {
                serialPort11.Open();//the specific command to open the serial port
                label1.Text = "Estado: Conectado en el puerto " + serialPort11.PortName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//displaying the error in a message box
            }
        }

        private void disconnectButtonn_Click(object sender, EventArgs e)
        {
            serialPort11.Close();
            label1.Text = "Estado: Desconectado";
            updateDataTimerr.Enabled = false;
        }

        private void updateStartButtonn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort11.IsOpen)
                {
                    serialPort11.Open();
                    label1.Text = "Estado: Conectado en el puerto " + serialPort11.PortName;
                }
                updateDataTimerr.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//displaying the error in a message box
            }
        }

        private void updateNowButtonn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort11.IsOpen)
                {
                    serialPort11.Open();
                    label1.Text = "Estado: Conectado en el puerto " + serialPort11.PortName;
                }
                //serialPort11.WriteLine("request_message");
                serialPort11.WriteLine(textBox11.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//displaying the error in a message box
            }
        }

        private void updateStopButtonn_Click(object sender, EventArgs e)
        {
            updateDataTimerr.Enabled = false;
        }

        private void updateDataTimerr_Tick(object sender, EventArgs e)
        {
            textBox11.Text = "";
            try
            {
                serialPort11.WriteLine("request_message");//sends a specific message to arduino
            }
            catch (Exception er)
            {
                //if an error is detected then the error message is displayed and timer gets disabled
                MessageBox.Show(er.Message);
                updateDataTimerr.Enabled = false;
            }
        }

        private void serialPort11_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string s;
            s = sp.ReadLine();
            SetTextOfTextBox22(s);
        }

        private void SetTextOfTextBox22(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.textBox22.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetTextOfTextBox22);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBox22.Text = text;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt16(Keys.Enter))
            {
                if (!serialPort11.IsOpen)
                {
                    serialPort11.Open();
                    label1.Text = "Estado: Conectado en el puerto " + serialPort11.PortName;

                }
                serialPort11.WriteLine(textBox11.Text);
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToInt16(Keys.Escape))
            {
                textBox11.Text = ""; e.Handled = true;
            }
        }
    }
}
