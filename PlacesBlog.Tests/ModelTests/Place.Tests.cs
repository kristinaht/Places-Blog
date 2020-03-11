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
  }
}