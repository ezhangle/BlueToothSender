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


namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            int Baud = Int32.Parse(BaudRateCMB.SelectedItem.ToString());
            Parity parity = (Parity)Enum.Parse(typeof(Parity), ParityCMB.SelectedItem.ToString());
            int databit = Int32.Parse(DataBitsCMB.SelectedItem.ToString());
            StopBits stopbits = (StopBits)Enum.Parse(typeof(StopBits), StopBitsCMB.SelectedItem.ToString());

            SerialPort port = new SerialPort(ComPortTxt.Text.Trim(),Baud,parity,databit,stopbits);
            if (!port.IsOpen)
            {
                port.Open();
            }
            port.Write("-()- "+SubjectTxt.Text.Trim()+" "+DataTxt.Text.Trim()+ " -()-");
    
            port.Close();
        }

        void EnumToCombo(Type enumtyp, ComboBox box,int startindex)
        {
            foreach (var item in Enum.GetValues(enumtyp))
            {
                box.Items.Add(item);
            }
            box.SelectedIndex = startindex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BaudRateCMB.SelectedIndex = 6;
            EnumToCombo(typeof(Parity),ParityCMB,0);
            DataBitsCMB.SelectedIndex = 3;
            EnumToCombo(typeof(StopBits), StopBitsCMB,1);
        }
    }
}
