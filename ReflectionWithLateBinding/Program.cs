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

            sum = (int)sumArrayMethod.Invoke(calculatorInstance, arrayParams);
           
            Console.WriteLine("Sum of the two numbers = {0}",  sum);



            //Sum Array Method

            //load the current executing assembly
            Assembly executingAssembly1 = Assembly.GetExecutingAssembly();

            //load and instantiate the class dynamically at runtime - "Calculator class"
            Type calculatorType1 = executingAssembly1.GetType("ReflectionWithLateBinding.Calculator");


            //Create an instance of the type --"Calculator class"
            object calculatorInstance1 = Activator.CreateInstance(calculatorType1);

            //Get the info of the method to be executed in the class
            MethodInfo sumArrayMethod1 = calculatorType1.GetMethod("SumArray");

            int[] numbers = { 10, 10, 10, 10 };
            object[] arrayParams1 = { numbers };

            int sum1;
            sum1 = (int)sumArrayMethod1.Invoke(calculatorInstance1, arrayParams1);


            Console.WriteLine("Sum of the array = {0}", sum1);




            Console.ReadLine();
           
        }

        

    }
}
