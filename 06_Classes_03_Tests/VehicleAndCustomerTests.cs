using System;
using _06_Classes_03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Classes_03_Tests
{
    [TestClass]
    public class VehicleAndCustomerTests
    {
        [TestMethod]
        public void Vehicle_SetMake_ShouldBeCorrectString()
        {
            //--Arrange
            Vehicle vehicle = new Vehicle();
            vehicle.Make = "Porsche";

            //--Act
            var actual = vehicle.Make;
            var expected = "Porsche";

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Vehicle_SetModel_ShouldBeCorrectString()
        {
            //--Arrange
            Vehicle vehicle = new Vehicle();
            vehicle.Model = "944";

            //--Act
            var actual = vehicle.Model;
            var expected = "944";

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Vehicle_SetModelYear_ShouldBeCorrectInteger()
        {
            //--Arrange
            Vehicle vehicle = new Vehicle();
            vehicle.ModelYear = 1986;

            //--Act
            var actual = vehicle.ModelYear;
            var expected = 1986;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Vehicle_SetOwner_ShouldBeCorrectCustomer()
        {
            //--Arrange
            Vehicle vehicle = new Vehicle();
            Customer customer = new Customer();
            vehicle.Owner = customer;

            //--Act
            var actual = vehicle.Owner;
            var expected = customer;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Customer_SetAge_ShouldBeCorrectInteger()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.Age = 25;

            //--Act
            var actual = customer.Age;
            var expected = 25;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Customer_SetFirstName_ShouldBeCorrectString()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.FirstName = "Ben";

            //--Act
            var actual = customer.FirstName;
            var expected = "Ben";

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Customer_SetLastName_ShouldBeCorrectString()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.LastName = "Bracher";

            //--Act
            var actual = customer.LastName;
            var expected = "Bracher";

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Customer_SetAddress_ShouldBeCorrectString()
        {
            //--Arrange
            Customer customer = new Customer();
            customer.Address = "5000 way way";

            //--Act
            var actual = customer.Address;
            var expected = "5000 way way";

            //--Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
