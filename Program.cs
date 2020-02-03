using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wrkdir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is the project name?");
            string projName = Console.ReadLine();

            try
            {
                string path = (System.Environment.CurrentDirectory + "/"+ projName);

                if (Directory.Exists(path))
                {
                    Console.WriteLine("Workflow folder structure alrdy exists...");
                    return;
                }

                DirectoryInfo di = Directory.CreateDirectory(path);
                di = Directory.CreateDirectory(path+"/svg");
                di = Directory.CreateDirectory(path + "/Inspiration");
                di = Directory.CreateDirectory(path + "/Design_Files");
                di = Directory.CreateDirectory(path + "/Import_Files");
                di = Directory.CreateDirectory(path + "/Captures");

                Console.WriteLine("created workflow tree structure");

                //Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("failed becasue: " + e);
            }
            finally {
                Console.WriteLine("press enter to quit");
                Console.ReadLine(); }
            
        }
    }
}
