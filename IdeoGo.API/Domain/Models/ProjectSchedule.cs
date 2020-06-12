﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace IdeoGo.API.Domain.Models
{
    public class ProjectSchedule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public IList<MTask> Tasks { get; set; } = new List<MTask>();

        public IList<Activity> Activities { get; set; } = new List<Activity>();


    }
}
