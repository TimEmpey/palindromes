using System;

namespace Palindromes.Models
{
  public class Reverse
  {
    public string InputName { get; set; }

    public Reverse(string inputName)
    {
      InputName = inputName;
    }

    public string GetArray()
    {
      return InputName;
    }
  }
}