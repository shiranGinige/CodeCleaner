using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CommentEaterTest
    {
        [TestMethod]
        public void Eat_Test()
        {
            var folderPath = @"C:\SolutionDirectory";
            CommentEater.EatFromDirectory(folderPath);

        }
    }
}
