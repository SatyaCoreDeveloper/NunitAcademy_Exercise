using System;
using NUnit.Framework;
using NunitAcademy.Core.Fundamentals;

namespace NunitAcademy.Core.UnitTest.Fundamentals.Tests
{
    [TestFixture]
    public class ReservationTests
    {

        [Test]
        public void CanBeCancelled_AdminUser_ExpectedTrue()
        {
            //Assign            
            var reservation = new Reservation(new User());
            var adminUser = new User()
            {
                IsAdmin = true
            };
            //Act
            var result = reservation.CanbeCancelled(adminUser);
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelled_ReservedByUser_ExpectedTrue()
        {
            //Assign
            var resUser = new User()
            {
                IsAdmin = false
            };
            var reservation = new Reservation(resUser);

            //Act
            var result = reservation.CanbeCancelled(resUser);
            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelled_NewUser_ExpectedFalse()
        {
            //Assign
            var resUser = new User()
            {
                IsAdmin = false
            };
            var reservation = new Reservation(new User() { IsAdmin = true });

            //Act
            var result = reservation.CanbeCancelled(resUser);
            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void CanBeCancelled_NullUser_ExpectedException()
        {
            var reservation = new Reservation(new User());
            Assert.Throws<ArgumentNullException>(() => reservation.CanbeCancelled(null));
            //Assert.That(() => reservation.CanbeCancelled(null), Is.InstanceOf<ArgumentNullException>());            
        }
    }
}
