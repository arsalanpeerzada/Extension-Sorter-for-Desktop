using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace extension_sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t \t" + "Desktop Manager");
            bool bol = false;
            string p = @"C:\Users\Wali\Downloads\Desktop";//the link jahan se files utha rhe hain
            do//use do for repeating process
            {
                int Length = 30;
                Console.Write("Extension:  ");
                string ex = Console.ReadLine();//extension user defined kara

                string[] d = Directory.GetFiles(p, "*." + ex);//then created directory and retrive files in array d
                Console.WriteLine(@"Create NewFolder or Use Existing folder

Press 1 to New Folder

Press 2 for Existing Folder");
                string file = Console.ReadLine().ToLower();//use if for new folder aur not
                if (file == "1".ToString())
                {
                    Console.WriteLine(@"Path format= c:\example\");
                    Console.Write("Path:   ");
                    string path = @"C:\Users\Arsalan peerzada\Downloads\Desktop\New";

                    Directory.CreateDirectory(path);
                    Console.WriteLine("Folder Created");

                    split1 obj = new split1();
                    obj.splitNew(Length, d, path);
                }
                else if (file == "2".ToString())
                {
                    Console.WriteLine(@"Path format= c:\example\");
                    Console.Write("Path:   ");
                    string path = Console.ReadLine();

                    split1 obj = new split1();
                    obj.splitNew(Length, d, path);
                }

                Console.WriteLine("Move more files Enter Yes OR No");//in this part programe ask for repeat aur not
                string next = Console.ReadLine().ToString();
                if (next == "yes")
                {
                    bol = true; //yes pe bool ko true karde ga aur 
                }
                else
                {
                    break;
                }

            } while (bol == true);
        }
    }
}
