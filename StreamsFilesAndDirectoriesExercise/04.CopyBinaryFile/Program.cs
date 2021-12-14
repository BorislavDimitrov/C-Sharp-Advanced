using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using FileStream fs = new FileStream(@"C:\TEMP\StreamsFilesAndDirectoriesExercise\CopyBinaryText.png"  , FileMode.Open , FileAccess.Read);
            using FileStream fs2 = new FileStream(@"C:\TEMP\StreamsFilesAndDirectoriesExercise\CopyBinaryResult.png" , FileMode.Create , FileAccess.Write);
            byte[] data = new byte[fs.Length];

            fs.Read(data);
            fs2.Write(data);
        }
    }
}
