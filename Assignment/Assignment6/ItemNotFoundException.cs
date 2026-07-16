using System;

class ItemNotFoundException : Exception
{
    public ItemNotFoundException()
        : base("Item Not Found")
    {
    }
}