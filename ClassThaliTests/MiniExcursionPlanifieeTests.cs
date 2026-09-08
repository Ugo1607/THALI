using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassThali;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassThali.Tests
{
    [TestClass()]
    public class MiniExcursionPlanifieeTests
    {
        [TestMethod()]
        public void GetCodeTest()
        {
            MiniExcursion ME = new MiniExcursion(142, "Visite du lycée", 32);
            MiniExcursionPlanifiee MEP = new MiniExcursionPlanifiee("ABCD",ME, DateTime.Parse("15:30"));
            Assert.AreEqual("ABCD", MEP.GetCode(), "Le code de la mep est ABCD");

        }

        [TestMethod()]
        public void SetNombreInscritsTest()
        {
            MiniExcursion ME = new MiniExcursion(142, "Visite du lycée", 32);
            MiniExcursionPlanifiee MEP = new MiniExcursionPlanifiee("ABCD", ME, DateTime.Parse("15:30"));
            MEP.SetNombreInscrits(16);
            Assert.AreEqual(16, MEP.GetNombreInscrits());
        }

        [TestMethod()]
        public void EstCompleteTest()
        {
            MiniExcursion ME = new MiniExcursion(142, "Visite du lycée", 32);
            MiniExcursionPlanifiee MEP = new MiniExcursionPlanifiee("ABCD", ME, DateTime.Parse("15:30"));
            MEP.SetNombreInscrits(32);
            Assert.AreEqual(true, MEP.EstComplete());
        }

        [TestMethod()]
        public void HeureRetourPrevueTest()
        {
            MiniExcursion ME = new MiniExcursion(142, "Visite du lycée", 32);
            ME.AjouteEtape("e", 20);
            MiniExcursionPlanifiee MEP = new MiniExcursionPlanifiee("ABCD", ME, DateTime.Parse("15:30"));
            Assert.AreEqual((DateTime.Parse("15:50")), MEP.HeureRetourPrevue());
        }
    }
}