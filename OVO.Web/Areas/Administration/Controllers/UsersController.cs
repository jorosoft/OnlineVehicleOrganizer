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

        public ActionResult Delete(string userEmail)
        {
            var user = this.usersService
                .GetAllAndDeleted()
                .SingleOrDefault(x => x.Email == userEmail);

            var viewModel = new UserViewModel
            {
                Email = user.Email,
                IsDeleted = user.IsDeleted
            };

            return this.View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                // TODO
            }

            var usr = this.usersService
                .GetAllAndDeleted()
                .SingleOrDefault(x => x.Email == user.Email);

            this.usersService.Delete(usr);

            return this.RedirectToAction("All", "Users");
        }

        public ActionResult Undelete(string userEmail)
        {
            var user = this.usersService
                .GetAllAndDeleted()
                .SingleOrDefault(x => x.Email == userEmail);

            var viewModel = new UserViewModel
            {
                Email = user.Email,
                IsDeleted = user.IsDeleted
            };

            return this.View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Undelete(UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                // TODO
            }

            var usr = this.usersService
                .GetAllAndDeleted()
                .SingleOrDefault(x => x.Email == user.Email);

            usr.IsDeleted = false;

            this.usersService.Update(usr);

            return this.RedirectToAction("All", "Users");
        }
    }
}