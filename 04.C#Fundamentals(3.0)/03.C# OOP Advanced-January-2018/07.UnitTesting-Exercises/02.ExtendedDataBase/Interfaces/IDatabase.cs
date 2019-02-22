using System;
using System.Collections.Generic;
using System.Text;

namespace _02.ExtendedDataBase.Interfaces
{
    public interface IDatabase<IPerson>
    {
        int CurrentIndex { get; }

        // int Count();

        void Add(IPerson element);

        void Remove();

        IPerson FindByUsername(string name);

        IPerson FindById(long id);
    }
}
