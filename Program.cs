using System;

namespace test
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 10;
      int y = Square(x);
      Console.WriteLine(Square(x));
    }
    static int Square(int x)
    {
      int square = x * x;
      return square;
    }
  }
}
