using System;
using System.Collections.Generic;
using System.Collections;
public class Program
{
  static void Main()
  {
    Console.Clear();
    
    Account acc1 = new Account("abc", "abc@xyz.com", 19, "Hello!");
    Account acc2 = new Account("def", "def@xyz.com", 23, "Hi!");
    Account acc3 = new Account("ikl", "ikl@xyz.com", 22, "Hey!");
    AccountDict acd = new AccountDict();
    /*acd.Add(acc1.getEmail(), acc1);
    acd.Add(acc2.getEmail(), acc2);
    acd.Add(acc3.getEmail(), acc3);
    //System.Console.WriteLine(acd.Item("def@xyz.com"));
    IDictionaryEnumerator e = acd.GetEnumerator();
    while(e.MoveNext())
      System.Console.WriteLine("{0}=>{1}", e.Key, e.Value);*/

    /*Dictionary<string, Account> dict = new Dictionary<string, Account>();
    dict.Add(acc1.Email, acc1);
    dict.Add(acc2.Email, acc2);
    dict.Add(acc3.Email, acc3);
    //System.Console.WriteLine(dict["ikl@xyz.com"]);
    foreach(KeyValuePair<string, Account> v in dict)
      System.Console.WriteLine("{0}=>{1}", v.Key, v.Value);*/
    
    /*SortedDictionary<string, Account> sdict = new SortedDictionary<string, Account>();
    sdict.Add(acc2.Email, acc2);
    sdict.Add(acc3.Email, acc3);
    sdict.Add(acc1.Email, acc1);
    foreach(KeyValuePair<string, Account> v in sdict)
      System.Console.WriteLine("{0}=>{1}", v.Key, v.Value);*/
    
    HTAccount htacc1 = new HTAccount(acc1);
    HTAccount htacc2 = new HTAccount(acc2);
    HTAccount htacc3 = new HTAccount(acc3);
    List<HTAccount> lacc = new List<HTAccount>();
    lacc.Add(htacc1);
    lacc.Add(htacc2);
    lacc.Add(htacc3);
    foreach(HTAccount v in lacc)
      System.Console.WriteLine(v);

    Console.ReadLine();
  }
}