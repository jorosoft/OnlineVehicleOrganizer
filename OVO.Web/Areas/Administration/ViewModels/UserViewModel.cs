using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using OVO.Web.Areas.Administration.Controllers;

namespace OVO.Web.Areas.Administration.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }

        public bool IsDeleted { get; set; }

        [DataType(dataType: DataType.DateTime)]
        public DateTime? DeletedOn { get; set; }

        [DataType(dataType: DataType.DateTime)]
        public DateTime? CreatedOn { get; set; }

        [DataType(dataType: DataType.DateTime)]
        public DateTime? ModifiedOn { get; set; }

        public IEnumerable<RoleViewModel> Roles { get; set; }
    }
}