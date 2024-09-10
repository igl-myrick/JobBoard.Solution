using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobBoard.Models;
using System;
using System.Collections.Generic;

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

    [TestMethod]
    public void GetRequirements_GetsValueOfRequirements_List()
    {
      Listing newListing = new Listing();
      List<string> listingRequirements = new List<string> ();
      listingRequirements = newListing.Requirements;
      Assert.AreEqual(listingRequirements, newListing.Requirements);
    }

    [TestMethod]
    public void SetRequirements_SetsValueOfRequirements_List()
    {
      Listing newListing = new Listing();
      List<string> listingRequirements = new List<string> ();
      listingRequirements.Add("Job Requirement 1");
      listingRequirements.Add("Job Requirement 2");
      listingRequirements.Add("Job Requirement 3");
      newListing.Requirements = listingRequirements;
      Assert.AreEqual(listingRequirements, newListing.Requirements);
    }

    [TestMethod]
    public void GetContactInfo_GetsValueOfContactInfo_String()
    {
      Listing newListing = new Listing();
      string listingContactInfo = newListing.ContactInfo;
      Assert.AreEqual(listingContactInfo, newListing.ContactInfo);
    }

    [TestMethod]
    public void SetContactInfo_SetsValueOfContactInfo_String()
    {
      Listing newListing = new Listing();
      string listingContactInfo = "Contact name";
      newListing.ContactInfo = listingContactInfo;
      Assert.AreEqual(listingContactInfo, newListing.ContactInfo);
    }
  }
}