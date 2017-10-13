using System;
using System.ComponentModel.DataAnnotations;

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
    }
}