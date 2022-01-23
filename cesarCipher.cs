using System;
using System.Collections.Generic; 

class Program 
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Encrypt(E)/Decrypt(D):");
      string choice = Console.ReadLine();
      Console.WriteLine("Enter your phase:");
      string plain_phase = Console.ReadLine();
      var userdataencrypted = new List<string>();
      var userdatadecrypted = new List<string>();
      var alphabet = new List<string>() {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","u","r","s","t","u","v","w","x","y","z"};
      string selection = "E";
      string selection2 = "e";
      string selection3 = "D";
      string selection4 = "d";
      var plain_phase2 = new List<string>();
      plain_phase2.Add(plain_phase);
      if (choice == selection || choice == selection2)
      {
        foreach (string i in plain_phase2)
        {
          foreach (var letter in i)
          {
            int index = alphabet.FindIndex(a => a.Contains(letter));
            int add_data = index + 3;
            int mod_data = add_data % 26;
            string final_value = alphabet[mod_data];
            userdataencrypted.Add(final_value);
          }
          Console.WriteLine(string.Format("Encoded Data: ({0}).", string.Join("", userdataencrypted)));
        }
      }
      else if (choice == selection3 || choice == selection4)
      {
        foreach (string i in plain_phase2)
        {
          foreach (var letter in i)
          {
            int index = alphabet.FindIndex(a => a.Contains(letter));
            int add_data = index - 3;
            int mod_data = add_data % 26;
            string final_value = alphabet[mod_data];
            userdatadecrypted.Add(final_value);
          }
          Console.WriteLine(string.Format("Decoded Data: ({0}).", string.Join("", userdatadecrypted)));
        }
      }
    }
  }




  
