using FSUIPC;
using System;
using System.Windows.Forms;

namespace MSFS_2020_Tail_Number_Fixer___FSUIPC
{
    public partial class MainForm : Form
    {
        Offset<short> msfsVersion = new Offset<short>(0x3308);
        Offset<string> tailNumber = new Offset<string>(0x313C, 12);

        private const int MSFS_2020_VERSION = 13;

        private bool isConnected = false;
        
        private Timer timer = new Timer() { Enabled = true, Interval = 1000 };

        public MainForm()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            this.FormClosing += MainForm_FormClosing;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isConnected)
            {
                try
                {
                    FSUIPCConnection.Close();
                } catch (FSUIPCException ex) { }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            bool nowConnected = false;
            
            if (!isConnected) TryConnecting();  

            if (!isConnected) return;

            FSUIPCConnection.Process();

            if (newTailNumber.Enabled == false && SetTailNumberButton.Enabled == false && msfsVersion.Value == MSFS_2020_VERSION)
            {
                newTailNumber.Enabled = true;
                newTailNumber.Focus();
                SetTailNumberButton.Enabled = true;
            }

            if (CurrentTailNumber.Text != tailNumber.Value) CurrentTailNumber.Text = tailNumber.Value;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            newTailNumber.Focus();
        }

        private bool TryConnecting()
        {
            if (isConnected) return true;

            bool result = false;
            try
            {
                FSUIPCConnection.Open();
                result = true;
            } catch(FSUIPCException ex)
            {
                if (ex.FSUIPCErrorCode == FSUIPCError.FSUIPC_ERR_NOFS) return result;
                if (ex.FSUIPCErrorCode == FSUIPCError.FSUIPC_ERR_NOTOPEN) return result;

                Console.Error.WriteLine($"FSUIPC Error Code {ex.FSUIPCErrorCode}: {ex.Message}");
            }

            isConnected = result;
            return result;
        }

        private void SetTailNumberButton_Click(object sender, EventArgs e)
        {
            if (!isConnected) return;

            tailNumber.Value = newTailNumber.Text;
            newTailNumber.Text = "";
            newTailNumber.Focus();
        }
    }
}
