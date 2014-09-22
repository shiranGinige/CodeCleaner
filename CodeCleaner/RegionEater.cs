using System;
using System.IO;
using System.Linq;

namespace UnitTestProject1
{
    public class CodeCleaner

    {
        private string _directory;
        public CodeCleaner(string directory)
        {
            _directory = directory;
        }

        public void EatRegions()
        {
            LineEater.EatFromDirectory(_directory , "#region");
            LineEater.EatFromDirectory(_directory, "#endregion");

        }

        public void EatComments()
        {
            LineEater.EatFromDirectory(_directory, @"///");
            
        }
       

    }
}