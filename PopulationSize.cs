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
        private int dailyIncrease;
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

        public void setDailyIncrease(int dailyIncreaze)
        {
            this.dailyIncrease = dailyIncreaze;
        }

        public int getDailyIncrease()
        {
            return this.dailyIncrease;
        }

        public void setNumberDays(int numberDays)
        {
            this.numberDays = numberDays;
        }

        public int getNumberDays()
        {
            return this.numberDays;
        }

        /*
         * Method returns a string of population size for each day
         */
        public string showDailyPopulationSize()
        {
            string errMessage = "Error. \nPlease enter valid parameters:\n" +
                "Start size: more or equal 2\n" +
                "Average dayli increase: more or equal 2\n" +
                "Number of days: more or equal 1\n";

            double[] dailySizeInt = new double[numberDays];


            if (startSize < 2 || dailyIncrease < 0 || numberDays < 1)
            {
                 MessageBox.Show(errMessage);
            }
               
            dailySizeInt[0] = startSize; // .....

            String result = "Day 1: " + dailySizeInt[0].ToString();

            for (int i = 1; i < numberDays; i++)
            {
                // i - is today's day
                dailySizeInt[i] = nextDaySize(dailySizeInt[i - 1]); 
                result += ",\nDay" + (i + 1) + ": " + dailySizeInt[i].ToString();
            }
            return result;
        }


        /*
         * Method returns the size of the population of next day
         */
        public double nextDaySize(double previousDaySize)
        {
            double nextDaySize = 0;
            nextDaySize = (previousDaySize + (previousDaySize * dailyIncrease / 100));

            return nextDaySize;
        }
    }
}
