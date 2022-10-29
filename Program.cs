using System.Collections;
using System.Collections.Generic;
class Program
{
  public class Node
  {
    public Node next;
    public object data;
  }
  public class MyStack
  {
    Node top;
    public bool IsEmpty()
    {
      return top == null;
    }
    public void Push(object ele)
    {
      Node n = new Node();
      n.data = ele;
      n.next = top;
      top = n;
    }
    public Node Pop()
    {
      if (top == null)
        return null;
      Node d = top;
      top = top.next;
      return d;
    }
  }
  public class Node2
  {
    public Node2 prev, next;
    public object data;
  }
  public class MyQueue
  {
    Node2 rear, front; public bool IsEmpty()
    {
      return rear == null || front == null;
    }
    public void Enqueue(object ele)
    {
      Node2 n = new Node2();
      n.data = ele;
      if (rear == null)
      {
        rear = n; front = n;
      }
      else
      {
        rear.prev = n;
        n.next = rear; rear = n;
      }
    }
    public Node2 Dequeue()
    {
      if (front == null) return null;
      Node2 d = front;
      front = front.prev;
      if (front == null)
        rear = null;
      else
        front.next = null;
      return d;
    }
  }
  static void Main(string[] args)
  {
    Console.Clear();

    MyQueue mq = new MyQueue();
    mq.Enqueue(1);
    mq.Enqueue(2);
    mq.Enqueue(3);

    Console.ReadLine();
  }
}