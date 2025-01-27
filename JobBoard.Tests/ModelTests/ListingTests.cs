using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobBoard.Models;
using System;
using System.Collections.Generic;

namespace JobBoard.Tests
{
  [TestClass]
  public class ListingTests : IDisposable
  {

    public void Dispose()
    {
      Listing.ClearAll();
    }

    [TestMethod]
    public void ListingConstructor_CreatesInstanceOfListing_Listing()
    {
      Listing newListing = new Listing("title", "description", "requirements", "contact info");
      Assert.AreEqual(typeof(Listing), newListing.GetType());
    }

    [TestMethod]
    public void GetTitle_GetsValueOfTitle_String()
    {
      string listingTitle = "title";
      Listing newListing = new Listing("title", "description", "requirements", "contact info");
      Assert.AreEqual(listingTitle, newListing.Title);
    }

    [TestMethod]
    public void SetTitle_SetsValueOfTitle_String()
    {
      string listingTitle = "title";
      Listing newListing = new Listing(listingTitle, "description", "requirements", "contact info");
      string newTitle = "updated title";
      newListing.Title = newTitle;
      string result = newListing.Title;
      Assert.AreEqual(newTitle, result);
    }

    [TestMethod]
    public void GetDescription_GetsValueOfDescription_String()
    {
      string listingDescription = "description";
      Listing newListing = new Listing("title", "description", "requirements", "contact info");
      Assert.AreEqual(listingDescription, newListing.Description);
    }

    [TestMethod]
    public void SetDescription_SetsValueOfDescription_String()
    {
      string listingDescription = "description";
      Listing newListing = new Listing("title", listingDescription, "requirements", "contact info");
      string newDescription = "updated description";
      newListing.Description = newDescription;
      string result = newListing.Description;
      Assert.AreEqual(newDescription, result);
    }

    [TestMethod]
    public void GetRequirements_GetsValueOfRequirements_String()
    {
      string listingRequirements = "requirement";
      Listing newListing = new Listing("title", "description", "requirement", "contact info");
      Assert.AreEqual(listingRequirements, newListing.Requirements);
    }

    [TestMethod]
    public void SetRequirements_SetsValueOfRequirements_String()
    {
      string listingRequirements = "requirement";
      Listing newListing = new Listing("title", "description", listingRequirements, "contact info");
      string newRequirements = "updated requirement";
      newListing.Requirements = newRequirements;
      string result = newListing.Requirements;
      Assert.AreEqual(newRequirements, result);
    }

    [TestMethod]
    public void GetContactInfo_GetsValueOfContactInfo_String()
    {
      string listingContactInfo = "contact info";
      Listing newListing = new Listing("title", "description", "requirements", "contact info");
      Assert.AreEqual(listingContactInfo, newListing.ContactInfo);
    }

    [TestMethod]
    public void SetContactInfo_SetsValueOfContactInfo_String()
    {
      string listingContactInfo = "contact info";
      Listing newListing = new Listing("title", "description", "requirements", listingContactInfo);
      string newContactInfo = "updated contact info";
      newListing.ContactInfo = newContactInfo;
      string result = newListing.ContactInfo;
      Assert.AreEqual(newContactInfo, result);
    }

    [TestMethod]
    public void GetAll_ReturnsListings_List()
    {
      Listing newListing1 = new Listing("title 1", "description 1", "requirements 1", "contact info 1");
      Listing newListing2 = new Listing("title 2", "description 2", "requirements 2", "contact info 2");
      List<Listing> newList = new List<Listing> { newListing1, newListing2 };

      List<Listing> result = Listing.GetAll();
      
      CollectionAssert.AreEqual(newList, result);
    }
  }
}