// See https://aka.ms/new-console-template for more information
using Tuple;
using System.Collections.Generic;

int NUMBER_OF_GEN = 10;

if (args.Length > 0 && args[0] == "--number"){
      if (!int.TryParse(args[1], out NUMBER_OF_GEN)) {
            System.Console.WriteLine("Was not possible to parse the argument passed to --number");
      }
}

IEnumerable<(string, double)> genFunction (int number) {
      var random = new Random();
      string[] catalog = new[] {
        "Coffe lake 12g", "Short latte 120g", "Cappuchino 120 ml"
      };

      double[] prices = new[] {
            12.90, 14.80, 17.22, 22.30, 33.00
      };
      foreach (var i in Enumerable.Range(0, number))
      {
            yield return new (catalog[random.Next(0,catalog.Length - 1)], prices[random.Next(0, prices.Length - 1)]);
      }
};

foreach ((string, double) i in genFunction(NUMBER_OF_GEN) ) {
      System.Console.WriteLine($" name: {i.Item1}, price: {i.Item2}");
}
