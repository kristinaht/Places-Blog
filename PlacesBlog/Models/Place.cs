using System;
using System.Collections.Generic;

namespace PlacesBlog.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public int Id { get; }
    private static List<Place> _allPlaces = new List<Place>{};

    public Place(string cityName)
    {
      CityName = cityName;
      _allPlaces.Add(this);
      Id = _allPlaces.Count;
    }

    public static List<Place> GetAll()
    {
      return _allPlaces;
    }

    public static void ClearAll()
    {
      _allPlaces.Clear();
    }

    public static Place Find(int searchId)
    {
      return _allPlaces[searchId - 1];
    }
  }
}