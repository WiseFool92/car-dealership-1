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
    
    public static List<Dictionary<string, string>> CarList  = new List<Dictionary<string, string>> {};
    // public static Dictionary<string, string> TestCar = new Dictionary<string, string>() { {makeModel, "Volkswagen Thing"}, {year, "1974"}, {color, "Seafoam Green"}, {miles, "368792"}, {price, "1100"}};

    public Dictionary<string, string> CarInfo = new Dictionary<string, string>() {} ;

    public Cars(string year, string makeModel, string color, string miles, string price)
    {
      Year = year;
      MakeModel = makeModel;
      Color = color;
      Miles = miles;
      Price = price;
      CarInfo.Add("Year: ", year);
      CarInfo.Add("MakeModel: ", makeModel);
      CarInfo.Add("Color: ", color);
      CarInfo.Add("Miles: ", miles);
      CarInfo.Add("Price: ", price);
      CarList.Add(CarInfo);
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

    // public void GetValue()
    // {
    //   foreach (KeyValuePair<int, List<string>> list in tileValue)
    //   {
    //     foreach (string value in list.Value)
    //     {
    //       Console.WriteLine("Key = {0}, Value = {1}", list.Key, value);
          // psuedo code - writing out the next logic steps
          // if(value.Contains(Input))
          // {
          //   designate dictionary[list] containing input;
          //   totalScore += list Key;
          // }
      //   }
      // }
        // Console.WriteLine(totalScore);
    // }
  }
}