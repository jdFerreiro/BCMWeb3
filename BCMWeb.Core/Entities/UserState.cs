﻿using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class UserState : BaseEntity
    {
        public UserState()
        {
            UserStateCultures = new HashSet<UserSateCulture>();
            Users = new HashSet<User>();
        }

        public short UserStateId { get; set; }

        public virtual ICollection<UserSateCulture> UserStateCultures { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
