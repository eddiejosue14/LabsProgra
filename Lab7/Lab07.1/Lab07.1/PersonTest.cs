using System;
using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonBL;


namespace Lab07._1
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void APersonIsCreated()
        {

            //Arrange
            PersonBL.PersonBL logic = new PersonBL.PersonBL();
            Person person = new Person()

            {
                Id=1,
                Name = "Some Person",
                Birthday =DateTime.Now

            };

            //Act
                 logic.Create(person);
                 Person saved = logic.GetById(1);


            //Assert
            Assert.IsNotNull(saved, "Person should not been null after insert or person found");


        }

        [TestMethod]
        public void APersonMustHaveAName()
        {

            //Arrange
            PersonBL.PersonBL logic = new PersonBL.PersonBL();
            Person person = new Person()

            {
                Id = 1,
                Name = "",
                Birthday = DateTime.Now

            };

            //Act & Assert

            Assert.ThrowsException<ArgumentException>(() => logic.Create(person));

        }

        [TestMethod]
        public void TheAgeOfAPersonIsCalculatedCorrectly()
        {

            //Arrange profe
            Person p = new Person();
            //set values
            p.Birthday = new DateTime(2010, 01, 01);


            //Arrange
            PersonBL.PersonBL logic = new PersonBL.PersonBL();
            Person person = new Person()

            {
                Id = 1,
                Name = "",
                Birthday = DateTime.Now

            };

            // Act & Assert
            Assert.AreEqual(8, p.Age);


        }
    }
}
