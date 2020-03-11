using PlacesBlog.Models;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlacesBlog.Tests
{
  [TestClass]
  public class PlaceTests 
  {
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

      Assert.AreEqual(2, result);
    }
  }
}