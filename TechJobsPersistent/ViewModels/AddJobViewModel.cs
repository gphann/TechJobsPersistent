﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }
        public int EmployerId { get; set; }

        public List<int> SkillId { get; set; }

        public List<Skill> Skills { get; set; }

        public List<SelectListItem> Employers { get; set; }

        public AddJobViewModel(List<Employer> possibleEmployers, List<Skill> skills)
        {
            Employers = new List<SelectListItem>();

            foreach (var employer in possibleEmployers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = employer.Id.ToString(),
                    Text = employer.Name
                });
            }

            Skills = skills;
        }

        public AddJobViewModel()
        {
        }

    }
}
