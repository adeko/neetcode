class Node
{
    public int Value;
    public Node Next;
}

public class LinkedList {
    Node Head = null;
    int Size = 0;

    public LinkedList() {}

    public int Get(int index) {
        if (index < 0 || index >= Size) return -1;
        Node current = Head;
        for (int i = 0; i < index; i++)
            current = current.Next;
        return current.Value;
    }

    public void InsertHead(int val) {
        var node = new Node { Value = val, Next = Head };
        Head = node;
        Size += 1;
    }

    public void InsertTail(int val) {
        var node = new Node { Value = val };
        if (Head == null)
        {
            Head = node;
            Size += 1;
            return;
        }
        Node last = Head;
        while (last.Next != null)
        {
            last = last.Next;
        }
        last.Next = node;
        Size += 1;
    }

    public bool Remove(int index) {
        if (index < 0 || index >= Size) return false;
        if (index == 0)
        {
            Head = Head.Next;
            Size -= 1;
            return true;
        }
        Node previous = Head;
        for (int i = 0; i < index - 1; i++)
        {
            previous = previous.Next;
        }
        previous.Next = previous.Next.Next;
        Size -= 1;
        return true;
    }

    public List<int> GetValues() {
        List<int> values = new();
        if (Head == null) return values;
        Node current = Head;
        while (current != null)
        {
            values.Add(current.Value);
            current = current.Next;
        }
        return values;
    }
}