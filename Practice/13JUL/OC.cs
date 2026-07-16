// class OC
// {
//     public void Pay(string method)
//     {
//         if (method == "Creditcard")
//         {
//             Console.WriteLine("Paid using credit card");
//         }
//         else if(method == "UPI")
//         {
//             Console.WriteLine("Paid using UPI");
//         }
//         else if(method == "Cash")
//         {
//             Console.WriteLine("Paid using cash in bank");
//         }
//     }
// }

class OC
{
    public void Process(Payment p)
    {
        p.pay();
    }

    static void Main()
    {
        OC c = new OC();
        c.Process(new CreditCard());
        c.Process()
    }
}