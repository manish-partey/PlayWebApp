using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Core;
using BAL.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace PlayWebApp.Pages.Department
{
    public class ListModel : PageModel
    {
        private readonly IDepartment department;

        public string strMessage { get; set; }
        public IConfiguration Config { get; }
        public IEnumerable<Dept> departments { get; set; }


        public ListModel(IConfiguration config, 
            IDepartment department)
        {
            Config = config;
            this.department = department;
        }

       
        public void OnGet()
        {
            strMessage = "Display message using property";
            strMessage = Config["Message"];
            departments = department.GetAll();
        }
    }
}