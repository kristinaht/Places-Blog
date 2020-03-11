using PlacesBlog.Models;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PlacesBlog.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {

    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void Constructor_CheckIfConstructorCreatesInstanceOfObject_Place()
    {
      Place newPlace = new Place("Belgrade");
      
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetId_PlacesInstantiatedWithCorrectId_Id()
    {
      string testCity = "Punta Del Este";
      Place newPlace = new Place(testCity);

      int result = newPlace.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_List()
    {
      List<Place> newList = new List<Place>{};
      
      List<Place> result = Place.GetAll();

      CollectionAssert.AreEqual(result, newList);
    }
  }
}