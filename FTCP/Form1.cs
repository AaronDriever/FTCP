using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace FTCP
{
    public class ColorCommand
    {
        const string COMMAND_PREFIX = "rgb";
        public byte Red;
        public byte Green;
        public byte Blue;
        public byte Mode;
        public sbyte ID;
        public override string ToString()
        {
            return COMMAND_PREFIX + " " + ID.ToString() + " " + Red.ToString() + " " + Green.ToString() + " " + Blue.ToString() + " " + Mode.ToString();
        }

    }
    public partial class Form1 : Form
    {
        ColorCommand Cmd;
        string RxString;
        byte[] data = new byte[1];

        public Form1()
        {
            Cmd = new ColorCommand();
            InitializeComponent();
            foreach (string serialName in SerialPort.GetPortNames())
            {
                cmbPort.Items.Add(serialName);
            }
            //Put all the Possible Baud rates into the combo box for selection.
            cmbBaud.Items.Add("1200");
            cmbBaud.Items.Add("2400");
            cmbBaud.Items.Add("4800");
            cmbBaud.Items.Add("9600");
            cmbBaud.Items.Add("19200");
            cmbBaud.Items.Add("38400");
            cmbBaud.Items.Add("57600");
            cmbBaud.Items.Add("115200");
            cmbBaud.Items.Add("230400");
            cmbBaud.SelectedIndex = 7;
        }

        private void buttonStart_Click_1(object sender, EventArgs e)
        {
            SerialPort serialport1 = new SerialPort();
            serialPort1.PortName = cmbPort.SelectedItem.ToString();
            serialPort1.BaudRate = Convert.ToInt32(cmbBaud.SelectedItem);

            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
                richTextBox1.ReadOnly = false;
            }
        }

        private void buttonStop_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                buttonStart.Enabled = true;
                buttonStop.Enabled = false;
                richTextBox1.ReadOnly = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

    
        private void radioButton1_CheckedChanged(object sender,EventArgs e)
        {
            //starts text string with "-1" to set all leds
            sbyte SelectedID=0;
            //Find out which ID has been selected.
            Cmd.ID = SelectedID;
            richTextBox1.Text = Cmd.ToString();
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
  
            Cmd.Red= Convert.ToByte(trackBarRed.Value);

            //serialPort1.Write(data, 0, 1);
            textBox2.Text = Cmd.ToString();
        }

        private void buttonSetRed_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = textBox2.Text;
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            byte pwm;
            pwm = Convert.ToByte(trackBarGreen.Value);
            data[0] = pwm;
            // serialPort1.Write(data, 0, 1);
            textBox2.Text = Convert.ToString(pwm);
        }

        private void buttonSetGreen_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = textBox2.Text;
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            byte pwm;
            pwm = Convert.ToByte(trackBarBlue.Value);
            data[0] = pwm;
            //serialPort1.Write(data, 0, 1);
            textBox2.Text = Convert.ToString(pwm);
        }

        private void buttonSetBlue_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = textBox2.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // sentence compile here befor sending to serial
        }
        private void radioButtonON_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "rgb -1 250 250 250 1";
        }

        private void radioButtonOFF_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "blank";
        }

        private void SendButton(object sender, EventArgs e)
        {
            serialPort1.Write(richTextBox1.Text); // sends sentence to serial
        }

        private void DisplayText(object sender, EventArgs e)
        {
            //textBox1.AppendText(RxString);
            richTextBox1.Text = RxString;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
        }

        private void cmbPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }






    }

}