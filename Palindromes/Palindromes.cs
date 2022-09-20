using System;
using System.Collections.Generic;
using Palindromes.Models;

namespace Palindromes
{
  public class Program
  {
    public static void Main()
    {
      Reverse name = new Reverse("Hannah");
      Console.WriteLine(name.GetArray());
    }
  }
}