using System;

class Button
{
    public event Action Click;

    public void Press()
    {
        Console.WriteLine("Button is pressed");
        Click?.Invoke();
    }
}