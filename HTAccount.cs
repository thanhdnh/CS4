using System.Collections;
class HTAccount
{
  Hashtable infos = new Hashtable();
  public HTAccount(string username, string email, int age, string status)
  {
    infos["username"] = username;
    infos["email"] = email;
    infos["age"] = age;
    infos["status"] = status;
  }
  public HTAccount(Account acc)
  {
    infos["username"] = acc.Username;
    infos["email"] = acc.Email;
    infos["age"] = acc.Age;
    infos["status"] = acc.Status;
  }
  public override string ToString()
  {
    return $"HTAccount[username: {infos["username"]}, email: {infos["email"]}, age: {infos["age"]}, status: {infos["status"]}]";
  }
}