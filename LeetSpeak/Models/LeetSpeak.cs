using System;
using System.Collections.Generic;

namespace LeetSpeak
{
  public class LeetSpeak
  {

    public string LeetSpeakConverter(string userInput)
    {
      char[] userInputArray = userInput.ToCharArray();
      // Console.WriteLine(userInputArray[1]);
      for(int i = 0; i < userInputArray.Length; i++)
      {
        if(userInputArray[i] == 'e' || userInputArray[i] == 'E' )
        {
          userInputArray[i] = '3';
        }
        else if(userInputArray[i] == 'o' || userInputArray[i] == 'O')
        {
          userInputArray[i] = '0';
        }
        else if(userInputArray[i] == 'L')
        {
          userInputArray[i] = '1';
        }
        else if(userInputArray[i] == 't' || userInputArray[i] == 'T')
        {
          userInputArray[i] = '7';
        }
        else if((userInputArray[i] == 's' || userInputArray[i] == 'S')&& i != 0)
        {
          userInputArray[i] = 'z';
        }
      }
      string result = string.Join("", userInputArray);
      return result;

    }    
  }
}
