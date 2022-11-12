using System;
using System.Collections.Generic;
public class Program
{
  public class Node
  {
    public object element;
    public Node link;
    public Node()
    {
      element = null;
      link = null;
    }
    public Node(object element)
    {
      this.element = element;
      link = null;
    }
  }
  public class LinkedList
  {
    public Node header;
    public LinkedList()
    {
      header = new Node("Header");
    }
    private Node Find(object element)
    {
      Node current = new Node();
      current = header;
      while (current.element != element)
        current = current.link;
      return current;
    }
    public void Insert(object newelement, object afterelement)
    {
      Node current = new Node();
      Node newnode = new Node(newelement);
      current = Find(afterelement);
      newnode.link = current.link;
      current.link = newnode;
    }
    public Node FindPrev(object element)
    {
      Node current = header;
      while (current.link != null && current.link.element != element)
        current = current.link;
      return current;
    }
    public void Remove(object element)
    {
      Node current = FindPrev(element);
      if (current.link != null)
        current.link = current.link.link;
    }
    public void Print()
    {
      Node current = new Node();
      current = header;
      while (current.link != null)
      {
        Console.WriteLine(current.link.element);
        current = current.link;
      }
    }
  }

  public class Node2
  {
    public object element;
    public Node2 flink, blink;
    public Node2()
    {
      element = null;
      flink = blink = null;
    }
    public Node2(object element)
    {
      this.element = element;
      flink = blink = null;
    }
  }

  public class DoubleLinkedList
  {
    public Node2 header;
    public DoubleLinkedList()
    {
      header = new Node2("Header");
    }
    private Node2 Find(object element)
    {
      Node2 current = new Node2();
      current = header;
      while (current.element != element)
      {
        current = current.flink;
      }
      return current;
    }
    public void Insert(object newelement, object afterelement)
    {
      Node2 current = new Node2();
      Node2 newnode = new Node2(newelement);
      current = Find(afterelement);
      newnode.flink = current.flink;
      newnode.blink = current;
      current.flink = newnode;
    }
    public void Remove(object element)
    {
      Node2 current = Find(element);
      if (current.flink != null)
      {
        current.blink.flink = current.flink;
        current.flink.blink = current.blink;
        current.flink = null;
        current.blink = null;
      }
    }
    private Node2 FindLast()
    {
      Node2 current = new Node2();
      current = header;
      while (!(current.flink == null))
        current = current.flink;
      return current;
    }
    public void Print()
    {
      Node2 current = new Node2();
      current = FindLast();
      while (!(current.blink == null))
      {
        Console.WriteLine(current.element);
        current = current.blink;
      }
    }
  }
  static void Main()
  {
    Console.Clear();
    
    LinkedList ll = new LinkedList();
    ll.Insert("11", "Header");
    ll.Insert("22", "11");
    ll.Insert("33", "22");
    ll.Print();
    
    Console.ReadLine();
  }
}