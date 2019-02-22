using _02.ExtendedDataBase.Interfaces;
using _02.ExtendedDataBase.Models;
using _02.ExtendedDataBase.Repository;
using NUnit.Framework;
using System;
using System.Linq;

namespace _02.ExtendedDatabase.Test
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void ConstructorInitializationWorks()
        {
            // Arrange
            var person = new Person(123, "Test");

            // Assert
            Assert.AreNotEqual(null, person);
            Assert.AreEqual(123, person.Id);
            Assert.AreEqual("Test", person.Username);
        }


        [Test]
        public void AllPropertiesHaveNonPublicSetters()
        {
            // Arrange
            var personType = typeof(Person);
            var propertiesWithPublicSetters = personType
                .GetProperties()
                .Where(p => p.SetMethod.IsPublic)
                .ToArray();

            // Assert
            Assert.AreEqual(0, propertiesWithPublicSetters.Length);
        }
    }
}
