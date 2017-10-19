using System;
using System.ComponentModel.DataAnnotations;

namespace OVO.Web.Attributes
{
    public class NotDateInPastAttribute : ValidationAttribute
    {
        public override bool IsValid(object date)
        {
            var passedDate = (DateTime)date;
            return passedDate >= DateTime.Now;
        }
    }
}