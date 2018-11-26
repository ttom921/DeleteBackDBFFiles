using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateFileName dateFileName = new DateFileName();
            string dtfile = dateFileName.GenDataFileName();
            DeleteFiles(dtfile);
            //Console.WriteLine("dtfile->" + dtfile);
            Console.WriteLine("job done");
            Console.Read();
        }
        private static void DeleteFiles(string dtfile)
        {
            try
            {
                string directoryPath = @"D:\SQLBackup";
                var dir = new DirectoryInfo(directoryPath);
                string patrernfile = $"*{dtfile}*";
                foreach (var file in dir.EnumerateFiles(patrernfile))
                {
                    string msg = $"delete file->{file.Name}";
                    file.Delete();
                    Console.WriteLine(msg);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(nameof(DeleteFiles) + " " + ex.Message);
            }
        }
    }
}
