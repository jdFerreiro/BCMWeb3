using System;

namespace BCMWeb.Core.DTOs
{
    public class UserDto
    {
        public long UserId { get; set; }
        public string UserCode { get; set; }
        public string UserPassw { get; set; }
        public string Name { get; set; }
        public short UserStateId { get; set; }
        public DateTime? UserStateDateChange { get; set; }
        public DateTime? LastConnectionDate { get; set; }
        public bool? FirstTime { get; set; }
        public string Email { get; set; }
    }
}
