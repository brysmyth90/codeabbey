using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeabbey
{
    class Program
    {
        static void Main(string[] args)
        {
            Abbey13 abbey13 = new Abbey13();
            List<int> ans = abbey13.answer_it();
            using (var writer = new StreamWriter(@"Data\\Abbey13_Out.txt"))
            {
                foreach (int i in ans)
                {
                    Console.Write(i + " ");
                    writer.Write(i + " ");
                }
            }
        }
    }
}
