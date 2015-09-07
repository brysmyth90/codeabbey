using System;
using System.IO;

namespace codeabbey
{
    public class Abbey2
    {
        public static String line;
        public static void solve()
        {
            using (StreamReader sr = new StreamReader("Data\\Abbey2_In.txt"))
            {
                line = sr.ReadToEnd();
            }
            string[] words = line.Split(' ');

            int sum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                int this_loop = Int32.Parse(words[i]);
                sum += this_loop;
            }
            Console.WriteLine(sum);
        }
    }
}
