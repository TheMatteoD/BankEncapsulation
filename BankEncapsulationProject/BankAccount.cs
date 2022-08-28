﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationProject
{
    internal class BankAccount
    {
        private double balance = 0;

        public void Deposit(double amount)
        {
            balance += amount;
        }
        public double GetBalance()
        {
            return balance;
        }
    }
}
