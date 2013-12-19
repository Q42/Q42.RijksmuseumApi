using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q42.RijksmuseumApi.Models
{
  public class Tile
  {
    public int X { get; set; }
    public int Y { get; set; }
    public string Url { get; set; }
  }

  public class Level
  {
    public string Name { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public List<Tile> Tiles { get; set; }
  }

  public class TilesResponse
  {
    public List<Level> Levels { get; set; }
  }
}
