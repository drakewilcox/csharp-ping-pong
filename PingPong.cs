using System;
class PingPong
{
  static void Main()
    {
      Console.WriteLine("Enter a number to play Ping-Pong!");
      string stringInputNumber = Console.ReadLine();
      int inputNumber = int.Parse(stringInputNumber);
      Console.WriteLine("YOUR NUMBERS:");

      for(int index = 1; index <= inputNumber; index++)
      {
        if ((index % 3 == 0) && (index % 5 == 0))
        {
          Console.WriteLine("Ping-Pong");
        }
        else if (index % 5 == 0)
        {
          Console.WriteLine("Pong");
        }
        else if (index % 3 == 0)
        {
          Console.WriteLine("Ping");
        }
        else
        {
          Console.WriteLine(index);
        }
      }

    }
}