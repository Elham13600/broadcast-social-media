using Broadcast_SocialMedia.Models;

namespace Broadcast_SocialMedia.ViewModels
{
	public class UsersShowUserViewModel
	{
        public ApplicationUser User { get; set; }
        public List<BroadCast> Broadcasts { get; set; }
    }
}
