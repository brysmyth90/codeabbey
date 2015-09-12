using System;
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
            Abbey3 abbey3 = new Abbey3();
            List<int> answers = abbey3.answer_it();
            foreach (int i in answers)
            {
                Console.Write(i + " ");
            }
        }
    }
}
