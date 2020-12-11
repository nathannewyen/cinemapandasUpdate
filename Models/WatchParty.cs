using System.ComponentModel.DataAnnotations;

namespace cinemapandas.Models
{
    public class WatchParty
    {
        [Key]
        public int WatchPartyId { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public User MovieGoer { get; set; }
        public Movie Feature { get; set; }
    }
}