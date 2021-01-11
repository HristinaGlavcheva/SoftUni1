﻿using System;

namespace Git.ViewModels.Repositories
{
    public class AllRepositoriesViewModel
    {
        public string Name { get; set; }

        public string Owner { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CommitsCount { get; set; }
    }
}
