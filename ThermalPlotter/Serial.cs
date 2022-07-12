using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;
using System.Timers;

namespace ThermalPlotter
{
    internal class Serial : IObservable<double>
    {
        static SerialPort serialPort;
        static ThermalData thermalData;
        static List<IObserver<double>> observers;
        public Serial(ThermalData tD)
        {
            observers = new List<IObserver<double>>();
            
            thermalData = tD;
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(PollDevice);
            aTimer.Interval = 1000;
            aTimer.Enabled = true;

        }
        private class Unsubscriber : IDisposable
        {
            private List<IObserver<double>> _observers;
            private IObserver<double> _observer;

            public Unsubscriber(List<IObserver<double>> observers, IObserver<double> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (!(_observer == null)) _observers.Remove(_observer);
            }
        }
        public IDisposable Subscribe(IObserver<double> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);

            return new Unsubscriber(observers, observer);
        }

        public static void PollDevice(object source, ElapsedEventArgs e)
        {
            if(serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    Console.WriteLine("Polling");
                    serialPort.Write("A");
                }
            }
        }

        public void OpenSerialPort(string str)
        {
            Console.WriteLine("Opening Serial Port.");
            if (serialPort != null)
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    Console.WriteLine("Existing Serial Port Closed.");
                }
            }

            serialPort = new SerialPort(str, 9600);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPortRx);
            try
            {
                serialPort.Open();
                serialPort.DiscardInBuffer();
                serialPort.DiscardOutBuffer();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
            Console.WriteLine("Port Open");
        }
        public static void serialPortRx(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                while (serialPort.BytesToRead > 48)
                {
                    int count = serialPort.BytesToRead;
                    if (serialPort.ReadByte() == 0x02)
                    {
                        byte[] bBuffer = new byte[48];
                        for (int i = 0; i < 44; i++)
                        {
                            bBuffer[i] = (byte)serialPort.ReadByte();
                        }
                        Console.Write(BitConverter.ToString(bBuffer));
                        double t1 = ((double)((bBuffer[6] * 255) + bBuffer[7])) / 10.0;
                        if (t1 > 3000)
                            t1 = 0;
                        double t2 = ((double)((bBuffer[8] * 255) + bBuffer[9])) / 10.0;
                        if (t2 > 3000)
                            t2 = 0;
                        double t3 = ((double)((bBuffer[10] * 255) + bBuffer[11])) / 10.0;
                        if (t3 > 3000)
                            t3 = 0;
                        double t4 = ((double)((bBuffer[12] * 255) + bBuffer[13])) / 10.0;
                        if (t4 > 3000)
                            t4 = 0;
                        Console.WriteLine(count);
                        thermalData.AppendData(t1, t2, t3, t4);
                        foreach (var observer in observers)
                            observer.OnNext(11.2);
                    } 
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
