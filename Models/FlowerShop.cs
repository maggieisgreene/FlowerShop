using System.Collections.Generic;

namespace FlowerShop
{
  public class FlowerShop
  {
    public List<Rose> Roses = new List<Rose>();
    public List<Daisy> Daisies = new List<Daisy>();
    public List<Hydrangea> Hydrangeas = new List<Hydrangea>();
    public List<Peony> Peonies = new List<Peony>();

    public List<IMothersDay> MakeMothersDayArrangement()
    {
      List<IMothersDay> Arrangement = new List<IMothersDay>();
      Arrangement.Add(new Peony());
      Arrangement.Add(new Hydrangea());
      Arrangement.Add(new Hydrangea());
      Arrangement.Add(new Peony());
      Arrangement.Add(new Peony());

      return Arrangement;
    }

    public List<IBirthday> MakeBirthdayArrangement()
    {
      List<IBirthday> Arrangement = new List<IBirthday>();
      Arrangement.Add(new Rose());
      Arrangement.Add(new Daisy());
      Arrangement.Add(new Daisy());
      Arrangement.Add(new Rose());

      return Arrangement;
    }

    public List<IGetWell> MakeGetWellArrangement()
    {
      List<IGetWell> Arrangement = new List<IGetWell>();
      Arrangement.Add(new Orchid());
      Arrangement.Add(new Orchid());

      return Arrangement;
    }
  }
}