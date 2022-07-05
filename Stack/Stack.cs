using System.Collections;

public class Stack<T> : IEnumerable<T>
{
    internal class Node<N>
    {
        internal N Data;
        internal Node<N> Next;
    }

    private Node<T> head;

    public int Count{get; private set;}

    public bool IsEmpty => head == null;

    public void Push(T item)
    {
        head = new Node<T>{Data = item, Next = head};
        Count++;
    }

    public T Pop()
    {
        var t = head;

        head = head.Next;

        Count--;

        return t.Data;
    }


    public IEnumerator<T> GetEnumerator()
    {
        var h  = head;

        while(h!=null)
        {
            yield return h.Data;
            h = h.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();
}