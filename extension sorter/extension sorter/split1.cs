using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace extension_sorter
{
    class split1
    {
        public void splitNew(int _Length, string[] _d, string _path)
        {
            string[] extension = new string[_Length+1]; //taken array for further use 

            string[] trim = new string[_Length+1]; //taken array for further use
            int l = 0;// use new variable because we can not use d[] in for{j} cuz for renew it. we want existing varialbe
            foreach (string item in _d)
            {
                trim = item.Split(new char[] { '\\'}, StringSplitOptions.RemoveEmptyEntries); // split use \\ for split directory

                
                for (int j = 0; j < trim.Length; j++)
                {
                    
                    if (trim[j] == "Desktop")
                    {
                        extension[j] = trim[j + 1];   // save next array element of Desktop that is our desired file
                        Console.WriteLine(extension[j]); // print that file

                        File.Move(_d[l], @_path + extension[j]); //then move file d represent previous path, path+extention shows new
                        l++;                                                               //its like tm naraz ho+mp3
                    }

                }
            }

        }
    }
}
