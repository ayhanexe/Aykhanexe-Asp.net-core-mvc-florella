using asp.net_core_empty_task.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_empty_task.Areas.Admin.ViewModels
{
    public class AddRoleViewModel
    {
        public IdentityUser User { get; set; }
        public List<IdentityRole> Roles { get; set; }
    }
}
