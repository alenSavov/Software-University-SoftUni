using NUnit.Framework;
using System;

namespace _02.Database.Tests
{
    using ExtendedDataBase.Repository;

    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestValidConstructor(People values)
        {
            Database db = new Database(values);


        }

    }
}
