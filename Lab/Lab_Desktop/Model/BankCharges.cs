﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Desktop.Model
{
    internal class BankCharges
    {
        public static double balance = 0;

        private int checksCounter = 0;
        private int monthFee = 10;
        private int lowBalanceFee = 15;
        private int minBalance = 400;

        public BankCharges() { }
        public BankCharges(double newBalance, int checksCounter)
        {
            balance = newBalance;
            this.checksCounter = checksCounter;
        }

        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }

        public double getBalance()
        {
            return balance;
        }

        public void setChecksCounter(int checksCounter)
        {
            this.checksCounter = checksCounter;
        }

        /*
         * Method get a fee rate accordint to the check quantity
         */
        public double getCheckFeeRate()
        {
            double checkFeeRate = 0;

            if (checksCounter < 20)
            {
                checkFeeRate = 0.1;
            }
            else if (checksCounter >= 20 && checksCounter < 39)
            {
                checkFeeRate = 0.8;
            }
            else if (checksCounter >= 40 && checksCounter < 59)
            {
                checkFeeRate = 0.6;
            }
            else if (checksCounter > 60)
            {
                checkFeeRate = 0.1;
            }

            return checkFeeRate;
        }


        /**
         * Method calculate monthly fee and updates balance
         */
        public double getMonthServiceFee()
        {
            double monthServiceFee = monthFee;

            if (balance < minBalance)
            {
                monthServiceFee += lowBalanceFee;
            }

            monthServiceFee += getCheckFeeRate() * checksCounter;

            balance -= monthServiceFee;

            return monthServiceFee;
        }
    }


}
