﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q42.RijksmuseumApi.Models
{
  public class OverviewLinks
  {
    public string Overview { get; set; }
    public string Web { get; set; }
  }

  public class ArtobjectLinks
  {
    public string artobject { get; set; }
    public string web { get; set; }
  }

  public class Image
  {
    public Guid guid { get; set; }
    public string parentObjectNumber { get; set; }
    public string cdnUrl { get; set; }
    public int cropX { get; set; }
    public int cropY { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public int offsetPercentageX { get; set; }
    public int offsetPercentageY { get; set; }
  }

  public class SetItem
  {
    public ArtobjectLinks links { get; set; }
    public Guid Id { get; set; }
    public string ObjectNumber { get; set; }
    public string Relation { get; set; }
    public string RelationDescription { get; set; }
    public bool Cropped { get; set; }
    public int CropX { get; set; }
    public int CropY { get; set; }
    public int CropWidth { get; set; }
    public int CropHeight { get; set; }
    public int OrigWidth { get; set; }
    public int OrigHeight { get; set; }
    public Image Image { get; set; }
  }

  public class UserSetDetail
  {
    public OverviewLinks Links { get; set; }
    public string Id { get; set; }
    public int Count { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public string Description { get; set; }
    public User User { get; set; }
    public List<SetItem> SetItems { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
  }

  public class UserSetDetailsResponse
  {
    public int ElapsedMilliseconds { get; set; }
    public UserSetDetail UserSet { get; set; }
  }
}