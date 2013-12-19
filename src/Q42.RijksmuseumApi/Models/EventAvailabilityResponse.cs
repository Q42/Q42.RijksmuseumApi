using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q42.RijksmuseumApi.Models
{
  public class EventAvailabilityResponse
  {
    public int ElapsedMilliseconds { get; set; }
    public int Total { get; set; }
    public int Available { get; set; }
  }
}
