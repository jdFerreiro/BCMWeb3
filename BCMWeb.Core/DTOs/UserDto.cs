using System;

namespace BCMWeb.Core.DTOs
{
    public class UserDto
    {
        /// <summary>
        /// Autoincremental user identifier
        /// </summary>
        public long UserId { get; set; }
        /// <summary>
        /// User access code
        /// </summary>
        public string UserCode { get; set; }
        /// <summary>
        /// User access password
        /// </summary>
        public string UserPassw { get; set; }
        /// <summary>
        /// User name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// User state identifier
        /// </summary>
        public short UserStateId { get; set; }
        /// <summary>
        /// User state last date
        /// </summary>
        public DateTime? UserStateDateChange { get; set; }
        /// <summary>
        /// Last user connection date
        /// </summary>
        public DateTime? LastConnectionDate { get; set; }
        /// <summary>
        /// Is First Time user connection indicator
        /// </summary>
        public bool? FirstTime { get; set; }
        /// <summary>
        /// User email
        /// </summary>
        public string Email { get; set; }
    }
}
