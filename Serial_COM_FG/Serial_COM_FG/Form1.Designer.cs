namespace serial_communication
{
    partial class serial_connection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scanButtonn = new System.Windows.Forms.Button();
            this.connectButtonn = new System.Windows.Forms.Button();
            this.updateStartButtonn = new System.Windows.Forms.Button();
            this.updateStopButtonn = new System.Windows.Forms.Button();
            this.disconnectButtonn = new System.Windows.Forms.Button();
            this.updateNowButtonn = new System.Windows.Forms.Button();
            this.portComboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.serialPort11 = new System.IO.Ports.SerialPort(this.components);
            this.updateDataTimerr = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scanButtonn
            // 
            this.scanButtonn.Location = new System.Drawing.Point(100, 30);
            this.scanButtonn.Margin = new System.Windows.Forms.Padding(2);
            this.scanButtonn.Name = "scanButtonn";
            this.scanButtonn.Size = new System.Drawing.Size(76, 33);
            this.scanButtonn.TabIndex = 0;
            this.scanButtonn.Text = "scan";
            this.scanButtonn.UseVisualStyleBackColor = true;
            this.scanButtonn.Click += new System.EventHandler(this.scanButtonn_Click);
            // 
            // connectButtonn
            // 
            this.connectButtonn.Location = new System.Drawing.Point(8, 33);
            this.connectButtonn.Margin = new System.Windows.Forms.Padding(2);
            this.connectButtonn.Name = "connectButtonn";
            this.connectButtonn.Size = new System.Drawing.Size(76, 33);
            this.connectButtonn.TabIndex = 1;
            this.connectButtonn.Text = "Conectar";
            this.connectButtonn.UseVisualStyleBackColor = true;
            this.connectButtonn.Click += new System.EventHandler(this.connectButtonn_Click);
            // 
            // updateStartButtonn
            // 
            this.updateStartButtonn.Location = new System.Drawing.Point(181, 30);
            this.updateStartButtonn.Margin = new System.Windows.Forms.Padding(2);
            this.updateStartButtonn.Name = "updateStartButtonn";
            this.updateStartButtonn.Size = new System.Drawing.Size(76, 33);
            this.updateStartButtonn.TabIndex = 2;
            this.updateStartButtonn.Text = "update start";
            this.updateStartButtonn.UseVisualStyleBackColor = true;
            this.updateStartButtonn.Click += new System.EventHandler(this.updateStartButtonn_Click);
            // 
            // updateStopButtonn
            // 
            this.updateStopButtonn.Location = new System.Drawing.Point(181, 67);
            this.updateStopButtonn.Margin = new System.Windows.Forms.Padding(2);
            this.updateStopButtonn.Name = "updateStopButtonn";
            this.updateStopButtonn.Size = new System.Drawing.Size(76, 33);
            this.updateStopButtonn.TabIndex = 3;
            this.updateStopButtonn.Text = "update stop";
            this.updateStopButtonn.UseVisualStyleBackColor = true;
            this.updateStopButtonn.Click += new System.EventHandler(this.updateStopButtonn_Click);
            // 
            // disconnectButtonn
            // 
            this.disconnectButtonn.Location = new System.Drawing.Point(8, 70);
            this.disconnectButtonn.Margin = new System.Windows.Forms.Padding(2);
            this.disconnectButtonn.Name = "disconnectButtonn";
            this.disconnectButtonn.Size = new System.Drawing.Size(76, 33);
            this.disconnectButtonn.TabIndex = 4;
            this.disconnectButtonn.Text = "Desconectar";
            this.disconnectButtonn.UseVisualStyleBackColor = true;
            this.disconnectButtonn.Click += new System.EventHandler(this.disconnectButtonn_Click);
            // 
            // updateNowButtonn
            // 
            this.updateNowButtonn.Location = new System.Drawing.Point(100, 67);
            this.updateNowButtonn.Margin = new System.Windows.Forms.Padding(2);
            this.updateNowButtonn.Name = "updateNowButtonn";
            this.updateNowButtonn.Size = new System.Drawing.Size(76, 33);
            this.updateNowButtonn.TabIndex = 5;
            this.updateNowButtonn.Text = "Enviar";
            this.updateNowButtonn.UseVisualStyleBackColor = true;
            this.updateNowButtonn.Click += new System.EventHandler(this.updateNowButtonn_Click);
            // 
            // portComboBox1
            // 
            this.portComboBox1.FormattingEnabled = true;
            this.portComboBox1.Location = new System.Drawing.Point(8, 8);
            this.portComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.portComboBox1.Name = "portComboBox1";
            this.portComboBox1.Size = new System.Drawing.Size(77, 21);
            this.portComboBox1.TabIndex = 6;
            this.portComboBox1.SelectedIndexChanged += new System.EventHandler(this.portComboBox1_SelectedIndexChanged);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(100, 9);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(157, 20);
            this.textBox11.TabIndex = 7;
            this.textBox11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox11_KeyPress);
            // 
            // serialPort11
            // 
            this.serialPort11.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort11_DataReceived);
            // 
            // updateDataTimerr
            // 
            this.updateDataTimerr.Tick += new System.EventHandler(this.updateDataTimerr_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 105);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Data from Arduino";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(8, 120);
            this.textBox22.Margin = new System.Windows.Forms.Padding(2);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(249, 20);
            this.textBox22.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Estado";
            // 
            // serial_connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 164);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.portComboBox1);
            this.Controls.Add(this.updateNowButtonn);
            this.Controls.Add(this.disconnectButtonn);
            this.Controls.Add(this.updateStopButtonn);
            this.Controls.Add(this.updateStartButtonn);
            this.Controls.Add(this.connectButtonn);
            this.Controls.Add(this.scanButtonn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "serial_connection";
            this.Text = "Francis_Serial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scanButtonn;
        private System.Windows.Forms.Button connectButtonn;
        private System.Windows.Forms.Button updateStartButtonn;
        private System.Windows.Forms.Button updateStopButtonn;
        private System.Windows.Forms.Button disconnectButtonn;
        private System.Windows.Forms.Button updateNowButtonn;
        private System.Windows.Forms.ComboBox portComboBox1;
        private System.Windows.Forms.TextBox textBox11;
        private System.IO.Ports.SerialPort serialPort11;
        private System.Windows.Forms.Timer updateDataTimerr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label1;
    }
}

