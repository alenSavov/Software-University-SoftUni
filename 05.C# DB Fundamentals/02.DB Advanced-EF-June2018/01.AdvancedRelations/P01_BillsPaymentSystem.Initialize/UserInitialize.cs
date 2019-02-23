using P01_BillsPaymentSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_BillsPaymentSystem.Initialize
{
   public class UserInitialize
    {
        public static User[] GetUsers()
        {
            User[] userInitializes = new User[]
            {
                 new User() { FirstName = "Gosho", LastName = "Goshov",  Email = "gosho@abv.bg", Password = "123"},
                 new User() { FirstName = "Pesho", LastName = "Peshov",  Email = "Pesho@abv.bg", Password = "1223"},
                 new User() { FirstName = "Ivan", LastName = "Ivanov",  Email = "Ivan@abv.bg", Password = "1223"},
                 new User() { FirstName = "Mydio", LastName = "Mydev",  Email = "Mydio@abv.bg", Password = "w123"}
            };

            return userInitializes;
        }
    }
}
