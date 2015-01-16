using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Logic : ICalculator
    {
        public  int add(string numbers)
        {
            try
            {
                int sum = 0;
                if (numbers == "" || numbers.Length == 0)
                {
                    return 0;
                }
                else
                {
                    string no_modified = Regex.Replace(numbers, @"[^0-9]+", ",");
                    string[] no_array = no_modified.Split(',');
                    foreach (string no in no_array)
                    {
                        sum = sum + Convert.ToInt32(no);
                    }
                    return sum;
                }
            }

            catch (FormatException)
            {
                return -1;
            }

            catch (Exception)
            {
                return -2;
            }

        }
    }
}
