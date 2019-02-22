using System;
using System.Collections.Generic;
using System.Text;


    public class Database
    {
        private const int defaultCapacity = 16;

        private int[] values;
        private int currentIndex;

        public Database()
        {
            this.values = new int[defaultCapacity];
            this.currentIndex = 0;
        }

        public Database(params int[] values)
            : this()
        {
            this.InitializeValues(values);
        }

        private void InitializeValues(int[] inputValues)
        {
            try
            {
                Array.Copy(inputValues, this.values, inputValues.Length);
                this.currentIndex = inputValues.Length;

            }
            catch (ArgumentException e)
            {
                throw new InvalidOperationException("Array is full!");
            }

        }

        public void Add(int element)
        {
            if (currentIndex >= defaultCapacity)
            {
                throw new InvalidOperationException("Array is full!");
            }

            this.values[currentIndex] = element;
            currentIndex++;
        }

        public void Remove()
        {
            if (currentIndex == 0)
            {
                throw new InvalidOperationException("Array is empty!");
            }

            currentIndex--;
            this.values[currentIndex] = default(int);
        }

        public int[] Fetch()
        {
            int[] newArray = new int[currentIndex];
            Array.Copy(this.values, newArray, currentIndex);

            return newArray;
        }
    }

