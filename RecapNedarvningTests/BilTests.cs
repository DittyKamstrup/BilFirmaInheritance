using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecapNedarvning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapNedarvning.Tests
{
    [TestClass()]
    public class BilTests
    {

        [TestMethod()]
        public void beregnAfgiftDiesel_80500_Test()
        {
            //Arrange
            Dieselbil bil = new Dieselbil(80500, 2014, "BMW", "xx99999", 50, 500);
            //Act
            int afgift = bil.Registreringsafgift();
            //Assert
            Assert.AreEqual(84525, afgift);
        }

        [TestMethod()]
        public void beregnAfgiftBenzin_80500_Test()
        {
            //Arrange
            BenzinBil bil = new BenzinBil(80500, 2014, "BMW", "xx99999", 50, 500);
            //Act
            int afgift = bil.Registreringsafgift();
            //Assert
            Assert.AreEqual(84525, afgift);
        }

        [TestMethod()]
        public void beregnAfgiftDiesel_80499_Test()
        {
            //Arrange
            Dieselbil bil = new Dieselbil(80499, 2014, "BMW", "xx99999", 50, 500);
            //Aact
            int afgift = bil.Registreringsafgift();
            //Assert
            Assert.AreEqual(84523, afgift);
        }

        [TestMethod()]
        public void beregnAfgiftBenzin_80499_Test()
        {
            //Arrange
            BenzinBil bil = new BenzinBil(80499, 2014, "BMW", "xx99999", 50, 500);
            //Act
            int afgift = bil.Registreringsafgift();
            //Assert
            Assert.AreEqual(84523, afgift);
        }

        [TestMethod()]
        public void beregnAfgiftDiesel_81700_Test()
        {
            //Arrange
            Dieselbil bil = new Dieselbil(81700, 2015, "BMW", "xx99999", 50, 500);
            //Act
            int afgift = bil.Registreringsafgift();
            //Assert
            Assert.AreEqual(82660, afgift);  //85785
        }

        [TestMethod()]
        public void beregnAfgiftBenzin_81700_Test()
        {
            //Arrange
            BenzinBil bil = new BenzinBil(81700, 2015, "BMW", "xx99999", 50, 500);
            //Act
            int afgift = bil.Registreringsafgift();
            //Assert
            Assert.AreEqual(82660, afgift);  //85785
        }

        [TestMethod()]
        public void beregnAfgiftDiesel_81699_Test()
        {
            //Arrange
            Dieselbil bil = new Dieselbil(81699, 2015, "BMW", "xx99999", 50, 500);
            //Act
            int afgift = bil.Registreringsafgift();
            //Assert
            Assert.AreEqual(82658, afgift); //85783
        }

        [TestMethod()]
        public void beregnAfgiftBenzin_81699_Test()
        {
            //Arrange
            BenzinBil bil = new BenzinBil(81699, 2015, "BMW", "xx99999", 50, 500);
            //Act
            int afgift = bil.Registreringsafgift();
            //Assert
            Assert.AreEqual(82658, afgift);  //85783
        }

        [TestMethod()]
        public void beregnAfgiftDiesel_81701_Test()
        {
            //Arrange
            Dieselbil bil = new Dieselbil(81701, 2015, "BMW", "xx99999", 50, 500);
            //Act
            int afgift = bil.Registreringsafgift();
            //Assert
            Assert.AreEqual(82661, afgift);  //85786
        }

        [TestMethod()]
        public void beregnAfgiftBenzin_81701_Test()
        {
            //Arrange
            BenzinBil bil = new BenzinBil(81701, 2015, "BMW", "xx99999", 50, 500);
            //Act
            int afgift = bil.Registreringsafgift();
            //Assert
            Assert.AreEqual(82661, afgift);  //85786
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftDiesel_true_Test()
        {
            //Arrange
            Dieselbil dBil = new Dieselbil(81700, 2015, "BMW", "xx99999", 50, 500, true);
            //Act
            int ejeAfgift = dBil.HalvÅrligEjerAfgift();
            //Assert
            Assert.AreEqual(350, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftDiesel_false_Test()
        {
            //Arrange
            Dieselbil dBil = new Dieselbil(81700, 2015, "BMW", "xx99999", 50, 500, false);
            //Act
            int ejeAfgift = dBil.HalvÅrligEjerAfgift();
            //Assert
            Assert.AreEqual(850, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftBenzinTest()
        {
            //Arrange
            BenzinBil bBil = new BenzinBil(81700, 2015, "BMW", "xx99999", 50, 500);
            //Act
            int ejeAfgift = bBil.HalvÅrligEjerAfgift();
            //Assert
            Assert.AreEqual(320, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftBenzin2Test()
        {
            //Arrange
            BenzinBil bBil = new BenzinBil(81700, 2015, "BMW", "xx99999", 19, 500);
            //Act
            int ejeAfgift = bBil.HalvÅrligEjerAfgift();
            //Assert
            Assert.AreEqual(1200, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftBenzin3Test()
        {
            //Arrange
            BenzinBil bBil = new BenzinBil(81700, 2015, "BMW", "xx99999", 25, 500);
            //Act
            int ejeAfgift = bBil.HalvÅrligEjerAfgift();
            //Assert
            Assert.AreEqual(600, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftElTest()
        {
            //Arrange
            ElBil eBil = new ElBil(81700, 2015, "BMW", "xx99999", 25, 500);
            //Act
            int ejeAfgift = eBil.HalvÅrligEjerAfgift();
            //Assert
            Assert.AreEqual(0, ejeAfgift);
        }


        [TestMethod()]
        public void HalvÅrligEjerAfgiftDiesel_true_2014_Test()
        {
            //Arrange
            Dieselbil dBil = new Dieselbil(80500, 2014, "BMW", "xx99999", 50, 500, true);
            //Act
            int ejeAfgift = dBil.HalvÅrligEjerAfgift();
            //Assert
            Assert.AreEqual(350, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftDiesel_false_2014_Test()
        {
            //Arrange
            Dieselbil dBil = new Dieselbil(80500, 2014, "BMW", "xx99999", 50, 500, false);
            //Act
            int ejeAfgift = dBil.HalvÅrligEjerAfgift();
            //Assert
            Assert.AreEqual(850, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftBenzin_2014_Test()
        {
            //Arrange
            BenzinBil bBil = new BenzinBil(80500, 2014, "BMW", "xx99999", 50, 500);
            //Act
            int ejeAfgift = bBil.HalvÅrligEjerAfgift();
            //Assert
            Assert.AreEqual(320, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftBenzin2_2014_Test()
        {
            //Arrange
            BenzinBil bBil = new BenzinBil(80500, 2014, "BMW", "xx99999", 19, 500);
            //Act
            int ejeAfgift = bBil.HalvÅrligEjerAfgift();
            //Assert
            Assert.AreEqual(1200, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftBenzin3_2014_Test()
        {
            //Arrange
            BenzinBil bBil = new BenzinBil(80500, 2014, "BMW", "xx99999", 25, 500);
            //Act
            int ejeAfgift = bBil.HalvÅrligEjerAfgift();
            //Assert
            Assert.AreEqual(600, ejeAfgift);
        }

        [TestMethod()]
        public void HalvÅrligEjerAfgiftEl_2014_Test()
        {
            //Arrange
            ElBil eBil = new ElBil(80500, 2014, "BMW", "xx99999", 25, 500);
            //Act
            int ejeAfgift = eBil.HalvÅrligEjerAfgift();
            //Assert
            Assert.AreEqual(0, ejeAfgift);
        }


        [TestMethod()]
        public void RækkeViddeDieselTest()
        {
            //Arrange
            Dieselbil dBil = new Dieselbil(80500, 2014, "BMW", "xx99999", 15, 85);
            //Act
            int rækkeVidde = dBil.RækkeVidde();
            //Assert
            Assert.AreEqual(1275, rækkeVidde);
        }

        [TestMethod()]
        public void RækkeViddeBenzinTest()
        {
            //Arrange
            BenzinBil bBil = new BenzinBil(80500, 2014, "BMW", "xx99999", 12, 85);
            //Act
            int rækkeVidde = bBil.RækkeVidde();
            //Assert
            Assert.AreEqual(1020, rækkeVidde);
        }

        [TestMethod()]
        public void RækkeViddeElTest()
        {
            //Arrange
            ElBil eBil = new ElBil(80500, 2014, "BMW", "xx99999", 60, 515);
            //Act
            int rækkeVidde = eBil.RækkeVidde();
            //Assert
            Assert.AreEqual(30900, rækkeVidde);
        }



        //[ExpectedException(typeof(ArgumentException))]
        //[TestMethod()]
        //public void RegistreringsAfgiftExceptionTest()
        //{
        //    Dieselbil dBil = new Dieselbil(80500, 2013, "BMW", "xx99999", 15, 85);

        //    try
        //    {
        //        dBil.Registreringsafgift();
        //        Assert.Fail();
        //    }
        //    catch (ArgumentException)
        //    {
        //        Expected
        //    }
        //}

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod()]
        public void RegistreringsAfgiftExceptionTest()
        {
            //Arrange
            Dieselbil bil = new Dieselbil(0, 2014, "BMW", "xx99999", 50, 500);
            //Act
            int afgift = bil.Registreringsafgift();
            //Assert
            Assert.AreEqual(84525, afgift);
        }

    }
}