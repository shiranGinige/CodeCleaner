using System;
using System.IO;
using System.Linq;

namespace UnitTestProject1
{
    public class LineEater
    {
        public static void EatFromDirectory(string sDir, string pattern)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        var extension = Path.GetExtension(f);
                        if (extension.Equals(".cs"))
                        {
                            Console.WriteLine("start eating  #:" + f);
                            EatFromFile(f, pattern);
                            Console.WriteLine("finished eating #:" + f);
                        }

                        EatFromDirectory(d, pattern);
                    }
                }

            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        public static void EatFromFile(string file, string pattern)
        {
            var tempFile = Path.GetTempFileName();
            var linesToKeep = File.ReadLines(file).Where(l => !l.TrimStart().StartsWith(pattern));

            File.WriteAllLines(tempFile, linesToKeep);

            File.Delete(file);
            File.Move(tempFile, file);
        }

    }
}