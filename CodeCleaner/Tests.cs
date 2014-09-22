using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class Tests
    {
        const string folderPath = @"C:\SolutionDirectory";

        [TestMethod]
        public void EatComments_Test()
        {
            var codeCleaner = new CodeCleaner(folderPath);
            codeCleaner.EatComments();

        }

        [TestMethod]
        public void EatRegions_Test()
        {
            var codeCleaner = new CodeCleaner(folderPath);
            codeCleaner.EatRegions();
        }

        #region

        public void TEst()
        {

        }

        #endregion 

    }
}
