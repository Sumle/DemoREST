using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoREST.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoREST.Repositories.Tests
{
    [TestClass()]
    public class TeacherRepositoryTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            TeacherRepository repo = new();
            Assert.AreEqual(2, repo.GetAll().Count);
        }
    }
}