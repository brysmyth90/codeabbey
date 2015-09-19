using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeabbey
{
    class Abbey8
    {
        public List<int> answer_it()
        {
            List<string> aeiou = new List<string>()
            {
                "a","e","i","o","u","y"
            };
            List<int> answer_list = new List<int>();
            foreach (string line in File.ReadLines(@"Data\\Abbey8_In.txt"))
            {
                char[] array = line.ToCharArray();
                //List<char> list = new List<char>(array);
                int count = 0;
                foreach (string c in aeiou)
                {
                    count += TextTool.CountStringOccurrences(line, c);
                }
                answer_list.Add(count);
            }
            return answer_list;
        }
        
    }

    /// <summary>
    /// Contains static text methods.
    /// Put this in a separate class in your project.
    /// </summary>
    public static class TextTool
    {
        /// <summary>
        /// Count occurrences of strings.
        /// </summary>
        public static int CountStringOccurrences(string text, string pattern)
        {
            // Loop through all instances of the string 'text'.
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }
    }
}
