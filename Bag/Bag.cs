using System.Collections;

public class Bag<T>: IEnumerable<T>
{
    internal class Node<N>
    {
        internal N Item;
        internal Node<N> next;
    }

    private Node<T> head;

    public int Count {get; private set;}

    public bool IsEmpty => head == null;

    public void Add(T item)
    {
        head = new Node<T>(){ Item = item, next = head};
        Count++;
    }

    public void AddRange(IEnumerable<T> ts)
    {
        foreach(var t in ts) Add(t);
    }

    public IEnumerator<T> GetEnumerator()
    {
        var h = head;

        while(h!=null)
        {
            yield return h.Item;
            h = h.next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();
}