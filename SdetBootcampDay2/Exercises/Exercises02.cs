﻿using Moq;
using NUnit.Framework;
using SdetBootcampDay2.TestObjects.Answers;

namespace SdetBootcampDay2.Exercises
{
    [TestFixture]
    public class Exercises02
    {
        [Test]
        public void MockPaymentProcessor_ReturnFalseForAllStripePayments()
        {
            Dictionary<OrderItem, int> stock = new Dictionary<OrderItem, int>
            {
                { OrderItem.FIFA_24, 10 }
            };

            /**
             * TODO: Create a mock object representing the payment processor. Pass in Stripe
             * as the payment processor type. Set up the mock so that a call to PayFor() with
             * FIFA 24 and 10 as arguments returns false.
             */
            var paymentProcessor = new Mock<PaymentProcessor>(PaymentProcessorType.Stripe);

            paymentProcessor.Setup(o => o.PayFor(OrderItem.FIFA_24, 10)).Returns(false);
            
            /**
             * TODO: Complete the test by creating a new OrderHandler, passing in the mock object
             * for the payment processor. Call the Order() method and then assert that the PayFor()
             * method of the OrderHandler returns false
             */

            var orderHandler = new OrderHandler(stock, paymentProcessor.Object);

            orderHandler.Order(OrderItem.FIFA_24, 10);

            Assert.That(orderHandler.PayFor(OrderItem.FIFA_24,10), Is.False);


            /**
             * TODO: verify that the PayFor() method of the mock payment processor was called
             * exactly once with FIFA_24 and 10 as parameters.
             */
            
            paymentProcessor.Verify(p => p.PayFor(OrderItem.FIFA_24,10), Times.Exactly(1));

        }
    }
}
