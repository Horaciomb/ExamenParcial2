using System;
using Horacio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebatt2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaSave()
        {
            //Organizar
            Company comp = new Company("Horacio", 200);
            double ValorEsperado = 500;
            //actuar
            comp.Save(300);
            double ValorObtenido = comp.SaveProject;
            //afirmar
            Assert.AreEqual(ValorEsperado, ValorObtenido);

        }

        [TestMethod]
        public void PruebaSpend()
        {
            //Organizar
            Company comp = new Company("Horacio", 200);
            double ValorEsperado = 50;
            //actuar
            comp.Spend(150);
            double ValorObtenido = comp.SaveProject;
            //afirmar
            Assert.AreEqual(ValorEsperado, ValorObtenido);


        }

        [TestMethod]
        public void PruebaChangeName()
        {
            //Organizar
            Company comp = new Company("Horacio", 200);
            string ValorEsperado = "Hola";
            //actuar
            comp.ChangeName("Hola");
            string ValorObtenido = comp.Name;
            //afirmar
            Assert.AreEqual(ValorEsperado, ValorObtenido);


        }
    }       
}
