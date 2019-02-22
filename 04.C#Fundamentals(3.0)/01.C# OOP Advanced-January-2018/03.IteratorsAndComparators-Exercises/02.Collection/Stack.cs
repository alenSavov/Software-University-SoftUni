using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


public class Stack<T> : IEnumerable<T>
{
    private const int InitialCapacity = 2;

    private T[] stackData;
    private int length;

    public Stack()
    {
        this.stackData = new T[InitialCapacity];
    }

    public T Pop()
    {
        if (this.length == 0)
        {
            throw new ArgumentException("No elements");
        }

        this.length--;
        var lastElement = this.stackData[this.length];
        this.stackData[this.length] = default(T);

        return lastElement;
    }

    public void Push(T element)
    {
        if (this.length >= this.stackData.Length * 2)
        {
            Array.Resize(ref this.stackData, this.stackData.Length * 2);
        }

        this.stackData[this.length] = element;
        this.length++;
    }

    public void Push(IEnumerable<T> elements)
    {
        foreach (var item in elements)
        {
            this.Push(item);
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.length - 1; i >= 0; i--)
        {
            yield return this.stackData[i];
        }
    }   

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

