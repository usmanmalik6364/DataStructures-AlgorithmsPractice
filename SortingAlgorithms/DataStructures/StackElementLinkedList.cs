namespace SortingAlgorithms.DataStructures
{
    public class StackElementLinkedList<T>
    {
        private T _data;
        private StackElementLinkedList<T> _next;
        public void setNext(T data, StackElementLinkedList<T> next)
        {
            _data = data;
            _next = next;
        }
        public T getData()
        {
            return _data;
        }
        public StackElementLinkedList<T> getNext()
        {
            return _next;
        }

    }
}