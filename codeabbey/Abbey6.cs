using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeabbey
{
    class Abbey6
    {
        public List<int> answer_it()
        {
            List<int> answers = new List<int>();
            foreach (string line in File.ReadLines(@"Data\\Abbey6_In.txt"))
            {
                string[] nums_string = line.Split(' ');
                if (nums_string.Length == 2)
                {
                    Double fraction = Convert.ToDouble(nums_string[0]) /Convert.ToDouble(nums_string[1]);
                    Double ans_doub = Math.Round(fraction, MidpointRounding.AwayFromZero);
                    int ans = Convert.ToInt32(ans_doub);
                    answers.Add(ans);
                }
                
            }

            return answers;
        }
    }
}
