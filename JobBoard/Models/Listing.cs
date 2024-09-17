using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Listing
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Requirements { get; set; }
    public string ContactInfo { get; set; }

    private static List<Listing> _instances = new List<Listing> { };

    public Listing(string title, string description, string requirements, string contactInfo) {
      Title = title;
      Description = description;
      Requirements = requirements;
      ContactInfo = contactInfo;
      _instances.Add(this);
    }
    
    public static List<Listing> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}