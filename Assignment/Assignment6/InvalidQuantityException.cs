using System;

class InvalidQuantityException : Exception
{
    public InvalidQuantityException() : base("Price should be greater than 0")
    {
    }
}