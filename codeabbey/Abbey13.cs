using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeabbey
{
    class Abbey13
    {
        public List<int> answer_it()
        {

            int tot = 0;
            List<int> answers = new List<int> { };
            List<string> lines = new List<string> { };
            List<string> split_line = new List<string> { };
            foreach (string line in File.ReadLines(@"Data\\Abbey13_In.txt"))
            {
                lines.Add(line);
            }
            foreach (string s in lines.Skip(1))
            {
                string[] s_ints = s.Split(' ');
                foreach (string ss in s_ints)
                {
                    split_line.Add(ss);
                }
                tot = 0;
                for (int i = 1; i <= split_line.Count; i++ )
                {
                    tot += int.Parse(split_line[i-1]) * i;

                }
                answers.Add(tot);
            }

            return answers;
        }

    }
}
