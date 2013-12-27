using Q42.RijksmuseumApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q42.RijksmuseumApi.Interfaces
{
  /// <summary>
  ///  Client for interacting with the Rijksmuseum API
  /// </summary>
  public interface IRijksClient
  {
    /// <summary>
    ///  gives the full collection with brief information about each work. This results are split up in result pages
    /// </summary>
    /// <param name="search"></param>
    /// <param name="sort"></param>
    /// <param name="page"></param>
    /// <param name="pageSize"></param>
    /// <returns></returns>
    Task<CollectionSearchResponse> GetCollection(CollectionSearchRequest search, string sort = "relevance", int page = 0, int pageSize = 10);

    /// <summary>
    /// gives more details of a work. The object number can be found in the search results 
    /// </summary>
    /// <param name="objectNumber"></param>
    /// <returns></returns>
    Task<ObjectDetailsResponse> GetCollectionDetails(string objectNumber);

    /// <summary>
    /// gives all the information you can use to show the image split up in tiles. This is used to implement the zoom functionality on the Rijksmuseum website
    /// </summary>
    /// <param name="objectNumber"></param>
    /// <returns></returns>
    Task<TilesResponse> GetCollectionImages(string objectNumber);

    /// <summary>
    /// returns all public data of a content page as found on the website.
    /// </summary>
    /// <param name="slug"></param>
    /// <returns></returns>
    Task<ContentPageResponse> GetContentPage(string slug);

    /// <summary>
    /// shows the sets made by Rijksstudio users
    /// </summary>
    /// <param name="page"></param>
    /// <param name="pageSize"></param>
    /// <returns></returns>
    //Task<UserSetsResponse> GetUserSets(int page = 0, int pageSize = 10);

    /// <summary>
    /// gives more details of a set. You can find the id in the GetUserSets result
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    //Task<UserSetDetailsResponse> GetUserSetDetails(int id);

    /// <summary>
    /// shows all events for the given date
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    Task<CalendarResponse> GetCalendar(DateTime date);

    /// <summary>
    /// gives the availability details for a specific event. The ID's of the events are found in the result of GetCalendar
    /// </summary>
    /// <param name="date"></param>
    /// <param name="expositionId"></param>
    /// <param name="periodId"></param>
    /// <returns></returns>
    Task<EventAvailabilityResponse> GetEventAvailability(DateTime date, Guid expositionId, Guid periodId);

    /// <summary>
    /// Get object of the day
    /// </summary>
    /// <param name="alternative">alternative feed</param>
    /// <returns>ArtObject ID</returns>
    Task<string> GetObjectOfTheDay(bool alternative = false);
  }
}
