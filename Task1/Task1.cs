using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            try
            {
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(@"INPUT.txt"); // read input file
                line = file.ReadLine();
                file.Close();
                Regex rgx = new Regex(@"^[01]+$"); // check that the file contains only 0 and 1
                if (rgx.IsMatch(line) && line.Length < 100) // and holds less than 100 digits
                {
                    int cur = 0;
                    int max = 0;
                    for (int i = 0; i < line.Length; i++)
                        if (line[i] == '1')
                        {
                            cur++; // current chain length
                            if (max < cur) max = cur; // finding the max
                        }
                        else cur = 0;
                    Console.WriteLine("Maximum length of the chain of 1: " + max);
                    if (!System.IO.File.Exists("OUTPUT.txt")) 
                        System.IO.File.Create("OUTPUT.txt"); // create OUTPUT-file if it doesnt exist
                    System.IO.StreamWriter sw = new System.IO.StreamWriter("OUTPUT.txt");
                    sw.Write("Maximum length of the chain of 1: " + max); // write the chain length
                    sw.Close();
                }
                else Console.WriteLine("Inccorect input");
            }
  
            catch (Exception e) // read exception (if INPUT doesnt exist)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Done! Press any key...");
            Console.ReadKey();
        }
    }
}
