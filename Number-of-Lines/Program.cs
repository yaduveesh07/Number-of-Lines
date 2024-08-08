using System;
using System.IO;
using System.Text;

class NumberOfLines
{
    public static void Main()
    {
        string fileName = @"testfile.txt";
        int count;

        try
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            Console.Write("\n\n Count the number of lines in a file :\n");
            Console.Write("------------------------------------------\n");

            using (StreamWriter fileStr = File.CreateText(fileName))
            {
                fileStr.WriteLine(" test line 1");
                fileStr.WriteLine(" test line 2");
                fileStr.WriteLine(" Test line 3");
                fileStr.WriteLine(" test line 4");
                fileStr.WriteLine(" test line 5");
            }

            using (StreamReader sr = File.OpenText(fileName))
            {
                string str = "";
                count = 0;
                Console.WriteLine(" Here is the content of the file testfile.txt : ");
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                    count++;
                }
                Console.WriteLine("");
            }

            Console.Write(" The number of lines in the file {0} is : {1} \n\n", fileName, count);
        }
        catch (Exception MyExcep)
        {
            Console.WriteLine(MyExcep.ToString());
        }
    }
}