using System;

delegate void CommandDelegate();

static class CommandHandlers
{
    public static void SayHello()
    {
        Console.WriteLine("Hello!");
    }

    public static void ShowTime()
    {
        Console.WriteLine("Time: " + DateTime.Now.ToString("HH:mm:ss"));
    }

    public static void SayGoodbye()
    {
        Console.WriteLine("Bye!");
    }
}