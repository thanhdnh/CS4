class Account
{
  string username;
  string email;
  int age;
  string status;

  public string Username { get => username;}
  public int Age { get => age;}
  public string Status { get => status;}
  public string Email { get => email;}

  public Account(string username, string email, int age, string status)
  {
    this.username = username;
    this.email = email;
    this.age = age;
    this.status = status;
  }
  public override string ToString()
  {
    return $"Account[username: {Username}, email: {Email}, age: {Age}, status: {Status}]";
  }
}