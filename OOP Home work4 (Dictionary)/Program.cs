Dictionary<string, Action> commands = new Dictionary<string, Action>();
commands["привет"] = SayHello;
commands["время"] = ShowTime;
commands["пока"] = SayGoodbye;

Console.WriteLine("Введите команду (привет, время, пока):");
string input = Console.ReadLine().ToLower();

if (commands.ContainsKey(input))
{
    Action command = commands[input];
    command();
}
else
{
    Console.WriteLine("Неверная команда!");
}

Console.ReadLine();
    

    static void SayHello()
{
    Console.WriteLine("Hello!");
}

static void ShowTime()
{
    Console.WriteLine("Текущее время: " + DateTime.Now.ToString("HH:mm:ss"));
}

static void SayGoodbye()
{
    Console.WriteLine("Bye!");
}
