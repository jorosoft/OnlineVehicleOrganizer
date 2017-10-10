using System.Collections.Generic;

namespace OVO.Web.Areas.Administration.ViewModels
{
    public class UsersListViewModel
    {
        public IEnumerable<UserViewModel> Users { get; set; }
    }
}