using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void Mcd(int x, int y)
        {
            if (y == 0) {
                label_mcd.Text = x.ToString();
            }
            else {
                Mcd(y, x % y);
            }
        }
        private void Mcm(int a, int b)
        {
            int x, z, y = 1, i = 2;

            if (a == 0 || b == 0) { y = 0; label_mcm.Text = y.ToString(); }

            if (a < b)
            {
                x = a;
                z = b;
            }
            else
            {
                x = b;
                z = a;
            }
            do {
                if (x % i == 0)
                {
                    if (z % i == 0)
                    {
                        y = y * i;
                        x = x / i; z = z / i; i = 2;
                    }
                    else i++;
                }
                else i++;
            } while (i <= x);

            y = y * z * x;

            label_mcm.Text = y.ToString();
        }
        private bool ComprobarValores() {

            bool rstado = false;
            int number1 = 0;
            int number2 = 0;
            String numString1 = textBox1.Text.ToString();
            String numString2 = textBox2.Text.ToString();
            bool canConvert1 = Int32.TryParse(numString1, out number1);
            bool canConvert2 = Int32.TryParse(numString2, out number2);            

            if (canConvert1 == true && canConvert2 == true)
                rstado = true;

        return rstado;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool result = ComprobarValores();
            if (result)        
            {
                Mcd(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                Mcm(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            }
            else
            {
                MessageBox.Show("No es un NUMERO");                
            }           
        }       
        private void button1_KeyPress_1(object sender, KeyPressEventArgs e)
        {            
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    e.Handled = true;   //eliminar el sonido al presionar la tecla
                    Mcd(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                    Mcm(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                }
                else if (e.KeyChar == Convert.ToChar(Keys.Escape) || e.KeyChar == Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                    //limpiar textBox
                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    textBox1.Focus();
                    textBox1.Select(textBox1.Text.Length, 0);
                    this.label_mcd.Text = "-";
                    this.label_mcm.Text = "-";
                }
                else
                {
                    //lo que haria en otro caso
                }            
        }    
    }
}
