﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bugtracker.DataAccessLayer.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Task[] Tasks { get; set; }
        public User[] Users { get; set; }
    }
}
