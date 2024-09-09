using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobBoard.Models;
using System;

namespace JobBoard.Tests
{
  [TestClass]
  public class ListingTests
  {
    [TestMethod]
    public void ListingConstructor_CreatesInstanceOfListing_Listing()
    {
      Listing newListing = new Listing();
      Assert.AreEqual(typeof(Listing), newListing.GetType());
    }
  }
}