using System;
using System.Collections;

namespace SortingAlgorithms.DataStructures
{
    public class Node<T>
    {
        private T _data;
        private Node<T> _next;
        public Node(T data)
        {
            _data = data;
            _next = null;

        }
        public Node<T> getNext()
        {
            return _next;
        }
        public void setNext(Node<T> next)
        {
            _next = next;

        }
        public T getData()
        {
            return _data;
        }


    }
}