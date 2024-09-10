using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Listing
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public List<string> Requirements { get; set; }
    public string ContactInfo { get; set; }
  }
}