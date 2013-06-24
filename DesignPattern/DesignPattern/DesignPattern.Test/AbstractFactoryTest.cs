using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPattern.Pattern.AbstractFactory;
using DesignPattern.Model;

namespace DesignPattern.Test
{
    [TestClass]
    public class AbstractFactoryTest
    {
        //[AssemblyInitialize()]
        //public static void AssemblyInit(TestContext context)
        //{
        //}

        //[ClassInitialize()]
        //public static void ClassInit(TestContext context)
        //{
        //}

        //[TestInitialize()]
        //public void Initialize()
        //{
        //}

        //[TestCleanup()]
        //public void Cleanup()
        //{
        //}

        //[ClassCleanup()]
        //public static void ClassCleanup()
        //{
        //}

        //[AssemblyCleanup()]
        //public static void AssemblyCleanup()
        //{
        //}

        [TestMethod]
        [TestCategory("Creational Pattern")]
        [TestProperty("Pattern", "AbstractFactory")]
        public void Should_Be_CarType()
        {
            // arrange
            Type expectedCarBodyType = typeof(CarBody);
            Type expectedCarChassisType = typeof(CarChassis);
            Type expectedCarGlasswareType = typeof(CarGlassware);

            // act
            AbstractVehicleFactory factory = new CarFactory();

            // assert
            Assert.IsInstanceOfType(factory.CreateBody(), expectedCarBodyType);
            Assert.IsInstanceOfType(factory.CreateChassis(), expectedCarChassisType);
            Assert.IsInstanceOfType(factory.CreateGlassware(), expectedCarGlasswareType);
            
        }
    }
}
