using System;
using System.Linq;

class Linqeg
{
    static void Main()
    {
        int[] numbers = {3,7,3,6,1,7,8,4,2,8,};
        var even = numbers.Where(x=>x%2==0);

        foreach(var n in even)
        {
            Console.WriteLine(n);
        }
    }
}