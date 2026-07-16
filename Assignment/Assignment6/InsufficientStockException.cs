using System;

class InsufficientStockException : Exception
{
    public InsufficientStockException() : base("Price should be greater than 0")
    {
    }
}