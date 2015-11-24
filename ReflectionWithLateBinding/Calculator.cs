using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReflectionWithLateBinding
{
    public class Calculator
    {
        public int SumNumbers(int input1, int input2)
        {
            return input1 + input2;
        }


        public int SumArray(params int[] input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            return sum;
        }
     
    }

   
}



