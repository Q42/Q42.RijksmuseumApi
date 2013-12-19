using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q42.RijksmuseumApi.Models
{
  /// <summary>
  /// Used to search the collection
  /// </summary>
  public class CollectionSearchRequest
  {
    /// <summary>
    /// The search terms that need to occur in one of the fields of the artwork data 
    /// </summary>
    public string SearchQuery { get; set; } //q

    /// <summary>
    /// Works need to be made by this artist.
    /// </summary>
    public string Maker { get; set; }

    /// <summary>
    /// The type of the art work.
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// The material of the art work
    /// </summary>
    public string Material { get; set; }

    /// <summary>
    /// The technique used to make the works
    /// </summary>
    public string Technique { get; set; }

    /// <summary>
    /// The century in which the work is made 
    /// 0-21
    /// </summary>
    public int? DatingPeriod { get; set; } //f.dating.period

    /// <summary>
    /// Colors found in the images (mind: The `#` in #FF0000 should be url-encoded!)
    /// </summary>
    public string HexColor { get; set; } //f.normalized32Colors.hex

    /// <summary>
    /// Only give resuls for which an image is available or not
    /// </summary>
    public bool? ImageOnly { get; set; } //imgonly

    /// <summary>
    /// Only give works that are top pieces
    /// </summary>
    public bool? TopPiecesOnly { get; set; } //toppieces

    /// <summary>
    /// Generates querystring
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();

      if (!string.IsNullOrEmpty(SearchQuery))
        sb.AppendFormat("q={0}&", SearchQuery);

      if (!string.IsNullOrEmpty(Maker))
        sb.AppendFormat("maker={0}&", Maker);

      if (!string.IsNullOrEmpty(Type))
        sb.AppendFormat("type={0}&", Type);

      if (!string.IsNullOrEmpty(Material))
        sb.AppendFormat("material={0}&", Material);

      if (!string.IsNullOrEmpty(Technique))
        sb.AppendFormat("technique={0}&", Technique);

      if (DatingPeriod.HasValue)
        sb.AppendFormat("f.dating.period={0}&", DatingPeriod.Value);

      if (!string.IsNullOrEmpty(HexColor))
        sb.AppendFormat("f.normalized32Colors.hex={0}&", HexColor);

      if (ImageOnly.HasValue)
      {
        if(ImageOnly.Value)
          sb.Append("imgonly=True&");
        else
          sb.Append("imgonly=False&");

      }

      if (TopPiecesOnly.HasValue)
      {
        if (TopPiecesOnly.Value)
          sb.Append("toppieces=True&");
        else
          sb.Append("toppieces=False&");

      }

      //Remove last &
      string result = sb.ToString().TrimEnd(new List<char>() { '&' }.ToArray());

      return result;

    }



  }
}
