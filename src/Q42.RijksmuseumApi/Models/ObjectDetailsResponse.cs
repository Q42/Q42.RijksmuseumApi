using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q42.RijksmuseumApi.Models
{
 
  public class ColorsWithNormalization
  {
    public string OriginalHex { get; set; }
    public string NormalizedHex { get; set; }
  }

  public class Maker
  {
    public string Name { get; set; }
    public string UnFixedName { get; set; }
    public string PlaceOfBirth { get; set; }
    public string DateOfBirth { get; set; }
    public object DateOfBirthPrecision { get; set; }
    public string DateOfDeath { get; set; }
    public object DateOfDeathPrecision { get; set; }
    public string PlaceOfDeath { get; set; }
    public List<string> Occupation { get; set; }
    public List<string> Roles { get; set; }
    public string Nationality { get; set; }
    public object Biography { get; set; }
    public List<object> ProductionPlaces { get; set; }
    public List<object> SchoolStyles { get; set; }
    public object Qualification { get; set; }
  }

  public class Acquisition
  {
    public string Method { get; set; }
    public string Date { get; set; }
    public string CreditLine { get; set; }
  }

  public class Dating
  {
    public object Early { get; set; }
    public object EarlyPrecision { get; set; }
    public object Late { get; set; }
    public object LatePrecision { get; set; }
    public int Year { get; set; }
    public int YearEarly { get; set; }
    public int YearLate { get; set; }
    public int Period { get; set; }
  }

  public class Classification
  {
    public List<string> IconClassIdentifier { get; set; }
    public List<object> Motifs { get; set; }
    public List<object> Events { get; set; }
    public List<object> Periods { get; set; }
    public List<string> Places { get; set; }
    public List<object> People { get; set; }
  }

  public class Dimension
  {
    public string Unit { get; set; }
    public string Type { get; set; }
    public object Part { get; set; }
    public string Value { get; set; }
  }

  public class Label
  {
    public string Title { get; set; }
    public string MakerLine { get; set; }
    public object Description { get; set; }
    public object Notes { get; set; }
    public string Date { get; set; }
  }

  public class ArtObjectDetails
  {
    public Links Links { get; set; }
    public string Id { get; set; }
    public string Priref { get; set; }
    public string ObjectNumber { get; set; }
    public string Language { get; set; }
    public string Title { get; set; }
    public object CopyrightHolder { get; set; }
    public RijksImage WebImage { get; set; }
    public List<string> Colors { get; set; }
    public List<ColorsWithNormalization> ColorsWithNormalization { get; set; }
    public List<string> NormalizedColors { get; set; }
    public List<string> Normalized32Colors { get; set; }
    public List<string> Titles { get; set; }
    public string Description { get; set; }
    public object LabelText { get; set; }
    public List<string> ObjectTypes { get; set; }
    public List<string> ObjectCollection { get; set; }
    public List<Maker> Makers { get; set; }
    public List<Maker> PrincipalMakers { get; set; }
    public string PlaqueDescriptionDutch { get; set; }
    public object PlaqueDescriptionEnglish { get; set; }
    public string PrincipalMaker { get; set; }
    public object ArtistRole { get; set; }
    public List<object> Associations { get; set; }
    public Acquisition Acquisition { get; set; }
    public List<object> Exhibitions { get; set; }
    public List<string> Materials { get; set; }
    public List<object> Techniques { get; set; }
    public List<object> ProductionPlaces { get; set; }
    public Dating Dating { get; set; }
    public Classification Classification { get; set; }
    public bool HasImage { get; set; }
    public List<string> HistoricalPersons { get; set; }
    public List<string> Inscriptions { get; set; }
    public List<object> Documentation { get; set; }
    public List<object> CatRefRPK { get; set; }
    public string PrincipalOrFirstMaker { get; set; }
    public List<Dimension> Dimensions { get; set; }
    public List<object> PhysicalProperties { get; set; }
    public string PhysicalMedium { get; set; }
    public string LongTitle { get; set; }
    public string SubTitle { get; set; }
    public string ScLabelLine { get; set; }
    public Label Label { get; set; }
    public bool ShowImage { get; set; }
  }

  public class AdlibOverrides
  {
    public object Titel { get; set; }
    public object Maker { get; set; }
    public object EtiketText { get; set; }
  }

  public class ArtObjectPage
  {
    public string Id { get; set; }
    public List<object> SimilarPages { get; set; }
    public string Lang { get; set; }
    public string ObjectNumber { get; set; }
    public List<object> Tags { get; set; }
    public object PlaqueDescription { get; set; }
    public object AudioFile1 { get; set; }
    public object AudioFileLabel1 { get; set; }
    public object AudioFileLabel2 { get; set; }
    public string CreatedOn { get; set; }
    public string UpdatedOn { get; set; }
    public AdlibOverrides AdlibOverrides { get; set; }
  }

  public class ObjectDetailsResponse
  {
    public int ElapsedMilliseconds { get; set; }
    public ArtObjectDetails ArtObject { get; set; }
    public ArtObjectPage ArtObjectPage { get; set; }
  }
 
}
