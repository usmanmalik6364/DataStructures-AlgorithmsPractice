using System;
using System.Collections;

namespace SortingAlgorithms.DataStructures
{
    public class Stack<T> : IEnumerable
    {
        private int _size = 0;
        private int _maxSize = 100;
        private StackElementLinkedList<T> _top;
        public void push(T data)
        {
            if (_size >= _maxSize) throw new StackOverflowException("Stack full");
            StackElementLinkedList<T> element = new StackElementLinkedList<T>();
            element.setNext(data, _top);
            _top = element;
            _size++;
        }
        public T pop()
        {
            if (_size == 0) throw new InsufficientExecutionStackException("Stack empty");
            var data = _top.getData();
            _top = _top.getNext();
            _size--;
            return data;
        }
        public T peek()
        {
            if (_size == 0) throw new InsufficientExecutionStackException("Stack empty");
            var data = _top.getData();
            return data;
        }
        public Boolean isEmpty()
        {
            return (_size > 0);
        }
        public Boolean isFull()
        {
            return (_size == _maxSize);
        }
        public IEnumerator GetEnumerator()
        {
            StackElementLinkedList<T> current = _top;
            while (current != null)
            {
                yield return current.getData();
                current = current.getNext();
            }
        }

    }
}