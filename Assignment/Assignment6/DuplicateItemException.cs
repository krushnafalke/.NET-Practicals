using System;

class DuplicateItemException : Exception
{
    public DuplicateItemException() : base("Duplicate Item")
    {
    }
}