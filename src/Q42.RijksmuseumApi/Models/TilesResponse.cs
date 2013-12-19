using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q42.RijksmuseumApi.Models
{
  /// <summary>
  /// Single tile
  /// </summary>
  public class Tile
  {
    /// <summary>X Position</summary>
    public int X { get; set; }
    
    /// <summary>Y Position</summary>
    public int Y { get; set; }
    
    /// <summary>Image url</summary>
    public Uri Url { get; set; }
  }

  /// <summary>
  /// The Zoom Level
  /// </summary>
  public class Level
  {
    public string Name { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public List<Tile> Tiles { get; set; }
  }

  /// <summary>
  /// Result from GetCollectionImages
  /// </summary>
  public class TilesResponse
  {
    /// <summary>
    /// Multiple zoom levels available
    /// </summary>
    public List<Level> Levels { get; set; }
  }
}
