using System;
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
        private readonly IRolesService rolesService;

        public UsersController(IUsersService usersService, IRolesService rolesService)
        {
            this.usersService = usersService;
            this.rolesService = rolesService;
        }

        public ActionResult All()
        {
            var roles = this.rolesService.GetAll()
                .ToDictionary(x => x.Id, x => x.Name);

            var users = this.usersService
                .GetAllAndDeleted()
                .ToList()
                .Select(x => new UserViewModel
                {
                    Username = x.UserName,
                    Email = x.Email,
                    Role = roles[x.Roles.First().RoleId],
                    IsDeleted = x.IsDeleted,
                    DeletedOn = x.DeletedOn,
                    CreatedOn = x.CreatedOn,
                    ModifiedOn = x.ModifiedOn
                })
                .ToList();

            var viewModel = new UsersListViewModel
            {
                Users = users
            };

            return this.View(viewModel);
        }
    }
}