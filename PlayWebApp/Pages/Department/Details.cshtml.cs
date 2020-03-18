using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAL.Core;
using DAL.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PlayWebApp.Pages.Department
{
    public class DetailsModel : PageModel
    {
        private readonly IDepartment department;

        public Dept Dept { get; set; }
        public DetailsModel(IDepartment department)
        {
            this.department = department;
        }
        public IActionResult OnGet(int strDeptID)
        {

            Dept = department.GetDeptByID(strDeptID);
            if (Dept == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}