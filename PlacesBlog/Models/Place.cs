using System;
using System.Collections.Generic;

namespace PlacesBlog.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public int Id { get; }
    private List<Place> _allPlaces = new List<Place>{};

    public Place(string cityName)
    {
      CityName = cityName;
      _allPlaces.Add(this);
      Id = _allPlaces.Count;
    }
  }
}