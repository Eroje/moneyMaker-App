using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      // Greet the user and get inputs
      Console.WriteLine("Welcome to Money Maker!");

      Console.WriteLine("Hello, Enter an amount to convert to coins:");

      string totalCoinsAsString = Console.ReadLine();

      double totalAmountConverted = Convert.ToDouble(totalCoinsAsString);
      
      Console.WriteLine($"{totalAmountConverted} cents is equal to...");

      // Define coin values
      int goldCoinValue = 10;
      int silverCoinValue = 5;
      int bronzeCoinValue = 1;

      // Calculate the change
      double goldCoins = Math.Floor(totalAmountConverted / goldCoinValue);
      double remainder = totalAmountConverted % goldCoinValue;

      // Console.WriteLine($"{totalAmountConverted} cents is equal to {goldCoins} gold coin");
      // Console.WriteLine($" and {remainder} cents");

      double silverCoins = Math.Floor(remainder / silverCoinValue);
      remainder = totalAmountConverted % silverCoinValue;

      // Console.WriteLine($"{totalAmountConverted} cents is equal to {silverCoins} silver coin");
      // Console.WriteLine($" and {remainder} cents");

      // Print the resiults
      Console.WriteLine($"Gold Coins: {goldCoins}");
      Console.WriteLine($"Silver Coins: {silverCoins}");
      Console.WriteLine($"Bronze Coins: {remainder}");
    }
  }
}
