using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeabbey
{
    class Abbey5
    {
        public List<int> answer_it()
        {
            List<int> answers = new List<int>();
            foreach (string line in File.ReadLines(@"Data\\Abbey5_In.txt"))
            {
                string[] nums_string = line.Split(' ');
                int[] nums = Array.ConvertAll<string, int>(nums_string, int.Parse);
                if (nums.Length == 3)
                {
                    answers.Add(nums.Min());
                }
                using (var writer = new StreamWriter(@"Data\\Abbey5_Out.txt"))
                {
                    // Loop through numbers.
                    foreach (int i in answers)
                    {
                        writer.Write(i + " ");
                    }
                }
            }

            return answers;
        }
    }
}
