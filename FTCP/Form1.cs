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
            
            serialPort1.PortName = cmbPort.SelectedItem.ToString();
    
            int baudrate; //make a variable to hold the baudrate. Initialized to zero.
            //Int32.TryParse tries to convert the string to an integer and store the value in baudrate. 
            //if it cant, it returns false, if it can it returns true. 
            //if the conversion fails, baudrate is unchanged, and the program doesn't crash like it would with Int32.Parse or Convert.ToInt32. 
            if (Int32.TryParse((string)cmbBaud.SelectedItem, out baudrate)) { 
                serialPort1.BaudRate = baudrate;
            }
            else {
                serialPort1.BaudRate = 0; //Default baudrate
            }
            
            serialPort1.DtrEnable = true;
            serialPort1.RtsEnable = true;

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
            //You don't need to use a selectedID here. You could set Cmd.ID directly with the value you want it to have. This goe's for all of the radiobutton Changed methods.
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
            /*Old Code
            Cmd.Red= Convert.ToByte(trackBarRed.Value);
            */
            //We can use simpler conversions between integer types. since trackBarRed.Value is an integer, and because we know that the value of trackBarRed.Value will never be less than 0,
            //we can "cast" (vocabulary word similar to convert) the value instead of using the more cumbersom Conver.ToByte method. This is true of all the trackBarXXX_Scroll methods.
            Cmd.Red = (byte)trackBarRed.Value;
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
            //Shouldn't need this now that ColorCommand is handling your sentence construction.
            // sentence compile here befor sending to serial
        }
        private void radioButtonON_CheckedChanged(object sender, EventArgs e)
        {
            //The same thing can be done with these radiosbuttons as can be done with the LED ID radiobuttons.
            //You don't need a SelectMode variable because Cmd.Mode is already a variable.
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
            serialPort1.Write(richTextBox1.Text); // sends sentence to serial
        }

        private void DisplayText(object sender, EventArgs e)
        {
            //textBox1.AppendText(RxString);
            richTextBox1.Text = RxString;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //There's an issue with this that you might not have thought about, and that's that ReadExisting reads ONLY what's in the buffer, and nothing else.
            //So if there's only 1 byte in the buffer, only that 1 byte is going to get set in RxString.
            RxString = serialPort1.ReadExisting();
            //Furthermore, this isn't exactly how you would normally want to write this kind of thing.
            //I'd suggest rewriting DisplayText to take a string, and then use this.Invoke(new Action<string>(DisplayText),RxString). 
            //That way you can actually get rid of the class variable RxString. 
            this.Invoke(new EventHandler(DisplayText));
        }

        private void cmbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            //I'm not sure, but I think you need this filled out.
        }

    }

}