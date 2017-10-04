using System;

namespace OVO.Data.Contracts
{
    public interface IDeletable
    {
        bool IsDeleted { get; set; }
    }
}
