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
      Parcel newParcel = new Parcel();
      Assert.AreEqual(typeof(Parcel), newParcel.GetType());
    }

    [TestMethod]
    public void GetProperties_ReturnsProperties_Double()
    {
      Parcel newParcel = new Parcel(5, 3, 6, 9);
      string weight = newParcel.Weight;
      string length = newParcel.Length;
      string width = newParcel.Width;
      string height = newParcel.Height;

      Assert.AreEqual(5, weight);
      Assert.AreEqual(3, weight);
      Assert.AreEqual(6, weight);
      Assert.AreEqual(9, weight);

    }


  }
}