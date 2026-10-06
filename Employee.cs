using System;

public class Employee
{
    // Dummy credentials for secret-scanning tests only
    private const string Username = "demo_user";
    private const string Password = "DummyPassword123!";
    private const string ApiKey = "DUMMY_API_KEY_1234567890";

    public static void Main()
    {
        Console.WriteLine($"Username: {Username}");
        Console.WriteLine("Demo credential test");
    }
}
