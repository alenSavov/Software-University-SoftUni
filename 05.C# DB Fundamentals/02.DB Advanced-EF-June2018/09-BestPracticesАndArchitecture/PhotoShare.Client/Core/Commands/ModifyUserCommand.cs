﻿namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using Contracts;
    using PhotoShare.Client.Core.Dtos;
    using PhotoShare.Services.Contracts;

    public class ModifyUserCommand : ICommand
    {
        public readonly IUserService userService;
        public readonly ITownService townService;

        public ModifyUserCommand(IUserService userService, ITownService townService)
        {
            this.userService = userService;
            this.townService = townService;
        }

        public ModifyUserCommand()
        {
        }

        // ModifyUser <username> <property> <new value>
        // For example:
        // ModifyUser <username> Password <NewPassword>
        // ModifyUser <username> BornTown <newBornTownName>
        // ModifyUser <username> CurrentTown <newCurrentTownName>
        // !!! Cannot change username
        public string Execute(string[] data)
        {
            string username = data[0];
            string property = data[1];
            string value = data[2];

            var userExist = this.userService.Exists(username);

            if (!userExist)
            {
                throw new ArgumentException($"User {username} not found!");
            }

            var userId = this.userService.ByUsername<UserDto>(username).Id;

            if (property == "Password")
            {
                SetPassword(userId, value);
            }
            else if (property == "BornTown")
            {
                SetBornTown(userId, value);
            }
            else if (property == "CurrentTown")
            {
                SetCurrentTown(userId, value);
            }
            else
            {
                throw new ArgumentException($"Property {property} not supported!");
            }

            return $"User {username} {property} is {value}";

        }

        private void SetCurrentTown(int userId, string name)
        {
            var townExist = this.townService.Exists(name);

            if (!townExist)
            {
                throw new ArgumentException($"Value {name} not valid.\nTown {name} not found!");
            }

            var townId = this.townService.ByName<TownDto>(name).Id;

            this.userService.SetCurrentTown(userId, townId);
        }

        private void SetBornTown(int userId, string name)
        {
            var townExist = this.townService.Exists(name);

            if (!townExist)
            {
                throw new ArgumentException($"Value {name} not valid.\nTown {name} not found!");
            }

            var townId = this.townService.ByName<TownDto>(name).Id;

            this.userService.SetBornTown(userId, townId);
        }

        private void SetPassword(int userId, string password)
        {
            var isLower = password.Any(x => char.IsLower(x));
            var isDigit = password.Any(x => char.IsDigit(x));

            if (!isLower || !isDigit)
            {
                throw new ArgumentException($"Value {password} not valid.\n Invalid Password");
            }

            this.userService.ChangePassword(userId, password); 
        }
    }
}
