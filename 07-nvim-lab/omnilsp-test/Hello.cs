// See https://aka.ms/new-console-template for more information
namespace omnilsptest.console
{
  public class Hello
  {
    public Hello()
    {

    }
    public void SayHello()
    {
      System.Console.WriteLine("hello!");
    }
    public void Say(string message)
    {
      if(string.IsNullOrEmpty(message)) {
        System.Console.WriteLine("please pass a valid name");
      } else {
        System.Console.WriteLine($"hello {message}");
      }
    }
  }
}


