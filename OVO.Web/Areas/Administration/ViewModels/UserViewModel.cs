using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OVO.Web.Areas.Administration.ViewModels
{
    public class UserViewModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required")]
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