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

    [TestMethod]
    public void GetTitle_GetsValueOfTitle_String()
    {
      Listing newListing = new Listing();
      string listingTitle = newListing.Title;
      Assert.AreEqual(listingTitle, newListing.Title);
    }

    [TestMethod]
    public void SetTitle_SetsValueOfTitle_String()
    {
      Listing newListing = new Listing();
      string listingTitle = "Job Listing";
      newListing.Title = listingTitle;
      Assert.AreEqual(listingTitle, newListing.Title);
    }

    [TestMethod]
    public void GetDescription_GetsValueOfDescription_String()
    {
      Listing newListing = new Listing();
      string listingDescription = newListing.Description;
      Assert.AreEqual(listingDescription, newListing.Description);
    }

    [TestMethod]
    public void SetDescription_SetsValueOfDescription_String()
    {
      Listing newListing = new Listing();
      string listingDescription = "Job Description";
      newListing.Description = listingDescription;
      Assert.AreEqual(listingDescription, newListing.Description);
    }
  }
}