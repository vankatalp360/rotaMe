﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RotaMe.Sevices.Models.Owner.Projects
{
    public class ProjectCreateServiceModel
    {
        public string Title { get; set; }

        public string Slug { get; set; }

        public string OwnerId { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }
    }
}
