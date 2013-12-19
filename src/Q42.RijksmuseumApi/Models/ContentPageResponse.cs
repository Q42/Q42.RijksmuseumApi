using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q42.RijksmuseumApi.Models
{
  public class ThumbnailLandscape
  {
    public string Name { get; set; }
    public string Url { get; set; }
  }

  public class Body
  {
    public string Markdown { get; set; }
    public string Html { get; set; }
  }

  public class ContentPage
  {
    public ThumbnailLandscape thumbnailLandscape { get; set; }
    public bool InOverview { get; set; }
    public bool IsHighlightedOnOverview { get; set; }
    public string ArtistBio { get; set; }
    public Maker Maker { get; set; }
    public string Subject { get; set; }
    public string CallToAction { get; set; }
    public string CallToActionQuery { get; set; }
    public List<string> ArtObjectSet { get; set; }
    public List<object> MediaBlocks { get; set; }
    public List<string> Artobjects_on_this_page { get; set; }
    public string Id { get; set; }
    public Guid Guid { get; set; }
    public string Lang { get; set; }
    public bool CompactHeader { get; set; }
    public List<string> ShortcutKeywords { get; set; }
    public List<string> OtherLangs { get; set; }
    public string HeaderImage { get; set; }
    public string Thumbnail { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Body Body { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
  }

  public class ContentPageResponse
  {
    public int ElapsedMilliseconds { get; set; }
    public ContentPage ContentPage { get; set; }

    //TODO
    //public object SimilarPages { get; set; }
  }
}
