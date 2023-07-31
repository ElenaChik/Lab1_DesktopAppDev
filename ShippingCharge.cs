using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Lab1_DesktopAppDev
{
    internal class ShippingCharge
    {
        private double weight;
        private double distance;

        public ShippingCharge() { }

        public ShippingCharge(double weight, double distance) 
        {
            this.weight = weight;
            this.distance = distance;
        }

        public void setWeight(double weight) 
        {
            this.weight = weight;
        }

        public double getWeight()
        {
            return this.weight;
        }

        public void setDistance(double distance)
        {
            this.distance = distance;
        }

        public double getDistance()
        {
            return this.distance;
        }


        /*
         *  Method calculates shipping charge
         */
        public double calcCharge()
        {
            double weightR = calcWeightRate();
            double distanceRate = calcDistanceRate();
            double charge = weightR * distanceRate;

            return charge;
        }

        private double calcWeightRate()
        {
            double weightRate = 0;

            if (this.weight <= 2)
            {
                weightRate = 1.10;
            }else if (this.weight <= 6)
            {
                weightRate = 2.20;
            }
            else if (this.weight <= 10)
            {
                weightRate = 3.70;
            }
            else if (this.weight > 10)
            {
                weightRate = 4.80;
            }
            return weightRate;
        }


        /*
         * Method calculate distance rate
         */
        private double calcDistanceRate()
        {
            double distanceRate = 0;
            if (this.distance % 500 != 0)
            {
                distanceRate = (this.distance / 500) + 1;
            }
            else
            {
                distanceRate = this.distance / 500;
            }

            return distanceRate;
        }
    }
}
