using System;

        CommandDelegate commandDelegate;

        Console.WriteLine("Введите команду (привет, время, пока):");
        string input = Console.ReadLine().ToLower();

        switch (input)
        {
            case "привет":
                commandDelegate = CommandHandlers.SayHello;
                break;
            case "время":
                commandDelegate = CommandHandlers.ShowTime;
                break;
            case "пока":
                commandDelegate = CommandHandlers.SayGoodbye;
                break;
            default:
                Console.WriteLine("Неверная команда!");
                Console.ReadLine();
                return;
        }

        commandDelegate();

        Console.ReadLine();
    

