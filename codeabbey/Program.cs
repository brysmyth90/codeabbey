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
            Abbey43 abbey43 = new Abbey43();
            List<int> ans = abbey43.answer_it();
            using (var writer = new StreamWriter(@"Data\\Abbey43_Out.txt"))
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
