using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.User_Logins
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputUserNameAndPass = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();


            Dictionary<string, string> usernameAndPass = new Dictionary<string, string>();


            while (inputUserNameAndPass[0] != "login")
            {
                string username = inputUserNameAndPass[0];
                string password = inputUserNameAndPass[1];

                usernameAndPass[username] = password;

                inputUserNameAndPass = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }
            inputUserNameAndPass = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int countUnsuccessfulLogin = 0;

            while (inputUserNameAndPass[0] != "end")
            {
                string username = inputUserNameAndPass[0];
                string password = inputUserNameAndPass[1];

                if (usernameAndPass.ContainsKey(username) && usernameAndPass.ContainsValue(password))
                {
                    Console.WriteLine($"{username}: logged in successfully ");
                }
                else if (!usernameAndPass.ContainsKey(username) || usernameAndPass[username] != password)
                {
                    Console.WriteLine($"{username}: login failed");
                    countUnsuccessfulLogin++;

                }


                inputUserNameAndPass = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            }


            Console.WriteLine($"unsuccessful login attempts: {countUnsuccessfulLogin}");
        }
    }
}
