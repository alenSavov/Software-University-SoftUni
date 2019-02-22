using System;
using System.Linq;
using System.Text;

public class StartUp
{
    static void Main(string[] args)
    {
        var creationData = Console.ReadLine().Split();
        ListyIterator<string> collection;

        if (creationData.Length > 1)
        {
            collection = new ListyIterator<string>(creationData.Skip(1));
        }
        else
        {
            collection = new ListyIterator<string>();
        }

        Console.WriteLine(CommandsExecutions(collection));
    }

    private static string CommandsExecutions(ListyIterator<string> collection)
    {
        var sb = new StringBuilder();
        var cmdArgs = Console.ReadLine().Split();

        while (cmdArgs[0] != "END")
        {
            try
            {
                switch (cmdArgs[0])
                {
                    case "Move":
                        sb.AppendLine(collection.Move().ToString());
                        break;
                    case "Print":
                        sb.AppendLine(collection.Print());
                        break;
                    case "HasNext":
                        sb.AppendLine(collection.HasNext().ToString());
                        break;
                    case "PrintAll":
                        foreach (var item in collection)
                        {
                            sb.Append($"{item} ");
                        }

                        sb.Remove(sb.Length - 1, 1);
                        sb.AppendLine();
                        break;
                }
            }
            catch (ArgumentException AE)
            {
                sb.AppendLine(AE.Message);
            }

            cmdArgs = Console.ReadLine().Split();
        }

        return sb.ToString().Trim();
    }
}

