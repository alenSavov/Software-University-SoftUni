using System;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        Stack<string> stackClass;

        var input = Console.ReadLine().Split(", ");

        string commands;
        while ((commands = Console.ReadLine()) != "END")
        {
            var commandTokens = commands.Split();

            switch (commandTokens[0])
            {
                case "Pop":
                    stackClass.PopElement();
                    break;
                case "Push":
                    stackClass = new Stack<string>(input.Skip(1));
                    break;
            }
            

        }
    }
}

