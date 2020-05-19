using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Cars
  {
    public string Year { get; set; }
    public string MakeModel { get; set; }
    public string Color { get; set; }
    public string Miles { get; set; }
    public string Price { get; set; }
    
    private static Dictionary<string, List<string>> _carDictionary  = new Dictionary<string, List<string>> {};
    private static List<string> _carProperties = new List<string>();
    public Cars(string year, string makeModel, string color, string miles, string price)
    {
      Year = year;
      MakeModel = makeModel;
      Color = color;
      Miles = miles;
      Price = price;
      _carProperties.Add(Year);
      _carProperties.Add(MakeModel);
      _carProperties.Add(Color);
      _carProperties.Add(Miles);
      _carProperties.Add(Price);
      _carDictionary.Add(Year + " " + MakeModel, _carProperties);
    }
    // public static Dictionary<string, List<string>> GetAll()
    // {
    //   return _carDictionary;
    // }
    // public static void ClearAll()
    // {
    //   _carDictionary.Clear();
    // }
    // public bool WorthBuying(int maxPrice, int maxMile)
    // {
    //   return (Price < maxPrice && Miles < maxMile);
    // }
    // public Dictionary<int, List<string>> tileValue = new Dictionary<int, List<string>> 
    // {
    //   { 1, new List<string> {"a", "e", "i", "o", "u", "l", "n", "r", "s", "t"} }, 
    //   { 2, new List<string> {"d", "g"} }, 
    //   { 3, new List<string> {"b", "c", "m", "p"} }, 
    //   { 4, new List<string> {"f", "h", "v", "w", "y"} },  
    //   { 5, new List<string> {"k"} }, 
    //   { 8, new List<string> {"j", "x"} },
    //   { 10, new List<string> {"q", "z"} }  
    // };
  }
}