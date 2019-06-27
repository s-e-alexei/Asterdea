using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterdea
{
    class Compartments
    {       
            public Holds holds;

            public Compartments(string dirname)
            {
                holds = new Holds();

                string[] dirPaths = Directory.GetDirectories("..\\..\\Data\\Compartments\\");

                for (int j = 0; j < dirPaths.Length; j++)
                {
                    string[] filePaths = Directory.GetFiles(dirPaths[j]);
                    string[] dirPaths2 = Directory.GetDirectories(dirPaths[j] + "\\");
                    if (dirPaths2.Length != 0)
                    {
                        for (int i = 0; i < dirPaths2.Length; i++)
                        {
                            string[] filePaths2 = Directory.GetFiles(dirPaths2[i]);
                            for (int k = 0; k < filePaths2.Length; k++)
                            {
                                //Console.WriteLine(filePaths2[k]);
                                string str = filePaths2[k];
                                string str1 = str.Substring(str.LastIndexOf(@"\") + 1);
                                str1 = str1.Substring(0, str1.Length - 4);
                                holds.Add(new Hold(CompartmentsList.Get(filePaths2[k]), str1));
                                Console.WriteLine(holds.GetLast());
                            }
                        }
                    }
                    for (int i = 0; i < filePaths.Length; i++)  // 
                    {
                        //Console.WriteLine(filePaths[i]);
                        string str = filePaths[i];
                        string str1 = str.Substring(str.LastIndexOf(@"\") + 1);
                        str1 = str1.Substring(0, str1.Length - 4);
                        holds.Add(new Hold(CompartmentsList.Get(filePaths[i]), str1));
                        Console.WriteLine(holds.GetLast());
                    }

                    Console.WriteLine();
                }
            }
        
    }
}
