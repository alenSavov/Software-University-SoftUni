using System;
using System.Collections.Generic;
using System.Text;

namespace _02.ExtendedDataBase.Interfaces
{
    public interface IPerson
    {
        long Id { get; }
        string Username { get; }
        bool Equals(IPerson other);
    }
}
