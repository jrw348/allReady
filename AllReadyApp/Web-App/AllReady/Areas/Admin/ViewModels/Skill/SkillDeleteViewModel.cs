﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AllReady.Areas.Admin.ViewModels.Skill
{
    public class SkillDeleteViewModel
    {
        public int SkillId { get; set; }

        [Display(Name = "Name")]
        public string HierarchicalName { get; set; }

        public int? OwningOrganizationId { get; set; }

        [Display(Name = "Children")]
        public IEnumerable<string> ChildrenNames { get; set; }

        public string Title { get; set; }

        public bool SkillBelongsToSameOrgAsOrgAdmin { get; set; }
    }
}