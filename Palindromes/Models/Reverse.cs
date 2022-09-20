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
      char[] backwards = InputName.ToCharArray();
      Array.Reverse(backwards);
      string results = new string(backwards);
      return results;
    }

    public string Results()
    {
      if (GetArray() == InputName)
      {
        return "Your Name is a palindrome";
      }
      else
      {
        return "Your name is not a Palindrome";
      }
    }     
  }
}