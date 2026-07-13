using System;

class Generic{
void Print(int number)
{
    Console.WriteLine(number);
}

void Print1(string name)
    {
        Console.WriteLine(name);
    }
}

public class Generic<T>
{
    public void Print(T value)
    {
        Console.WriteLine(value);
    }
}