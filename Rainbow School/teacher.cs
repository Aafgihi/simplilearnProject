using System;
using System.IO;

namespace Rainbow_School
{
    class teacher
    {

        int id ;
       public string name;
       public string section;

        static void Main(string[] args)
        {
            
        //   StreamReader fileReader = new StreamReader(@"C:\data\teacher data.txt");
            teacher tc = new();
            Console.WriteLine("Welcome!");
            int count = 1;
            while (count == 1 ) {
                Console.WriteLine("To add new teacher  , press 1");
                Console.WriteLine("To view all teacher , press 2");
                int Enter = int.Parse(Console.ReadLine());
                if (Enter == 1)
                {
                    StreamWriter fileWriter = new StreamWriter(@"C:\data\teacher data.txt", true);//Append
                    try
                    {
                        Console.WriteLine("Enter Your ID : ");
                        tc.id = int.Parse(Console.ReadLine());
                        fileWriter.WriteLine("ID : " + tc.id);
                        Console.WriteLine("Enter Your Name : ");
                        tc.name = Console.ReadLine();
                        fileWriter.WriteLine("Name : " + tc.name);
                        Console.WriteLine("Enter Your Section : ");
                        tc.section = Console.ReadLine();
                        fileWriter.WriteLine("Section : " + tc.section);

                        fileWriter.WriteLine("---------------------");
                        fileWriter.Close();

                    }
                    catch { }
                }
                else if ( Enter == 2)
                {
                    StreamReader fileReader = new StreamReader(@"C:\data\teacher data.txt");

                    try
                    {
                        
                        string read;
                        while ((read = fileReader.ReadLine()) != null)
                        {

                            Console.WriteLine(read);
                        }
                    }
                    catch { }
                }
                Console.WriteLine("you want Exit press 0 or continue press 1");
                count = int.Parse(Console.ReadLine());
            }
        }
    }
}
