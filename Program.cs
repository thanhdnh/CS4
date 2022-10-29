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
  static int SumStack(MyStack ms)
  {
    MyStack temp = new MyStack();
    int sum = 0;
    while (!ms.IsEmpty())
    {
      int n = (int)ms.Pop().data;
      sum += n;
      temp.Push(n);
    }
    while (!temp.IsEmpty())
      ms.Push((int)temp.Pop().data);
    return sum;
  }
  static int SumQueue(MyQueue mq)
  {
    int sum = 0;
    MyQueue tempQueue = new MyQueue();
    while (!mq.IsEmpty())
    {
      int t = (int)mq.Dequeue().data;
      sum += t;
      tempQueue.Enqueue(t);
    }
    while (!tempQueue.IsEmpty())
    {
      mq.Enqueue(tempQueue.Dequeue());
    }
    return sum;
  }
  static int FindS(MyStack ms, int x)
  {
    MyStack temp = new MyStack();
    int vitri = -1;
    int chiso = 0;
    while (!ms.IsEmpty())
    {
      int n = (int)ms.Pop().data;
      if (n == x) { vitri = chiso; }
      else chiso += 1;
      temp.Push(n);
    }
    while (!temp.IsEmpty())
    {
      ms.Push((int)temp.Pop().data);
    }
    return vitri;
  }
  static int FindQ(MyQueue mq, int x)
  {
    return 0;
  }
  static void Main(string[] args)
  {
    Console.Clear();

    MyStack ms = new MyStack();
    ms.Push(1); ms.Push(2); ms.Push(3);
    Console.WriteLine(FindS(ms, 2));
    System.Console.WriteLine("Sum of Stack: {0}", SumStack(ms));

    MyQueue mq = new MyQueue();
    mq.Enqueue(1);
    mq.Enqueue(2);
    mq.Enqueue(3);
    System.Console.WriteLine("Sum of Queue: {0}", SumQueue(mq));
    Console.ReadLine();
  }
}