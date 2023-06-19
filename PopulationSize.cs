using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab1_DesktopAppDev
{
    internal class PopulationSize
    {
        private int startSize;
        private int dailyIncreaze;
        private int numberDays;

        public PopulationSize() { }

        public void setStartSize(int startSize) 
        { 
            this.startSize = startSize; 
        }

        public int getStartSize()
        {
            return this.startSize;
        }

        public void setDailyIncreaze(int dailyIncreaze)
        {
            this.dailyIncreaze = dailyIncreaze;
        }

        public int getDailyIncreazee()
        {
            return this.dailyIncreaze;
        }

        public void setNumberDays(int numberDays)
        {
            this.numberDays = numberDays;
        }

        public int getNumberDays()
        {
            return this.numberDays;
        }

        public string showDailyPopulationSize()
        {
            string errMessage = "Error. \nPlease enter valid parameters:\n" +
                "Start size: more or equal 2\n" +
                "Average dayli increase: more or equal 2\n" +
                "Number of days: more or equal 1\n";

            int[] dailySizeInt = new int[numberDays];


            if (startSize < 2 || dailyIncreaze < 0 || numberDays < 1)
            {
                 MessageBox.Show(errMessage);
            }
               
            dailySizeInt[0] = startSize; // .....

            String result = "Day 1: " + dailySizeInt[0].ToString();

            for (int i = 1; i < numberDays; i++)
            {
                dailySizeInt[i] = (dailySizeInt[i - 1] + (dailySizeInt[i - 1] * dailyIncreaze/100));
                result += ",\nDay" + (i + 1) + ": " + dailySizeInt[i].ToString();
            }
            return result;
        }
    }
}
