using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterdea
{
    class CompartmentsList
    {



        public static List<Compartment> Get(string filename)
        {

            List<Double[]> st1 = new List<Double[]>();

            try
            {
                foreach (string line in System.IO.File.ReadLines(filename)) //@"C:\\Users\\USER\\source\\repos\\Asterdea\\Asterdea\\Data\\Compartments\\S1.csv"

                    st1.Add(line.Trim().Replace('.', ',').Split(';').Select(double.Parse).ToArray());
            }
            catch (Exception e)
            {
                Console.WriteLine("NOT READ");
                Console.WriteLine(e.Message);
            }

            List<Compartment> compartment = new List<Compartment>();

            foreach (Double[] item in st1)
            {
                compartment.Add(new Compartment(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8], item[9], item[10]));
                foreach (var subitem in item)
                {
                    Console.Write(subitem + " ");
                }
                Console.WriteLine();

            }
            return compartment;

        }
    }  
}
