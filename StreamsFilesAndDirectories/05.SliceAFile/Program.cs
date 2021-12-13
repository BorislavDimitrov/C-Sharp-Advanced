using System;
using System.IO;

namespace _05.SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream fs = new FileStream(@"C:\TEMP\SliceAFileInput.txt" , FileMode.Open , FileAccess.Read);
            int eachPartLenght = (int)Math.Abs(fs.Length / 4.0);

            for (int i = 1; i <= 4; i++)
            {
                byte[] buffer = new byte[eachPartLenght];
                fs.Read(buffer);
                using FileStream fs1 = new FileStream($@"C:\TEMP\SliceAFileOutput{i}.txt", FileMode.OpenOrCreate, FileAccess.Write);
                fs1.Write(buffer);
            }
        }
    }
}
