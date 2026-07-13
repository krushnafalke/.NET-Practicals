using System;

public static class Extension
{
    public static string ProperCase(this string name)
    {
        return char.ToUpper(name[0])+ 
        name.Substring(1).ToLower();
    }
}