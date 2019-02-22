using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

[TestFixture]
public class DatabaseTests
{
    [Test]
    [TestCase((new int[] { 1, 3, 2, 1 }))]
    [TestCase((new int[] { 4, 3, 2, 1 }))]
    [TestCase((new int[] { -10 }))]

    public void TestValidConstructor(int[] values)
    {
        Database db = new Database(values);

        FieldInfo fieldInfo = typeof(Database)
            .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
            .First(fi => fi.FieldType == typeof(int[]));

        IEnumerable<int> fieldValues = ((int[])fieldInfo.GetValue(db)).Take(values.Length);
        Assert.That(fieldValues, Is.EquivalentTo(values));
    }

    [Test]
    public void TestInvalidConstructor()
    {
        int[] values = new int[17];

        Assert.That(() => new Database(values), Throws.InvalidOperationException);
    }

    [Test]
    [TestCase(int.MinValue)]
    [TestCase(int.MaxValue)]
    [TestCase(-20)]
    [TestCase(0)]
    public void TestAddMethodValid(int value)
    {
        Database db = new Database();
        db.Add(value);

        FieldInfo valuesInfo = typeof(Database)
            .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
            .First(fi => fi.FieldType == typeof(int[]));

        FieldInfo currentIndexInfo = typeof(Database)
           .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
           .First(fi => fi.FieldType == typeof(int));

        int firstValue = ((int[])valuesInfo.GetValue(db)).First();
        Assert.That(firstValue, Is.EqualTo(value));

        int valuesCount = (int)currentIndexInfo.GetValue(db);
        Assert.That(valuesCount, Is.EqualTo(1));
    }

    [Test]
    public void TestAddMethodInvalid()
    {
        Database db = new Database();

        FieldInfo currentIndexInfo = typeof(Database)
          .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
          .First(fi => fi.FieldType == typeof(int));

        currentIndexInfo.SetValue(db, 16);

        Assert.That(() => db.Add(1), Throws.InvalidOperationException);
    }

    [Test]
    [TestCase((new int[] { 1, 3, 2, 1 }))]
    [TestCase((new int[] { 4, 3, 2, 1 }))]
    [TestCase((new int[] { -10 }))]
    public void TestRemoveMethodValid(int[] values)
    {
        Database db = new Database();

        FieldInfo fieldInfo = typeof(Database)
           .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
           .First(fi => fi.FieldType == typeof(int[]));

        fieldInfo.SetValue(db, values);

        FieldInfo currentIndexInfo = typeof(Database)
         .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
         .First(fi => fi.FieldType == typeof(int));

        currentIndexInfo.SetValue(db, values.Length);

        db.Remove();

        int[] actualValues = (int[])fieldInfo.GetValue(db);
        int[] buffer = new int[actualValues.Length - (values.Length - 1)];

        values = values
            .Take(values.Length - 1)
            .Concat(buffer)
            .ToArray();

        Assert.That(actualValues, Is.EquivalentTo(values));
    }

    [Test]
    public void TestRemoveMethodInvalid()
    {
        Database db = new Database();

        FieldInfo currentIndexInfo = GetFieldInfo(db, typeof(int));

        currentIndexInfo.SetValue(db, 0);

        Assert.That(() => db.Remove(), Throws.InvalidOperationException);

    }

    private FieldInfo GetFieldInfo(object instance, Type fieldType)
    {
        FieldInfo fieldInfo = instance.GetType()
      .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
      .First(fi => fi.FieldType == fieldType);

        return fieldInfo;
    }
}
