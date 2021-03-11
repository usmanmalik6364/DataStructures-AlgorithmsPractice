using System.Collections;

namespace SortingAlgorithms.DataStructures
{
    public class LinkedList<T> : IEnumerable
    {
        private Node<T> head = null;
        public LinkedList(Node<T> node)
        {
                
        }
        public void addNode(Node<T> node)
        {   
            
            Node<T> _node = new Node<T>(node.getData());
            

        }

        public IEnumerator GetEnumerator()
        {
            Node<T> current = head;
            while (current.getNext() != null)
            {
                yield return current.getData();
                current.setNext(current.getNext());
            }
        }
    }
}