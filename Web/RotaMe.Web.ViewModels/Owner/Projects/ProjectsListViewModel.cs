﻿using RotaMe.Web.ViewModels.Owner.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace RotaMe.Web.ViewModels.Owner.Projects
{
    public class ProjectsListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Slug { get; set; }


        public string Description { get; set; }

        public string Image { get; set; }

        public int UsersCount { get; set; }

        public IList<ProjectsUsersListViewModel> Users { get; set; }

        public string EvenOdd { get; set; }
    }
}
