using System;

class LoginFailedException : Exception
{
    public LoginFailedException()
        : base("Login Failed! Account Locked.")
    {
    }
}