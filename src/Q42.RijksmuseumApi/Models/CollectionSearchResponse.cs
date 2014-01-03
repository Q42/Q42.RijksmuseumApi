using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q42.RijksmuseumApi.Models
{


  public class RijksImage
  {
    public Guid Guid { get; set; }
    public int OffsetPercentageX { get; set; }
    public int OffsetPercentageY { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public string Url { get; set; }
  }

  /// <summary>
  /// Single Art Object
  /// </summary>
  public class ArtObject
  {
    public Dictionary<string, Uri> Links { get; set; }
    public string Id { get; set; }
    public string ObjectNumber { get; set; }
    public string Title { get; set; }
    public bool HasImage { get; set; }
    public string PrincipalOrFirstMaker { get; set; }
    public string LongTitle { get; set; }
    public bool ShowImage { get; set; }
    public bool PermitDownload { get; set; }
    public RijksImage WebImage { get; set; }
    public RijksImage HeaderImage { get; set; }
    public List<object> ProductionPlaces { get; set; }
  }

  /// <summary>
  /// Response from GetCollection
  /// </summary>
  public class CollectionSearchResponse
  {
    public int ElapsedMilliseconds { get; set; }

    /// <summary>
    /// Total results found
    /// </summary>
    public int Count { get; set; }

    public List<ArtObject> ArtObjects { get; set; }
  }
 
}
