using System;

public class UpiPayment : PaymentGateway
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Amount paid usong credit payment");
    }
}