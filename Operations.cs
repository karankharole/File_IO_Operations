using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_Operations
{
    public class Operations
    {
        public void FileExists()
        {
            Console.WriteLine("\n File Exists Operation ");
            string filePath = @"D:\File_IO_Operations\WordFile1.txt";
            if (File.Exists(filePath))
            {
                Console.WriteLine("\nFile Exists");
            }
            else
            {
                Console.WriteLine("\nFile Not Found");
            }
        }

        public void ReadAllLines()
        {
            Console.WriteLine("\n  Read All Lines  \n");
            string filePath = @"D:\File_IO_Operations\WordFile1.txt";
            string[] lines;
            lines = File.ReadAllLines(filePath);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.ReadLine();
        }
    }
}
