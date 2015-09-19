using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeabbey
{
    class Abbey28
    {
        /*
        Underweight     -           BMI < 18.5
        Normal weight   -   18.5 <= BMI < 25.0
        Overweight      -   25.0 <= BMI < 30.0
        Obesity         -   30.0 <= BMI
         * 
         * BMI = weight / height^2
         * */

        public List<string> answer_it()
        {
            List<string> answers = new List<string>();
            foreach (string line in File.ReadLines(@"Data\\Abbey28_In.txt"))
            {
                string[] nums_string = line.Split(' ');
                if (nums_string.Length == 2)
                {
                    double weight = Convert.ToDouble(nums_string[0]);
                    double height = Convert.ToDouble(nums_string[1]);
                    double bmi = weight / (height * height);
                    if (bmi < 18.5)
                    {
                        answers.Add("under");
                    }
                    else if (bmi < 25.0)
                    {
                        answers.Add("normal");
                    }
                    else if (bmi < 30.0)
                    {
                        answers.Add("over");
                    }
                    else
                    {
                        answers.Add("obese");
                    }
                }

            }

            return answers;
        }
    }
}