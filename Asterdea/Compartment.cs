using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterdea
{
    class Compartment
    {
        private Double level;
        private Double sounding;
        private Double volume1;
        private Double volume2;
        private Double volume3;
        private Double volume4;
        private Double volume5;
        private Double volume6;
        private Double volume7;
        private Double volume8;
        private Double volume9;

        public double Level { get => level; set => level = value; }
        public double Sounding { get => sounding; set => sounding = value; }
        public double Volume1 { get => volume1; set => volume1 = value; }
        public double Volume2 { get => volume2; set => volume2 = value; }
        public double Volume3 { get => volume3; set => volume3 = value; }
        public double Volume4 { get => volume4; set => volume4 = value; }
        public double Volume5 { get => volume5; set => volume5 = value; }
        public double Volume6 { get => volume6; set => volume6 = value; }
        public double Volume7 { get => volume7; set => volume7 = value; }
        public double Volume8 { get => volume8; set => volume8 = value; }
        public double Volume9 { get => volume9; set => volume9 = value; }

        public Compartment(Double level, Double sounding, Double volume1, Double volume2, Double volume3, Double volume4, Double volume5, Double volume6, Double volume7, Double volume8, Double volume9)
        {
            this.level = level;
            this.sounding = sounding;
            this.volume1 = volume1;
            this.volume2 = volume2;
            this.volume3 = volume3;
            this.volume4 = volume4;
            this.volume5 = volume5;
            this.volume6 = volume6;
            this.volume7 = volume7;
            this.volume8 = volume8;
            this.volume9 = volume9;
        }

        public Compartment(double v1, double v2, double v3, double v4, double v5, double v6, double v7, double v8, double v9, double v10)
        {
        }

        public override string ToString()
        {
            return $"{Level}, {Sounding}, { Volume1}, { Volume2}, { Volume3}, { Volume4}, { Volume5}, { Volume6}, { Volume7}, { Volume8}, {Volume9},\n";
        }
    }
    class Calc
    {

    
        public static List<Compartment> Get(string filename)
        {

            List<Double[]> st1 = new List<Double[]>();

            try
            {
                foreach (string line in System.IO.File.ReadLines(@"C:\\Users\\USER\\source\\repos\\Asterdea\\Asterdea\\Data\\Compartments\\S1.csv"))

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
                compartment.Add(new Compartment(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8], item[9]));
                foreach (var subitem in item)
                {
                    Console.Write(subitem + " ");
                }
                Console.WriteLine();

            }
            return compartment;

        }
        public double[] GetInterpolatedValue()

        {
            List<Compartment> GetInterpolatedValue = new List<Compartment>();

            double vi1 = 1; //Convert.ToDouble(Console.ReadLine());
            int pos1 = 0;
            for (int i = 0; i < GetInterpolatedValue.Count; i++)
            {
                if (GetInterpolatedValue[i].Sounding > vi1)
                {
                    pos1 = i - 1; //x1 = xmin
                    break;
                }

            }
            Console.WriteLine(pos1 + "   ");
            Console.WriteLine();

            /*
            double[] xyz = new double[3];

            xyz[0] = Math.Abs((((GetInterpolatedValue[pos1 + 1].Volume1 - GetInterpolatedValue[pos1].Volume1)) / (GetInterpolatedValue[pos1 + 1].Sounding - GetInterpolatedValue[pos1].Sounding)) * (vi1 - GetInterpolatedValue[pos1].Sounding) + GetInterpolatedValue[pos1].Volume1);
            xyz[1] = Math.Abs((((GetInterpolatedValue[pos1 + 1].Volume2 - GetInterpolatedValue[pos1].Volume2)) / (GetInterpolatedValue[pos1 + 1].Sounding - GetInterpolatedValue[pos1].Sounding)) * (vi1 - GetInterpolatedValue[pos1].Sounding) + GetInterpolatedValue[pos1].Volume2);
            xyz[2] = Math.Abs((((GetInterpolatedValue[pos1 + 1].Volume3 - GetInterpolatedValue[pos1].Volume3)) / (GetInterpolatedValue[pos1 + 1].Sounding - GetInterpolatedValue[pos1].Sounding)) * (vi1 - GetInterpolatedValue[pos1].Sounding) + GetInterpolatedValue[pos1].Volume3);
                        
            return xyz;
            */

            double xi = Math.Abs((((GetInterpolatedValue[pos1 + 1].Volume1 - GetInterpolatedValue[pos1].Volume1)) / (GetInterpolatedValue[pos1 + 1].Sounding - GetInterpolatedValue[pos1].Sounding)) * (vi1 - GetInterpolatedValue[pos1].Sounding) + GetInterpolatedValue[pos1].Volume1);

            Console.WriteLine(xi);
            Console.Read();
            
        }

        //public class arrayVolBySound

        //{
        //    // public static void (string[] args)
        //    // string[] dirPaths = Directory.GetDirectories("..\\..\\Data\\Compartments\\");
        //    arrayVolBySound = new double[i];

        //        for (int j = 0; j<dirPaths.Length; j++)
        //        {
        //            string[] filePaths = Directory.GetFiles(dirPaths[j]);
        //  string[] dirPaths2 = Directory.GetDirectories(dirPaths[j] + "\\");

        //        }
        // }

    }

}

