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
    public void AddFirst(object newelement){
      Node newNode = new Node(newelement);
      newNode.link = header.link;
      header.link = newNode;
    }
    public void AddLast(object newelement){
      Node current = new Node();
      Node newnode = new Node(newelement);
      current = header;
      while(current.link!=null)
        current=current.link;
      current.link=newnode;
    }
    public void AddBefore(object newelement, object beforelement){
      Node current = new Node();
      current = FindPrev(beforelement);
      Node newnode = new Node(newelement);
      newnode.link = current.link;
      current.link = newnode;
    }
    public void DeleteFirst(){
      Node current = header.link.link;
      header.link.link = null;
      header.link = current;
    }
    public int FindMax(){
      Node current = header.link;
      int max = Convert.ToInt32(current.element);
      while (current.link != null)
      {
        current = current.link;
        if (max < Convert.ToInt32(current.element))
          max = Convert.ToInt32(current.element);
      }
      return max;
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
    public int Count(){
      int count = 0;
      Node2 current = header;
      while(current.flink!=null){
        current=current.flink;
        count++;
      }
      return count;
    }
    public int Sum()
    {
      int sum = 0;
      Node2 current = header;
      while(current.flink != null)
      {
        current = current.flink;
        sum += Convert.ToInt32(current.element);
      }
      return sum;
    }
  }
  static void Main()
  {
    Console.Clear();
    
    /*LinkedList ll = new LinkedList();
    ll.Insert("11", "Header");
    ll.Insert("22", "11");
    ll.Insert("33", "22");
    ll.AddBefore("66","33");
    ll.AddFirst("44");
    ll.AddLast("55");
    ll.DeleteFirst();
    Console.WriteLine($"Max là {ll.FindMax()}");
    ll.Print();*/

    /*DoubleLinkedList dl = new DoubleLinkedList();
    dl.Insert("11", "Header");
    dl.Insert("22", "11");
    dl.Insert("55", "22");
    Console.WriteLine("Có "+dl.Count());
    Console.WriteLine("Tổng: " + dl.Sum());*/

    LinkedListNode<int> node0 = new LinkedListNode<int>(11);
    LinkedListNode<int> node1 = new LinkedListNode<int>(22);
    LinkedListNode<int> node2 = new LinkedListNode<int>(33);
    LinkedListNode<int> node3 = new LinkedListNode<int>(44);
    LinkedListNode<int> node4 = new LinkedListNode<int>(55);
    LinkedList<int> dll = new LinkedList<int>();
    dll.AddFirst(node0);
    dll.AddLast(node1);
    dll.AddBefore(node1, node2);
    dll.AddAfter(node2, node3);
    dll.AddFirst(node4);
    foreach(int value in dll)
      System.Console.Write(value + " ");
    LinkedList<int> result = Inverse(dll);
    System.Console.WriteLine();
    foreach(int value in result)
      System.Console.Write(value + " ");

    Console.ReadLine();
  }
  static LinkedList<int> Inverse(LinkedList<int> dll){
    LinkedList<int> result = new LinkedList<int>();
    foreach(int v in dll){
      result.AddFirst(new LinkedListNode<int>(v));
    }
    return result;
  }
}