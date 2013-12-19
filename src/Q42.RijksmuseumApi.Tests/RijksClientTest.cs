using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q42.RijksmuseumApi.Interfaces;
using System.Configuration;
using System.Threading.Tasks;
using Q42.RijksmuseumApi.Models;

namespace Q42.RijksmuseumApi.Tests
{
  [TestClass]
  public class BaseTest
  {
    private IRijksClient _client;

    [TestInitialize]
    public void Initialize()
    {
      string apiKey = ConfigurationManager.AppSettings["apiKey"].ToString();

      _client = new RijksClient(apiKey);
    }

    [TestMethod]
    public async Task GetCollectionTest()
    {
      CollectionSearchRequest search = new CollectionSearchRequest();
      search.SearchQuery = "sinterklaas";

      var result = await _client.GetCollection(search);

      Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task GetCollectionDetailsTest()
    {
      var result = await _client.GetCollectionDetails("sk-c-5");

      Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task GetCollectionImagesTest()
    {
      var result = await _client.GetCollectionImages("sk-c-5");

      Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task GetContentPageTest()
    {
      var result = await _client.GetContentPage("explore-the-collection");

      Assert.IsNotNull(result);
    }

    //[TestMethod]
    //public async Task GetUserSetsTest()
    //{
    //  var result = await _client.GetUserSets();

    //  Assert.IsNotNull(result);
    //}

    //[TestMethod]
    //public async Task GetUserSetDetailsTest()
    //{
    //  var result = await _client.GetUserSetDetails(1);

    //  Assert.IsNotNull(result);
    //}

    [TestMethod]
    public async Task GetCalendarTest()
    {
      var result = await _client.GetCalendar(DateTime.Now.AddDays(1));

      Assert.IsNotNull(result);
    }

    [TestMethod]
    public async Task GetEventAvailabilityTest()
    {
      DateTime date = DateTime.Now.AddDays(1);

      var calendar = await _client.GetCalendar(date);

      var expositionId = calendar.Options.First().Exposition.Id;
      var periodId = calendar.Options.First().Period.Id;

      var result = await _client.GetEventAvailability(date, expositionId, periodId);

      Assert.IsNotNull(result);
    }
  }
}
