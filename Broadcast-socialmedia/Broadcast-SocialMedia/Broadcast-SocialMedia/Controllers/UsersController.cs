using Broadcast_SocialMedia.Data;
using Broadcast_SocialMedia.Models;
using Broadcast_SocialMedia.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Broadcast_SocialMedia.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
		private readonly UserManager<ApplicationUser> _userManager;

        public UsersController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            userManager = userManager;
        }
        public async Task<IActionResult> Index(UsersIndexViewModel viewModel)
        {

            if(viewModel.Search != null)
            {
               var users = await _dbContext.Users.Where(u => u.Name.Contains(viewModel.Search))
                .ToListAsync();
                viewModel.Result = users;
            }

            return View(viewModel);
        }

        [Route("/Users/{id}")]
        public async Task<IActionResult> ShowUser(string id)
        {
            var broadcasts = await _dbContext.BroadCasts.Where(b => b.User.Id == id).ToListAsync();
            var user = await _userManager.GetUserAsync(User);

		var viewModel = new UsersShowUserViewModel()
            {
                Broadcasts = broadcasts,
                User = user
            };

            return View(viewModel);
        }
    }
}
