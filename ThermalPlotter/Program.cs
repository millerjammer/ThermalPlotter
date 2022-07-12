using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.Timers;

namespace ThermalPlotter
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        private static Form1 thermalPlotWindow;
        private static ThermalData thermalData;
        static Serial serialPort;
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            thermalData = new ThermalData();
            serialPort = new Serial(thermalData);
            thermalPlotWindow = new Form1();
            thermalPlotWindow.SetDataToPlot(thermalData);
            thermalPlotWindow.Subscribe(serialPort);
            Application.Run(thermalPlotWindow);
        }

        public static void SetSerialPort()
        {
            if (serialPort != null && thermalPlotWindow != null) 
            { 
                string str = thermalPlotWindow.comboBox_Port.Text;
                serialPort.OpenSerialPort(str);
            }
        }
    }
}
