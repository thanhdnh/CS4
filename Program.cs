using System.Collections;
using System.Collections.Generic;
class Program
{
  static int SeqSearch(int[] arr, int value)
  {
    for (int i = 0; i < arr.Length; i++)
      if (value == arr[i])
        return i;
    return -1;
  }
  static int SeqLastSearch(int[] arr, int value)
  {
    for (int i = arr.Length - 1; i >= 0; i--)
      if (value == arr[i])
        return i;
    return -1;
  }
  static List<int> SeqMultiSearch(int[] arr, int value)
  {
    List<int> result = new List<int>();
    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i] == value)
      {
        result.Add(i);
      }
    }
    return result;
  }
  static int RecuSearch(int[] arr, int from, int value)
  {
    if (arr.Length <= 0 || from > arr.Length - 1)
      return -1;
    else
        if (arr[from] == value) return from;
    else
      return RecuSearch(arr, from + 1, value);
  }
  static int SenSearch(int[] arr, int value)
  {
    if (arr.Length > 0)
    {
      int x = arr[arr.Length - 1];
      arr[arr.Length - 1] = value;
      int i = 0;
      while (arr[i] != value)
      {
        i++;
      }
      arr[arr.Length - 1] = x;
      if (i < arr.Length - 1 || arr[arr.Length - 1] == value)
      {
        return i;
      }
    }
    return -1;
  }
  static int BinSearch(int[] a, int value)
  {
    int l = 0, r = a.Length - 1;
    while (l <= r)
    {
      int m = (l + r) / 2;
      if (a[m] == value)
        return m;
      else if (a[m] > value)
        r = m - 1;
      else
        l = m + 1;
    }
    return -1;
  }
  static int BinSearch(int[] a, int value, int L, int R)
  {
    int m = (L + R) / 2;
    if(L>=R)
      return -1;
    if (a[m] == value) { return m; }
    else if (a[m] > value)
      return BinSearch(a, value, L, m - 1);
    else
      return BinSearch(a, value, m + 1, R);
  }
  static void Main(string[] args)
  {
    Console.Clear();
    int[] a = { 2, 8, 6, 8, 8 };
    int val = 10;
    // Console.WriteLine(SeqLastSearch(a,val));
    // foreach (int item in SeqMultiSearch(a,val))
    // {
    //   Console.WriteLine(item);
    // }
    //Console.WriteLine(RecuSearch(a, 0, val));
    // Console.WriteLine(SenSearch(a, val));
    System.Console.WriteLine(BinSearch(a, val, 0, a.Length-1));
    Console.ReadLine();
  }
}