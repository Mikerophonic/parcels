using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcels.Models;
using System;

namespace Parcels.Tests
{
  [TestClass]
  public class ParcelTests
  {
    [TestMethod]
    public void ParcelConstructor_CreatesInstanceOfParcel_Parcel()
    {
      Parcel newParcel = new Parcel(5, 3, 6, 9);
      Assert.AreEqual(typeof(Parcel), newParcel.GetType());
    }

    [TestMethod]
    public void GetProperties_ReturnsProperties_Double()
    {
      Parcel newParcel = new Parcel(5, 3, 6, 9);
      double weight = newParcel.Weight;
      double length = newParcel.Length;
      double width = newParcel.Width;
      double height = newParcel.Height;

      Assert.AreEqual(5, weight);
      Assert.AreEqual(3, length);
      Assert.AreEqual(6, width);
      Assert.AreEqual(9, height);

    }


  }
}