using System;

namespace FlowerShop
{
  class Program
  {
    static void Main(string[] args)
    {
      var Remi = new Rose()
      {
        Color = "pink"
      };

      var Archie = new Hydrangea()
      {
        Type = "Peony"
      };

      FlowerShop AwesumShop = new FlowerShop();
      var Arrangement = AwesumShop.MakeBirthdayArrangement();
    }
  }
}
