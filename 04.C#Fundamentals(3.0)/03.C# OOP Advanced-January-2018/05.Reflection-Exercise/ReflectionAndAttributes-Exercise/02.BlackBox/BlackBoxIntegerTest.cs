using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;


public class BlackBoxIntegerTest
{
    private StringBuilder testResult;

    public BlackBoxIntegerTest()
    {
        this.testResult = new StringBuilder();
    }

    public BindingFlags Binding { get; private set; }

    public string Run(Type type)
    {
        var classInstance = Activator.CreateInstance(type, true);
        var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
        var fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

        var command = Console.ReadLine().Split('_');

        while (command[0] != "END")
        {
            var num = int.Parse(command[1]);
            methods.FirstOrDefault(m => m.Name == command[0])?.Invoke(classInstance, new object[] { num });

            foreach (var field in fields)
            {
                this.testResult.AppendLine(field.GetValue(classInstance).ToString());
            }

            command = Console.ReadLine().Split('_');
        }

        return this.testResult.ToString().Trim();
    }

}

