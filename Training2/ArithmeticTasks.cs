using System;

namespace Training
{
    internal class ArithmeticTasks
    {
        static (int x, int y) Method((int x, int y) tuple)
        {
            var res = (x: tuple.y, y: tuple.x);
            return res;
        }
    }
}
