using System;

public class CircularQueue<T>
{
    private const int InitialCapacity = 16;
    private T[] elements;
    private int head;
    private int tail;

    public int Count { get; private set; }

    public CircularQueue()
        : this(InitialCapacity)
    {
    }

    public CircularQueue(int capacity)
    {
        this.elements = new T[capacity];
    }

    public void Enqueue(T element)
    {
        if (this.Count >= this.elements.Length)
        {
            this.Grow();
        }

        this.elements[this.tail] = element;
        this.tail = (this.tail + 1) % this.elements.Length;
        this.Count++;
    }

    public T Dequeue()
    {
        if (this.Count <= 0)
        {
            throw new InvalidOperationException("There are no elements in the queue");
        }

        T elementToDeque = this.elements[this.head];
        this.head = (this.head + 1) % this.elements.Length;
        this.Count--;
        return elementToDeque;
    }

    public T[] ToArray()
    {
        T[] returnedArray = new T[this.Count];
        int currentIndex = this.head;
        for (int index = 0; index < this.Count; index++)
        {
            returnedArray[index] = this.elements[currentIndex];
            currentIndex = (currentIndex + 1) % this.elements.Length;
        }

        return returnedArray;
    }

    private void Grow()
    {
        T[] newElementsArray = new T[this.elements.Length * 2];
        int currentIndex = this.head;

        for (int index = 0; index < this.Count; index++)
        {
            newElementsArray[index] = this.elements[currentIndex];
            currentIndex = (currentIndex + 1) % this.elements.Length;
        }

        this.head = 0;
        this.tail = this.Count;
        this.elements = newElementsArray;
    }
}