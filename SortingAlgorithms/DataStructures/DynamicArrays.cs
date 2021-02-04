using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.DataStructures
{
    class DynamicArrays<T> : IEnumerable
    {
        private T[] arr;
        private int len = 0; //length the user thinks the array is
        private int capacity = 0; //actual array size
        public DynamicArrays()
        {
            arr = new T[16]; //initialise with capacity 16
        }
        public DynamicArrays(int size)
        {
            if (size <= 0) throw new Exception("Size must be greater than 0");
            arr = new T[size];
        }
        public int size()
        {
            return len;
        }
        public T get(int index)
        {
            return arr[index];
        }
        public void clear()
        {
            for (int i = 0; i < capacity; i++)
            {
                arr[i] = default(T);
            }
        }
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < len; i++)
            {
               yield return arr[i];
            }
        }
        public Boolean isEmpty()
        {
            return size() == 0;
        }
        public void set (int index, T elem)
        {
            if (size() == 0) throw new Exception("The array is empty\r\n");
            if (index > capacity) throw new Exception("The index does not exists in the current array. Consider adding the element");
            arr[index] = elem;
        }
        public void add(T elem)
        {
            // Time to resize!
            if (len + 1 >= capacity)
            {
                if (capacity == 0) capacity = 1;
                else capacity *= 2; // double the size
                T[] new_arr = new T[capacity];
                for (int i = 0; i < len; i++) new_arr[i] = arr[i];
                arr = new_arr; // arr has extra nulls padded
            }

            arr[len++] = elem;
        }
        public T removeAt(int rm_index)
        {
            if (size() == 0) throw new Exception("Array is empty");
            if (len < rm_index) throw new Exception("The rm_index does not exists");
            T data = arr[rm_index];
            T[] new_arr = new T[len - 1];
            for (int i = 0, j = 0; i < len; i++,j++){
                if (i == rm_index) j--;
                else new_arr[j] = arr[i];
                
            }
            arr = new_arr;
            capacity = --len;
            return data;
        }
        public Boolean remove(T value)
        {
            for (int i = 0; i < len; i++)
            {
                if (arr[i].Equals(value))
                {
                    this.removeAt(i);
                    return true;
                }
            }
            return false;
        }
        public int indexOf(T value)
        {
            for (int i = 0; i < len; i++)
            {
                if(arr[i].Equals(value))
                    return i;
            }
            return -1;
        }
        public Boolean contains(T value) {
            return indexOf(value) != -1;
        }


    }
}
