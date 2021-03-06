using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace ThermalPlotter
{
    public partial class ThermalData
    {
        const int TEMP_ARRAY_SIZE = 10000;
        private double[] channel0 = new double[TEMP_ARRAY_SIZE];
        private double[] channel1 = new double[TEMP_ARRAY_SIZE];
        private double[] channel2 = new double[TEMP_ARRAY_SIZE];
        private double[] channel3 = new double[TEMP_ARRAY_SIZE];
        public double ch0_min, ch0_max;
        public double ch1_min, ch1_max;
        public double ch2_min, ch2_max;
        public double ch3_min, ch3_max;
        private double[] lastTemperature = new double[4];
        private DateTime[] dateTime = new DateTime[TEMP_ARRAY_SIZE];
        private bool isPaused = false;
        public bool isRecording = false;
        public bool isBatteryLow = false;
        int index;
        double min;
        double max;

        public ThermalData()
        {
        }

        public void AppendData(double ch1, double ch2, double ch3, double ch4)
        {
            if (isPaused)
                return;
            if (index == channel0.Length) 
            {
                // todo this doesn't work Resize returns a different reference
                Array.Resize(ref channel0, index + TEMP_ARRAY_SIZE);
                Array.Resize(ref channel1, index + TEMP_ARRAY_SIZE);
                Array.Resize(ref channel2, index + TEMP_ARRAY_SIZE);
                Array.Resize(ref channel3, index + TEMP_ARRAY_SIZE);
                Array.Resize(ref dateTime, index + TEMP_ARRAY_SIZE);
                Console.WriteLine(string.Format("Resize! index:{0} length:{1}", index, channel0.Length));
            }
            channel0[index] = ch1;
            channel1[index] = ch2;
            channel2[index] = ch3;
            channel3[index] = ch4;
            dateTime[index] = DateTime.Now;
            Console.WriteLine(DateTime.Now.ToString());
            lastTemperature[0] = ch1;
            lastTemperature[1] = ch2;
            lastTemperature[2] = ch3;
            lastTemperature[3] = ch4;
            if(ch1 > ch0_max || index == 0)
                ch0_max = ch1;
            if (ch2 > ch1_max || index == 0)
                ch1_max = ch2;
            if (ch3 > ch2_max || index == 0)
                ch2_max = ch3;
            if (ch4 > ch3_max || index == 0)
                ch3_max = ch4;

            if (ch1 < ch0_min || index == 0)
                ch0_min = ch1;
            if (ch2 < ch1_min || index == 0)
                ch1_min = ch2;
            if (ch3 < ch2_min || index == 0)
                ch2_min = ch3;
            if (ch4 < ch3_min || index == 0)
                ch3_min = ch4;

            index++;
        }

        public void SetToolState(byte state)
        {
            if((state & 0x01) == 0x01)
                isRecording = true;
            else
                isRecording = false;

            if ((state & 0x40) == 0x40)
                isBatteryLow = true;
            else
                isBatteryLow = false;
        }

        public double[] GetChannelData(int channel)
        {
            if(channel == 0)
                return channel0;
            if (channel == 1)
                return channel1;
            if (channel == 2)
                return channel2;
            return channel3;
   
        }

        public int GetDataLength()
        {
            return index;
        }
        public double GetCurrentTemperature(int channel)
        {
            return lastTemperature[channel];
        }
        public string GetCurrentElapsedTime()
        {
            string elapsedTime = "0:00";
            if (index == 0)
                return elapsedTime;
            TimeSpan t = TimeSpan.FromSeconds((dateTime[index - 1] - dateTime[0]).TotalSeconds);
            elapsedTime = string.Format("{0:D2}:{1:D2}:{2:D2}",t.Hours,t.Minutes,t.Seconds);
            return elapsedTime;
        }
        public string GetCSVFormattedStringForIndex(int idx)
        {
            string str = dateTime[idx].ToString("MM/dd/yyyy HH:mm:ss");
            str += String.Format(",{0}", channel0[idx]);
            str += String.Format(",{0}", channel1[idx]);
            str += String.Format(",{0}", channel2[idx]);
            str += String.Format(",{0}", channel3[idx]);
            return str;
        }
        public void ResetAllData()
        {
            index = 0;
            for (int i = 0; i < channel0.Length; i++)
            {
                channel0[i] = 0;
                channel1[i] = 0;
                channel2[i] = 0;
                channel3[i] = 0;
                ch0_min = 0; ch0_max = 0;
                ch1_min = 0; ch1_max = 0;
                ch2_min = 0; ch2_max = 0;
                ch3_min = 0; ch3_max = 0;
            }
        }
        public double GetDataMax()
        {
            double maximum = channel0.Max();
            if(channel1.Max() > maximum)
                maximum = channel1.Max();
            if(channel2.Max() > maximum)
                maximum= channel2.Max();
            if (channel3.Max() > maximum)
                maximum = channel3.Max();
            return maximum;

        }
        public double GetDataMin()
        {
            double minimum = channel0.Min();
            if (channel1.Min() < minimum)
                minimum = channel1.Min();
            if (channel2.Min() < minimum)
                minimum = channel2.Min();
            if (channel3.Min() < minimum)
                minimum = channel3.Min();
            return minimum;

        }
        public void SetPaused(bool state)
        {
            isPaused = state;
        }
    }      
}
