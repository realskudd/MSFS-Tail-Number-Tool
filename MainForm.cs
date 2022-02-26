using FSUIPC;
using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MSFS_2020_Tail_Number_Fixer___FSUIPC
{
    public partial class MainForm : Form
    {
        Offset<short> msfsVersion = new Offset<short>(0x3308);
        Offset<string> tailNumber = new Offset<string>(0x313C, 12);
        Offset<string> aircraftModel = new Offset<string>(0x3D00, 256);

        private const int MSFS_2020_VERSION = 13;

        private bool isConnected = false;
        
        private Timer timer = new Timer() { Enabled = true, Interval = 1000 };

        public Dictionary<string, TailNumber> PastTailNumbers = new Dictionary<string, TailNumber>();

        private string HistoryFile
        {
            get
            {
                string historyFile = Environment.CurrentDirectory + "\\history.json";
                return historyFile;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            this.FormClosing += MainForm_FormClosing;
            HistoricList.SelectedIndexChanged += HistoricList_SelectedIndexChanged;
            HistoricList.DoubleClick += HistoricList_DoubleClick;
            this.LoadHistoricData();
        }

        private void LoadHistoricData()
        {
            if (!File.Exists(HistoryFile)) return;

            string json = File.ReadAllText(HistoryFile);

            foreach (TailNumber t in JsonConvert.DeserializeObject<List<TailNumber>>(json))
            {
                PastTailNumbers.Add(t.Registration, t);

                ListViewItem l = new ListViewItem(t.ToString()) { Tag = t.Registration };
                HistoricList.Items.Add(l);
            }
        }

        private void WriteHistoricData()
        {
            using(StreamWriter file = File.CreateText(HistoryFile))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, PastTailNumbers.Values);
            }
        }

        private void HistoricList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HistoricList.SelectedItems.Count == 0)
            {
                UseSelectedButton.Enabled = false;
            } else
            {
                UseSelectedButton.Enabled = true;
            }
        }

        private void HistoricList_DoubleClick(object sender, EventArgs e)
        {
            if (HistoricList.SelectedItems.Count == 1)
            {
                UseSelectedButton_Click(sender, e);
            }
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
            if (!isConnected) TryConnecting();  
            if (!isConnected) return;

            FSUIPCConnection.Process();

            if (NewTailNumber.Enabled == false && SetTailNumberButton.Enabled == false && msfsVersion.Value == MSFS_2020_VERSION)
            {
                NewTailNumber.Enabled = true;
                NewTailNumber.Focus();
                SetTailNumberButton.Enabled = true;
            }

            if (CurrentTailNumberLabel.Text != tailNumber.Value) CurrentTailNumberLabel.Text = tailNumber.Value;
            if (AircraftModelLabel.Text != aircraftModel.Value) AircraftModelLabel.Text = aircraftModel.Value;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NewTailNumber.Focus();
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

            tailNumber.Value = NewTailNumber.Text;
            NewTailNumber.Text = "";
            NewTailNumber.Focus();

            LazyAddHistoric(tailNumber.Value, aircraftModel.Value);

            WriteHistoricData();
        }

        private void LazyAddHistoric(string tailNumber, string aircraftModel)
        {
            bool itemFound = false;
            TailNumber t = new TailNumber(tailNumber, aircraftModel);

            foreach (ListViewItem i in HistoricList.Items)
            {
                if (i.Text == t.ToString())
                {
                    itemFound = true;
                    break;
                }
            }

            if (!itemFound)
            {
                PastTailNumbers.Add(t.Registration, t);

                ListViewItem i = new ListViewItem(t.ToString()) { Tag = tailNumber };
                HistoricList.Items.Add(i);
            }
        }

        private void UseSelectedButton_Click(object sender, EventArgs e)
        {

            TailNumber t = PastTailNumbers[HistoricList.SelectedItems[0].Tag.ToString()];

            NewTailNumber.Text = t.Registration;
            SetTailNumberButton_Click(sender, e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (HistoricList.SelectedItems.Count == 0) return;

            List<TailNumber> toDelete = new List<TailNumber>();

            foreach (ListViewItem l in HistoricList.SelectedItems)
            {
                toDelete.Add(PastTailNumbers[l.Tag.ToString()]);
            }

            DialogResult r = MessageBox.Show("Are you sure you want to remove the selected tail numbers?", "Confirmation Required", MessageBoxButtons.YesNo);

            if (r == DialogResult.No) return;

            foreach (TailNumber t in toDelete)
            {
                PastTailNumbers.Remove(t.Registration);
            }

            WriteHistoricData();
            HistoricList.Items.Clear();
            PastTailNumbers.Clear();
            LoadHistoricData();
        }
    }
}
