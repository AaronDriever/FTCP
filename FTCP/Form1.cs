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

    
        private void radioButtonAll_CheckedChanged(object sender,EventArgs e)
        {
            //starts text string with "-1" to set all leds
            sbyte SelectedID=-1;
            //Find out which ID has been selected.
            Cmd.ID = SelectedID;
            richTextBox1.Text = Cmd.ToString();
        }
        private void radioButtonLED1_CheckedChanged(object sender, EventArgs e)
        {
            //starts text string with "1" to set all leds
            sbyte SelectedID = 1;
            //Find out which ID has been selected.
            Cmd.ID = SelectedID;
            richTextBox1.Text = Cmd.ToString();
        }

        private void radioButtonLED2_CheckedChanged(object sender, EventArgs e)
        {
            //starts text string with "2" to set all leds
            sbyte SelectedID = 2;
            //Find out which ID has been selected.
            Cmd.ID = SelectedID;
            richTextBox1.Text = Cmd.ToString();
        }

        private void radioButtonLED3_CheckedChanged(object sender, EventArgs e)
        {
            //starts text string with "3" to set all leds
            sbyte SelectedID = 3;
            //Find out which ID has been selected.
            Cmd.ID = SelectedID;
            richTextBox1.Text = Cmd.ToString();
        }

        private void radioButtonLED4_CheckedChanged(object sender, EventArgs e)
        {
            //starts text string with "4" to set all leds
            sbyte SelectedID = 4;
            //Find out which ID has been selected.
            Cmd.ID = SelectedID;
            richTextBox1.Text = Cmd.ToString();
        }

        private void radioButtonLED5_CheckedChanged(object sender, EventArgs e)
        {
            //starts text string with "5" to set all leds
            sbyte SelectedID = 5;
            //Find out which ID has been selected.
            Cmd.ID = SelectedID;
            richTextBox1.Text = Cmd.ToString();
        }

        private void radioButtonLED6_CheckedChanged(object sender, EventArgs e)
        {
            //starts text string with "6" to set all leds
            sbyte SelectedID = 6;
            //Find out which ID has been selected.
            Cmd.ID = SelectedID;
            richTextBox1.Text = Cmd.ToString();
        }

        private void radioButtonLED7_CheckedChanged(object sender, EventArgs e)
        {
            //starts text string with "7" to set all leds
            sbyte SelectedID = 7;
            //Find out which ID has been selected.
            Cmd.ID = SelectedID;
            richTextBox1.Text = Cmd.ToString();
        }

        private void radioButtonLED8_CheckedChanged(object sender, EventArgs e)
        {
            //starts text string with "8" to set all leds
            sbyte SelectedID = 8;
            //Find out which ID has been selected.
            Cmd.ID = SelectedID;
            richTextBox1.Text = Cmd.ToString();
        }
        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
  
            Cmd.Red= Convert.ToByte(trackBarRed.Value);           
            richTextBox1.Text = Cmd.ToString();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            Cmd.Green = Convert.ToByte(trackBarGreen.Value);
            richTextBox1.Text = Cmd.ToString();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            Cmd.Blue = Convert.ToByte(trackBarBlue.Value);
            richTextBox1.Text = Cmd.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // sentence compile here befor sending to serial
        }
        private void radioButtonON_CheckedChanged(object sender, EventArgs e)
        {
            //starts text string with "-1" to set all leds
            byte SelectedMode = 1;
            //Find out which ID has been selected.
            Cmd.Mode = SelectedMode;
            richTextBox1.Text = Cmd.ToString();            
        }

        private void radioButtonOFF_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "blank";
        }

        private void SendButton(object sender, EventArgs e)
        {
             
            //serialPort1.Write(richTextBox1.Text); // sends sentence to serial
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine(richTextBox1.Text);

            }
        }

        private void DisplayText(object sender, EventArgs e)
        {
            //textBox1.AppendText(RxString);
            //richTextBox1.Text = RxString;
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