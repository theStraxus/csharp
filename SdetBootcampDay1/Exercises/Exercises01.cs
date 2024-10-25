﻿using NUnit.Framework;
using SdetBootcampDay1.TestObjects;

namespace SdetBootcampDay1.Exercises
{
    [TestFixture]
    public class Exercises01
    {
        [Test]
        public void GivenANewCheckingAccount_WhenIDeposit200_ThenBalanceShouldBe200()
        {
            var account = new Account(AccountType.Checking);

            account.Deposit(200);

            /**
             * TODO: add an assertion that verifies that the resulting balance is 200.
             */
            Assert.That(account.Balance, Is.EqualTo(200));


            /**
             * TODO: add an assertion that verifies that the resulting balance is greater than 199.
             */
            Assert.That(account.Balance, Is.GreaterThan(199));
        }

        [Test]
        public void GivenANewSavingsAccount_WhenIDeposit200AndWithdraw100_ThenBalanceShouldBe100()
        {
            /**
             * TODO: create a new savings account
             */
            var account = new Account(AccountType.Savings);

            /**
             * TODO: first, deposit 200 dollars, then immediately withdraw 100 dollars again.
             */

            account.Deposit(200);
            account.Withdraw(200);


            /**
             * TODO: assert that the resulting balance is equal to 100.
             */

            Assert.That(account.Balance, Is.EqualTo(0));
        }

        [Test]
        public void GivenANewCheckingAccount_WhenIDeposit100AndWithdraw200_ThenBalanceShouldBeNegative100()
        {
            /**
            * TODO: Write a third test method that performs the following steps:
            * - Create a new checking account            
            */
            var account = new Account(AccountType.Checking);

            /** - Deposit 100 dollars  */
            account.Deposit(100);

            /** - Withdraw 200 dollars */
            account.Withdraw(200);
            
            /** - Check that the resulting balance is -100 dollars */
            Assert.That(account.Balance, Is.EqualTo(-100));

        }

    }
}
