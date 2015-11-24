using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionWithLateBinding
{
    public class Program
    {
        static void Main()
        {
            //load the current executing assembly
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            //load and instantiate the class dynamically at runtime - "Calculator class"
            Type calculatorType = executingAssembly.GetType("ReflectionWithLateBinding.Calculator");


            //Create an instance of the type --"Calculator class"
            object calculatorInstance = Activator.CreateInstance(calculatorType);

            //Get the info of the method to be executed in the class
            MethodInfo sumArrayMethod = calculatorType.GetMethod("SumNumbers");

            object[] arrayParams = new object[2];

            arrayParams[0] = 50;
            arrayParams[1] = 80;
            int sum;

            //Call "SumNumbers" Method
            sum = (int)sumArrayMethod.Invoke(calculatorInstance, arrayParams);
           
            Console.WriteLine("Sum = {0}",  sum);

            Console.ReadLine();
           
        }

        

    }
}
