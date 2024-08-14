using Broadcast_SocialMedia.Models;

namespace Broadcast_SocialMedia.ViewModels
{
    public class UsersIndexViewModel
    {
        public string Search { get; set; }
        public List<ApplicationUser> Result { get; set; } = new List<ApplicationUser>();
    }
}
