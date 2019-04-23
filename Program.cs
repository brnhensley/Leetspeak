using System;

namespace LeetSpeak
{
    class MainClass
    {
        public static void Main()
        {
          LeetSpeak testLeetSpeak = new LeetSpeak();
          Console.WriteLine("3nt3r 73x7 7o 1337 7ha7 sh17");
          string userInput = Console.ReadLine();
          // char[] testArray = {'a', 'b', ' ', 'c'};
          string result = testLeetSpeak.LeetSpeakConverter(userInput);
          Console.WriteLine(result);
        }
    }
}
