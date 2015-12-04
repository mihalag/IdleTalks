using System;
using System.Collections.Generic;

namespace IdleTalks.Repository.DTO
{
    public class User
    {
        public long Id { get; set; } // Id (Primary key via unique index PK_User_id)
        public string FirstName { get; set; } // FirstName
        public string LastName { get; set; } // LastName
        public DateTime? BirthDay { get; set; } // BirthDay
        public string Password { get; set; } // Password
        public long? MoodId { get; set; } // MoodId

        public User()
        {

        }
    }
}