using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeabbey
{
    class Abbey43
    {
        public List<int> answer_it()
        {
            List<int> dice = new List<int> { };
            List<string> rands = new List<string> { };
            foreach (string line in File.ReadLines(@"Data\\Abbey43_In.txt"))
            {
                rands.Add(line);
            }
            for (int i = 1; i < rands.Count(); i++)
            {
                double dice_doub = Math.Floor((double.Parse(rands[i]) * 6.0));
                //double round_dice = Math.Round(dice_doub, 0);
                //double round_dice = Math.Round(dice_doub, 0);
                int dice_rolled = Convert.ToInt16(dice_doub);
                dice.Add(dice_rolled + 1);
            }
            return dice;
        }

    }
}
