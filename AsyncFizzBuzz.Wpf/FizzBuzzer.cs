using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncFizzBuzz.Wpf
{
    public static class FizzBuzzer
    {
        public static async Task<string> ReturnTheFizzBuzzValue(int i, int seconds)
        {
            string s = null;
            if (i > 0)
            {
                if (i%3 == 0)
                    s = "fizz";
                if (i%5 == 0)
                    s = s + "buzz";
            }
            if (String.IsNullOrWhiteSpace(s))
                s = i.ToString();
            await Task.Delay(seconds * 1000);

            return s;

        }
    }
}
