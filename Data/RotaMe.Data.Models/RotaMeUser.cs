﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RotaMe.Data.Models
{
    public class RotaMeUser : IdentityUser<string>
    {
        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        public string LastName { get; set; }

        //[Required]
        public Gender Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastLoggedIn { get; set; }

        public string Avatar { get; set; }

        public DateTime BirthDay { get; set; }


        public ICollection<Project> OwnProjects { get; set; } = new List<Project>();
        public ICollection<UserProject> Projects { get; set; } = new List<UserProject>();
        public ICollection<UserEvent> Events { get; set; } = new List<UserEvent>();
        public ICollection<Availability> Availabilities { get; set; } = new List<Availability>();

    }
}
