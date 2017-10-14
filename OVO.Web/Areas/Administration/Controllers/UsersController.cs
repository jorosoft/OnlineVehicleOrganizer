using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using OVO.Web.Areas.Administration.ViewModels;
using OVO.Services.Contracts;
using System.Web.Security;
using Microsoft.AspNet.Identity;

namespace OVO.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = "Admin")]
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

        public ActionResult Edit(string userEmail)
        {
            var roles = this.rolesService.GetAll()
                .ToDictionary(x => x.Id, x => x.Name);

            var user = this.usersService
                .GetAllAndDeleted()
                .SingleOrDefault(x => x.Email == userEmail);

            var viewModel = new UserViewModel
            {
                Email = user.Email,
                Role = roles[user.Roles.First().RoleId],
                Roles = roles
                    .Select(x => new RoleViewModel
                    {
                        Id = x.Key,
                        Name = x.Value
                    })
                    .ToList()
            };

            return this.View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserViewModel user)
        {
            if (!ModelState.IsValid)
            {
                return this.View(user);
            }

            var usr = this.usersService.GetAllAndDeleted()
                .SingleOrDefault(x => x.Email == user.Email);

            var oldRoleId = usr.Roles.First().RoleId;

            var oldRole = this.rolesService.GetAll()
                .First(x => x.Id == oldRoleId).Name;

            if (oldRole != user.Role)
            {                
                this.rolesService.UserManager.RemoveFromRole(usr.Id, oldRole);
                this.rolesService.UserManager.AddToRole(usr.Id, user.Role);
            }            

            return this.RedirectToAction("All", "Users");
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
                return this.View(user);
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
                return this.View(user);
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