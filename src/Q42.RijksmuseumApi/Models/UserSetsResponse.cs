using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q42.RijksmuseumApi.Models
{

  public class User
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Lang { get; set; }
    public string AvatarUrl { get; set; }
    public string HeaderUrl { get; set; }
    public string Initials { get; set; }
  }

  public class UserSet
  {
    public Links Links { get; set; }
    public string Id { get; set; }
    public int Count { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public string Description { get; set; }
    public User User { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
  }

  /// <summary>
  /// Result from GetUserSets
  /// </summary>
  public class UserSetsResponse
  {
    /// <summary>
    /// Total number of results
    /// </summary>
    public int Count { get; set; }
    public int ElapsedMilliseconds { get; set; }
    public List<UserSet> UserSets { get; set; }
  }
}
