using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeabbey
{
    class Abbey7
    {
        public void answer_it()
        {
            List<int> c_list = new List<int>();
            int counter = 0;
            foreach (string line in File.ReadLines(@"Data\\Abbey7_In.txt"))
            {
                string[] nums_string = line.Split(' ');
                int[] nums = Array.ConvertAll<string, int>(nums_string, int.Parse);
                foreach (int f_int in nums)
                {
                    if (counter > 0)
                    {
                        //int f_int = Convert.ToInt32(line);
                        double f_doub = Convert.ToDouble(f_int);
                        double c_doub = (f_doub - 32) * (5.0 / 9.0);
                        double c_doub_round = Math.Round(c_doub, MidpointRounding.AwayFromZero);
                        int c_answer = Convert.ToInt32(c_doub_round);
                        c_list.Add(c_answer);
                    }
                    counter++;
                }
            }
            foreach(int c in c_list)
            {
                Console.Write(c + " ");
            }
            using (var writer = new StreamWriter(@"Data\\Abbey7_Out.txt"))
            {
                // Loop through numbers.
                foreach (int i in c_list)
                {
                    writer.Write(i + " ");
                }
            }
        }
    }
}
