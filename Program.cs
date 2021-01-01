using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Algorithms_in_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = 20000;
            if(args.Length > 0
                && !int.TryParse(args[0],out iterations)
                && iterations <= 0){
                    Console.WriteLine("Error: iteration count should be positive interget");
            }
            else{
                //RunTest(iterations);
                string path = @"C:\windows";
               // ShowLargeFileWithoutLinq(path);

               // ShowLargeFileWithLinq(path);
            }
        }

        private static void RunTest(int iterations)
        {
            throw new NotImplementedException();
        }

// every thing below this point is not related to alorithms
        private static void ShowLargeFileWithLinq(string path)
        {
            var query = from file in new DirectoryInfo(path).GetFiles()
                        orderby file.Length descending
                        select file;

            var query2 = new DirectoryInfo(path).GetFiles()
                                .OrderByDescending(f => f.Length)
                                .Take(5);

            foreach (var file in query.Take(5))
            {
                Console.WriteLine($"{file.Name, -20} : {file.Length, 10:N0}");
            }
          
        }

        private static void ShowLargeFileWithoutLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            //fileinfo have Array class
            Array.Sort(files, new FileInfoCompare());

            foreach (FileInfo file in files)
            {
                Console.WriteLine($"{file.Name, -20} : {file.Length, 10:N0}");
            }
        }

        
    }
    public class FileInfoCompare : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }

    }
}
