using System;

namespace FlowerShop
{
  public class Daisy : IBirthday
  {
    public string Color { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string Cost { get; set; }
    public string WaterNeeded { get; set; }
    public string Thorny { get; set; }
    public string Fragrant { get; set; }
  }
}