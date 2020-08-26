using System;
using UnitTesting;
using Xunit;

namespace Lab_02_401
{
    public class UnitTest1
    {
        [Fact]
        public void ViewBalance_displays_current_balance()
        {
            //Arange
            decimal balance = 100.00m;
            //Act
            decimal result = Program.ViewBalance(balance);
            //Assert
            decimal expected = balance;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Withdraw_subracts_number_from_balance()
        {
            //Arange
            decimal balance = 100.00m;
            decimal widthdraw = 25.00m;
            //Act
            decimal result = Program.Withdraw(balance, widthdraw);
            //Assert
            decimal expected = 75.00m;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Deposit_input_number_from_user_to_balance()
        {
            //Arange
            decimal balance = 100.00m;
            decimal deposit = 50.00m;
            //Act
            decimal result = Program.Deposit(balance, deposit);
            //Assert
            decimal expected = 150.00m;
            Assert.Equal(expected, result);
        }
    }
}
