using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeabbey
{
    class Abbey4
    {
        public List<int> answer_it()
        {
            List<int> answers = new List<int>();
            foreach (string line in File.ReadLines(@"Data\\Abbey4_In.txt"))
            {
                string[] nums_string = line.Split(' ');
                int[] nums = Array.ConvertAll<string, int>(nums_string, int.Parse);
                if (nums.Length == 2)
                {
                    answers.Add(nums.Min());
                }
                using (var writer = new StreamWriter(@"Data\\Abbey4_Out.txt"))
                {
                    // Loop through numbers.
                    foreach (int i in answers)
                    {
                        writer.Write( i + " " );
                    }
                }
            }

            return answers;
        }
    }
}
