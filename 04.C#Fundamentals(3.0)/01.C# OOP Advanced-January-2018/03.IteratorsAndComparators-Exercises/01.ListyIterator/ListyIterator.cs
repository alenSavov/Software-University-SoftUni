using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


public class ListyIterator<T> : IEnumerable<T>
{

    private const int CurrentInternalIndexInitialValue = 0;

    private readonly List<T> data;
    private int currentInternalndex;

    public ListyIterator()
    {
        this.data = new List<T>();
        this.currentInternalndex = CurrentInternalIndexInitialValue; 
    }

    public ListyIterator(IEnumerable<T> collectionData)
    {
        this.data = new List<T>(collectionData);
    }

    public bool Move()
    {
        if (this.currentInternalndex < this.data.Count - 1)
        {
            this.currentInternalndex++;
        }
        else
        {
            return false;
        }

        return true;
    }

    public bool HasNext() => this.currentInternalndex < this.data.Count - 1;

    public T Print()
    {
        if (this.data.Count == 0)
        {
            throw new ArgumentException("Invalid Operation!");
        }

        return this.data[this.currentInternalndex];
    }


    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.data.Count; i++)
        {
            yield return this.data[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

