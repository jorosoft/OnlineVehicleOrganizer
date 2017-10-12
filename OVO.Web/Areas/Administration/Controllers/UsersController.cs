using System.Linq;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using OVO.Services.Contracts;
using OVO.Web.Areas.Administration.ViewModels;

namespace OVO.Web.Areas.Administration.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService usersService;
        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public ActionResult Index()
        {
            var users = this.usersService
                .GetAllAndDeleted()
                .Select(x => new UserViewModel
                {
                    Username = x.UserName,
                    Email = x.Email,
                    IsDeleted = x.IsDeleted
                }
                )
                .ToList();

            var viewModel = new UsersListViewModel
            {
                Users = users
            };

            return this.View(viewModel);
        }
    }
}