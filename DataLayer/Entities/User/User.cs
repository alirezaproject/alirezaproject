using System;
using Microsoft.AspNetCore.Identity;

namespace DataLayer.Entities.User
{
    
    public class User : IdentityUser<int>
    {
        public DateTime InsertTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? RemoveTime { get; set; }
        public bool IsRemoved { get; set; }
    }
}