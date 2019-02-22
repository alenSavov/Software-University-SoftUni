using System;
using System.Collections.Generic;
using System.Text;


public class CommandInterpreter
{
    private IMyList<string> myList;

    public CommandInterpreter()
    {
        this.myList = new MyList<string>();
    }

    public void InterpreterCommand(string[] cmdArgs)
    {
        var command = cmdArgs[0];
        string element;


        switch (command)
        {
            case "Add":
            element = cmdArgs[1];
                this.myList.Add(element);
                break;
            case "Remove":
                var index = int.Parse(cmdArgs[1]);
                this.myList.Remove(index);
                break;
            case "Contains":
                element = cmdArgs[1];
                Console.WriteLine(this.myList.Contains(element));
                break;
            case "Swap":
                var firstIndex = int.Parse(cmdArgs[1]);
                var secondIndex = int.Parse(cmdArgs[2]);
                this.myList.Swap(firstIndex, secondIndex);
                break;
            case "Greater": // Greater <element> - Counts the elements that are greater than the given element and prints their count
                element = cmdArgs[1];
                Console.WriteLine(this.myList.CountGreaterThan(element));
                break;
            case "Max": // Max - Prints the maximum element in the list
                Console.WriteLine(this.myList.Max());
                break;
            case "Min": // Min - Prints the minimum element in the list
                Console.WriteLine(this.myList.Min());
                break;
            case "Print": // Print - Prints all elements in the list, each on a separate line
                          // Console.WriteLine(this.myList);
                foreach (var item in this.myList)
                {
                    Console.WriteLine(item);
                }

                break;
            case "Sort":
                this.myList.Sort();
                break;
            default:
                break;
        }

    }

}

