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
    Task<CollectionSearchResponse> GetCollection(CollectionSearchRequest search, string sort = "relevance", int page = 0, int pageSize = 10);

    Task<ObjectDetailsResponse> GetCollectionDetails(string objectNumber);

    Task<TilesResponse> GetCollectionImages(string objectNumber);

    Task<ContentPageResponse> GetContentPage(string slug);

    Task<UserSetsResponse> GetUserSets(int page = 0, int pageSize = 10);

    Task<UserSetDetailsResponse> GetUserSetDetails(int id);

    Task<CalendarResponse> GetCalendar(DateTime date);

    Task<EventAvailabilityResponse> GetEventAvailability(DateTime date, Guid expositionId, Guid periodId);
    
    
  }
}
