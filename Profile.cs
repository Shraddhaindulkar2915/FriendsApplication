using System.ComponentModel.DataAnnotations;
namespace FriendApp.Models
{
    public class Profile
    {
        public List<Friendsnames> friendsListing { get; set; }
    }

    public class Friendsnames
    {
        public string name { get; set; }
        public string id { get; set; }
    }
}

