using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace ThermalPlotter
{
    public partial class Form1 : Form, IObserver<double>
    {
        private ThermalData thermalData;
        private IDisposable unsubscriber;
        
        public Form1()
        {
            InitializeComponent();
            SetDefaultFileName();
            comboBox_Port.SelectedIndex = 0;
            formsPlot1.Plot.XAxis.Label("Elapsed Time [s]");
            formsPlot1.Plot.YAxis.Label("Temperature \u00b0C");

        }
        private void SetDefaultFileName()
        {
            String txt = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Td_" + DateTime.Now.ToString("yyyy-MM-ddTHH-mm-ss") + ".csv";
            text_FileName.Text = txt;
        }
        public virtual void Subscribe(IObservable<double> provider)
        {
            unsubscriber = provider.Subscribe(this);
        }
        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
        public virtual void OnCompleted()
        {
            Console.WriteLine("Additional temperature data will not be transmitted.");
        }

        public virtual void OnError(Exception error)
        {
            // Do nothing.
        }

        public virtual void OnNext(double value)
        {
            formsPlot1.Plot.Render();
            if (check_autoScaleX.Checked == true)
                formsPlot1.Plot.SetAxisLimitsX(0, thermalData.GetDataLength());
            if (check_autoScaleY.Checked == true)
                formsPlot1.Plot.SetAxisLimitsY( thermalData.GetDataMin(), thermalData.GetDataMax());
            formsPlot1.Invoke(new Action(() => { 
                formsPlot1.Refresh();
                label_T1.Text = thermalData.GetCurrentTemperature(0).ToString("0.##\u00b0C");
                label_T2.Text = thermalData.GetCurrentTemperature(1).ToString("0.##\u00b0C");
                label_T3.Text = thermalData.GetCurrentTemperature(2).ToString("0.##\u00b0C");
                label_T4.Text = thermalData.GetCurrentTemperature(3).ToString("0.##\u00b0C");
                
                button_maxT1.Text = thermalData.ch0_max.ToString("0.##\u00b0C");
                button_maxT2.Text = thermalData.ch1_max.ToString("0.##\u00b0C");
                button_maxT3.Text = thermalData.ch2_max.ToString("0.##\u00b0C");
                button_maxT4.Text = thermalData.ch3_max.ToString("0.##\u00b0C");

                button_minT1.Text = thermalData.ch0_min.ToString("0.##\u00b0C");
                button_minT2.Text = thermalData.ch1_min.ToString("0.##\u00b0C");
                button_minT3.Text = thermalData.ch2_min.ToString("0.##\u00b0C");
                button_minT4.Text = thermalData.ch3_min.ToString("0.##\u00b0C");
                if (thermalData.isRecording == true)
                    label_recordingMode.Text = "Recording";
                else
                    label_recordingMode.Text = "Idle";
                if (thermalData.isBatteryLow == true)
                    label_batteryStatus.Text = "Low Battery";
                else
                    label_batteryStatus.Text = "Ok";

                label_Elapsed.Text = thermalData.GetCurrentElapsedTime();
            }));
            
        }
        
        public void SetDataToPlot(ThermalData tD)
        {
            thermalData = tD;
            formsPlot1.Plot.AddSignal(thermalData.GetChannelData(0));
            formsPlot1.Plot.AddSignal(thermalData.GetChannelData(1));
            formsPlot1.Plot.AddSignal(thermalData.GetChannelData(2));
            formsPlot1.Plot.AddSignal(thermalData.GetChannelData(3));
            formsPlot1.Plot.Render();
            formsPlot1.Refresh();
        }

        public void UpdatePlot()
        {
            formsPlot1.Plot.Render();
            formsPlot1.Invoke(new Action(() => { formsPlot1.Refresh(); }));
        }

        private void OnComPortChange(object sender, EventArgs e)
        {
            Console.WriteLine("Port Change");
            Program.SetSerialPort();             
        }

        private void OnButtonReset(object sender, EventArgs e)
        {
            thermalData.ResetAllData();
            SetDefaultFileName();
        }

        private void OnExport(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string text = text_FileName.Text;
            int pos = text.LastIndexOf("\\");
            saveFileDialog1.FileName = text.Substring((pos+1), text.Length - (pos+1));
            saveFileDialog1.InitialDirectory = text.Substring(0, pos);
            DialogResult saveresult = saveFileDialog1.ShowDialog();
            if (saveresult == DialogResult.OK)
            {
                try
                {
                    String path = saveFileDialog1.FileName;
                    StreamWriter sw = new StreamWriter(path);
                    for(int i = 0; i < thermalData.GetDataLength(); i++)
                    sw.WriteLine(thermalData.GetCSVFormattedStringForIndex(i));
                    sw.Close();


                }
                catch (Exception error)
                {
                    MessageBox.Show("oops");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_maxT1_Click(object sender, EventArgs e)
        {
            thermalData.ch0_max = 0;
        }

        private void button_minT1_Click(object sender, EventArgs e)
        {
            thermalData.ch0_min = 0;
        }

        private void button_maxT2_Click(object sender, EventArgs e)
        {
            thermalData.ch1_max = 0;
        }

        private void button_minT2_Click(object sender, EventArgs e)
        {
            thermalData.ch1_min = 0;
        }

        private void button_maxT3_Click(object sender, EventArgs e)
        {
            thermalData.ch2_max = 0;
        }

        private void button_minT3_Click(object sender, EventArgs e)
        {
            thermalData.ch2_min = 0;
        }

        private void button_maxT4_Click(object sender, EventArgs e)
        {
            thermalData.ch3_max = 0;
        }

        private void button_minT4_Click(object sender, EventArgs e)
        {
            thermalData.ch3_min = 0;
        }

        private void check_startStop_CheckedChanged(object sender, EventArgs e)
        {
            thermalData.SetPaused(check_startStop.Checked);
            if (check_startStop.Checked)
            {
                Console.WriteLine("Now Paused - checked");
                check_startStop.Text = "Play";
            }
            else
            {
                check_startStop.Text = "Pause";
                Console.WriteLine("Now Running");
            }
        }
    }
}
