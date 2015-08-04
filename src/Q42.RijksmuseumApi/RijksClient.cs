using Newtonsoft.Json;
using Q42.RijksmuseumApi.Interfaces;
using Q42.RijksmuseumApi.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q42.RijksmuseumApi
{
  /// <summary>
  /// Client for interacting with the Rijksmuseum API
  /// https://www.rijksmuseum.nl/en/api
  /// http://rijksmuseum.github.io/
  /// http://rijksmuseum.github.io/demos/
  /// </summary>
  public class RijksClient : IRijksClient
  {
    private readonly string _apiKey;
    private readonly string _language;
    private readonly string _queryStringApiKeyFormat;

    private const string _format = "json";
    private const string _apiBase = "https://www.rijksmuseum.nl/api/";

    /// <summary>
    /// Initialize the RijksClient
    /// </summary>
    /// <param name="apiKey"></param>
    public RijksClient(string apiKey, string language = "en")
    {
      if (string.IsNullOrEmpty(apiKey))
        throw new ArgumentNullException(nameof(apiKey));

      _apiKey = apiKey;
      _language = language;

      _queryStringApiKeyFormat = string.Format("key={0}&format={1}", _apiKey, _format);
    }


    /// <summary>
    /// https://www.rijksmuseum.nl/api/nl/collection?key=fakekey&format=json
    /// </summary>
    /// <returns></returns>
    public async Task<CollectionSearchResponse> GetCollection(CollectionSearchRequest search, string sort = "relevance", int page = 0, int pageSize = 10)
    {
      if (search == null)
        throw new ArgumentNullException(nameof(search));

      //Create URL
      Uri uri = new Uri(string.Format("{0}{1}/collection?s={2}&p={3}&ps={4}&{5}&{6}", _apiBase, _language, sort, page, pageSize, _queryStringApiKeyFormat, search.ToString()));

      //Do HTTP Request
      HttpClient client = new HttpClient();
      string stringResult = await client.GetStringAsync(uri).ConfigureAwait(false);

      //Parse JSON
      var result = JsonConvert.DeserializeObject<CollectionSearchResponse>(stringResult);

      return result;
    }

    /// <summary>
    /// https://www.rijksmuseum.nl/api/nl/collection/sk-c-5?key=fakekey&format=json
    /// </summary>
    /// <param name="objectNumber"></param>
    /// <returns></returns>
    public async Task<ObjectDetailsResponse> GetCollectionDetails(string objectNumber)
    {
      if (string.IsNullOrEmpty(objectNumber))
        throw new ArgumentNullException(nameof(objectNumber));

      //Create URL
      Uri uri = new Uri(string.Format("{0}{1}/collection/{2}?{3}", _apiBase, _language, objectNumber, _queryStringApiKeyFormat));

      //Do HTTP Request
      HttpClient client = new HttpClient();
      string stringResult = await client.GetStringAsync(uri).ConfigureAwait(false);

      //Parse JSON
      var result = JsonConvert.DeserializeObject<ObjectDetailsResponse>(stringResult);

      return result;
    }

    /// <summary>
    /// https://rijksmuseum.nl/api/nl/collection/SK-C-5/tiles?key=fakekey&format=json
    /// </summary>
    /// <param name="objectNumber"></param>
    /// <returns></returns>
    public async Task<TilesResponse> GetCollectionImages(string objectNumber)
    {
      if (string.IsNullOrEmpty(objectNumber))
        throw new ArgumentNullException(nameof(objectNumber));

      //Create URL
      Uri uri = new Uri(string.Format("{0}{1}/collection/{2}/tiles?{3}", _apiBase, _language, objectNumber, _queryStringApiKeyFormat));

      //Do HTTP Request
      HttpClient client = new HttpClient();
      string stringResult = await client.GetStringAsync(uri).ConfigureAwait(false);

      //Parse JSON
      var result = JsonConvert.DeserializeObject<TilesResponse>(stringResult);

      return result;
    }

    /// <summary>
    /// https://www.rijksmuseum.nl/api/pages/nl/ontdek-de-collectie/overzicht/rembrandt-harmensz-van-rijn?key=fakekey&format=json
    /// </summary>
    /// <param name="slug"></param>
    /// <returns></returns>
    public async Task<ContentPageResponse> GetContentPage(string slug)
    {
      if (string.IsNullOrEmpty(slug))
        throw new ArgumentNullException(nameof(slug));

      //Create URL
      Uri uri = new Uri(string.Format("{0}pages/{1}/{2}?{3}", _apiBase, _language, slug, _queryStringApiKeyFormat));

      //Do HTTP Request
      HttpClient client = new HttpClient();
      string stringResult = await client.GetStringAsync(uri).ConfigureAwait(false);

      //Parse JSON
      var result = JsonConvert.DeserializeObject<ContentPageResponse>(stringResult);

      return result;
    }
    
    /// <summary>
    /// https://www.rijksmuseum.nl/api/nl/usersets?key=fakekey&format=json&page=2
    /// </summary>
    /// <param name="page"></param>
    /// <param name="pageSize"></param>
    /// <returns></returns>
    public async Task<UserSetsResponse> GetUserSets(int page = 0, int pageSize = 10)
    {
      //Create URL
      Uri uri = new Uri(string.Format("{0}{1}/usersets?page={2}&pageSize={3}&{4}", _apiBase, _language, page, pageSize, _queryStringApiKeyFormat));

      //Do HTTP Request
      HttpClient client = new HttpClient();
      string stringResult = await client.GetStringAsync(uri).ConfigureAwait(false);

      //Parse JSON
      var result = JsonConvert.DeserializeObject<UserSetsResponse>(stringResult);

      return result;
    }

    /// <summary>
    /// https://www.rijksmuseum.nl/api/nl/usersets/123-setname-3?key=fakekey&format=json
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<UserSetDetailsResponse> GetUserSetDetails(string id)
    {
      if (string.IsNullOrEmpty(id))
        throw new ArgumentOutOfRangeException(nameof(id));
      
      //Create URL
      Uri uri = new Uri(string.Format("{0}{1}/usersets/{2}?{3}", _apiBase, _language, id, _queryStringApiKeyFormat));

      //Do HTTP Request
      HttpClient client = new HttpClient();
      string stringResult = await client.GetStringAsync(uri).ConfigureAwait(false);

      //Parse JSON
      var result = JsonConvert.DeserializeObject<UserSetDetailsResponse>(stringResult);

      return result;
    }

    /// <summary>
    /// https://www.rijksmuseum.nl/api/nl/agenda/2013-10-18?key=fakekey&format=json
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public async Task<CalendarResponse> GetCalendar(DateTime date)
    {
      //Create URL
      Uri uri = new Uri(string.Format("{0}{1}/agenda/{2}?{3}", _apiBase, _language, date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), _queryStringApiKeyFormat));

      //Do HTTP Request
      HttpClient client = new HttpClient();
      string stringResult = await client.GetStringAsync(uri).ConfigureAwait(false);

      //Parse JSON
      var result = JsonConvert.DeserializeObject<CalendarResponse>(stringResult);

      return result;
    }

    /// <summary>
    /// https://www.rijksmuseum.nl/api/nl/agenda/2013-10-18/expostition/0ee170d3-9604-48ac-b15f-014d911bf065/availability/e2b108b3-52b0-4a89-ac64-19514f8c5434?key=fakekey&format=json
    /// </summary>
    /// <param name="date"></param>
    /// <param name="expositionId"></param>
    /// <param name="periodId"></param>
    /// <returns></returns>
    public async Task<EventAvailabilityResponse> GetEventAvailability(DateTime date, Guid expositionId, Guid periodId)
    {
      //TODO: Nog testen

      //Create URL
      Uri uri = new Uri(string.Format("{0}{1}/agenda/{2}/exposition/{3}/availability/{4}?{5}", _apiBase, _language, date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture), expositionId, periodId, _queryStringApiKeyFormat));
      
      //Do HTTP Request
      HttpClient client = new HttpClient();
      string stringResult = await client.GetStringAsync(uri).ConfigureAwait(false);

      //Parse JSON
      var result = JsonConvert.DeserializeObject<EventAvailabilityResponse>(stringResult);

      return result;
    }

  }
}
