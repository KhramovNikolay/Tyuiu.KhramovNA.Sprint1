using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhramovNA.Sprint1.Task6.V16.Lib
{
    public class DataService : ISprint1Task6V16
    {
        public bool CheckSpecSymbols(string value)
        {
            bool hasExclamation = false;
            bool hasQuestion = false;

            foreach (char symbol in value)
            {
                if (symbol == '!')
                {
                    hasExclamation = true;
                }
                else if (symbol == '?')
                {
                    hasExclamation = true;
                }
            }
            return hasExclamation && hasQuestion;

        }
    }
}
