using System.Collections;

namespace oop;

public class MyStack<T> : IEnumerable<T>
{
    private T[] _items;
    
    public int Count { get; private set; }
    public int Capacity => _items.Length;

    public MyStack()
    {
        const int defaultCapacity = 4;
        _items = new T[defaultCapacity];
    }

    public MyStack(int capacity)
    {
        _items = new T[capacity];
    }

    public void Push(T item)
    {
        if (_items.Length == Count)
        {
            T[] largerArray = new T[_items.Length * 2];
            Array.Copy(_items, largerArray, _items.Length);
            
            _items = largerArray;
        }

        _items[Count++] = item;
    }

    public void Pop()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        _items[--Count] = default;
    }

    public T Peek()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        
        return _items[Count - 1];
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = Count - 1; i >= 0; i--)
        {
            yield return _items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}