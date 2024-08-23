using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Please input the amount you would like to convert (in cents) :");

      string input = Console.ReadLine();
      double inputD = Math.Floor(Convert.ToDouble(input));

      Console.WriteLine($"{inputD} is equal to...");

      int goldValue = 10;
      int silverValue=5;

      double goldCoins = Math.Floor(inputD/goldValue);
      double goldLeftOver = inputD%goldValue;

      double silverCoins = Math.Floor(goldLeftOver/silverValue);
      double silverLeftOver = goldLeftOver%silverValue;

      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Bronze coins: {silverLeftOver}");
      


    }
  }
}
