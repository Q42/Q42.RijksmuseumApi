using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q42.RijksmuseumApi.Models
{
  
  public class Period
  {
    public Guid Id { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public int Current { get; set; }
    public int Maximum { get; set; }
    public int Remaining { get; set; }
    public string Code { get; set; }
    public string Text { get; set; }
  }

  public class Price
  {
    public string Id { get; set; }
    public int CalculationType { get; set; }
    public double Amount { get; set; }
  }

  public class Exposition
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Code { get; set; }
    public Price Price { get; set; }
  }

  public class GroupType
  {
    public string Type { get; set; }
    public Guid Guid { get; set; }
    public string FriendlyName { get; set; }
  }

  public class PageRef
  {
    public string Title { get; set; }
    public string Url { get; set; }
  }

  public class ExpositionType
  {
    public string Type { get; set; }
    public Guid Guid { get; set; }
    public string FriendlyName { get; set; }
  }

  public class Option
  {
    public Dictionary<string, Uri> Links { get; set; }
    public string Id { get; set; }
    public string Lang { get; set; }
    public string Date { get; set; }
    public Period Period { get; set; }
    public Exposition Exposition { get; set; }
    public GroupType GroupType { get; set; }
    public PageRef PageRef { get; set; }
    public ExpositionType ExpositionType { get; set; }
  }

  /// <summary>
  /// Response from GetCalendar
  /// </summary>
  public class CalendarResponse
  {
    public int ElapsedMilliseconds { get; set; }
    public List<Option> Options { get; set; }
  }
}
