using System;
using System.Collections.Generic;

namespace Training
{
    class Train : ArithmeticTasks
    {
        static void Main(string[] args)
        {
            int counter = 0;
            List<string> answers = new List<string>();
            answers.Add(ArithmeticTasks.Method(x, y)=(10, 5).ToString());
            foreach (var answer in answers)
            {
                counter++;

                Console.WriteLine($"1.{counter}. x={answer.x}, y={answers.y}");
            }
        }
    }
}
