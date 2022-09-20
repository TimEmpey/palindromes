using System;
using System.Collections.Generic;
using Palindromes.Models;

namespace Palindromes
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter your name: ");
      string inputName = Console.ReadLine().ToLower();
      Reverse name = new Reverse(inputName);
      Console.WriteLine("Your name backwards: " + name.GetArray());
      Console.WriteLine(name.Results());
    }
  }
}