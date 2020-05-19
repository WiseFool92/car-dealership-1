using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Cars
  {
    public string Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public string Miles { get; set; }
    public string Price { get; set; }
    private static Dictionary<string, Cars> _carDictionary = new Dictionary<int, Cars>{ };
    // private static List<string>
    //dictionary[0] = key, value        year + makeModel, value
    public Cars(string year, string makeModel, string color, string miles, string price)
    {
      Year = year;
      MakeModel = makeModel;
      Color = color;
      Miles = miles;
      Price = price;
      _carList.Add(Color, Miles, Price);
      _carDictionary.Add(Year + " " + MakeModel, _carList);
    }
    // public static Dictionary<Cars> GetAll()
    // {
    //   return _carDictionary;
    // }
    public static void ClearAll()
    {
      _carDictionary.Clear();
    }
    public bool WorthBuying(int maxPrice, int maxMile)
    {
      return (Price < maxPrice && Miles < maxMile);
    }
    public Dictionary<int, List<string>> tileValue = new Dictionary<int, List<string>> 
    {
      { 1, new List<string> {"a", "e", "i", "o", "u", "l", "n", "r", "s", "t"} }, 
      { 2, new List<string> {"d", "g"} }, 
      { 3, new List<string> {"b", "c", "m", "p"} }, 
      { 4, new List<string> {"f", "h", "v", "w", "y"} },  
      { 5, new List<string> {"k"} }, 
      { 8, new List<string> {"j", "x"} },
      { 10, new List<string> {"q", "z"} }  
    };
  }
}