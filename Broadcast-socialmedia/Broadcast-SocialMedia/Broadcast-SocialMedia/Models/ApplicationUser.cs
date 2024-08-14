using Microsoft.AspNetCore.Identity;

namespace Broadcast_SocialMedia.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public ICollection<BroadCast> BroadCasts { get; set; }
    }
}
