using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeabbey
{
    class Abbey41
    {
        public List<int> answer_it()
        {
            List<int> answers = new List<int>();
            foreach (string line in File.ReadLines(@"Data\\Abbey41_In.txt"))
            {
                string[] nums_string = line.Split(' ');
                List<int> listOfInts = nums_string.Select(Int32.Parse).ToList();
                if (listOfInts.Count == 3)
                {
                    listOfInts.Sort();
                    answers.Add(listOfInts[1]);
                    
                }

            }

            return answers;
        }
    }
}