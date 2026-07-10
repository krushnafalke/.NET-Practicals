
using System;

//Lambda expression
// Func<int, int, int> add = (a,b) => a+b;
// Console.WriteLine(add(588,756));

delegate void MessageDelegate(string msg);

class delegateeg

{
    static MessageDelegate m;
    static void Display(string message)
    {
        Console.WriteLine("Mathod1: " +message);
    }
     static void Display1(string message)
    {
        Console.WriteLine("Mathod2: " +message);
    }
     static void Display2(string message)
    {
        Console.WriteLine("Mathod3: " +message);
    }

    static void Main()
    {
        m = Display;
        m +=Display1;
        m +=Display2;
        m("hello, i am learning .net");

        Button bt = new Button();
        bt.Click +=() => Console.WriteLine("Click event");
        bt.Press();
    }
}
