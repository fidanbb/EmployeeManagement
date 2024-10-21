﻿

namespace EmployeeManagement.Domain.Entities.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }= DateTime.UtcNow.AddHours(4);
    }
}
