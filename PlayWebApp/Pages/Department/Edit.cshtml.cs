using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BAL.Core;
using DAL.Core;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PlayWebApp.Pages.Department
{
    public class EditModel : PageModel
    {
        private readonly IDepartment department1;
        private readonly IHtmlHelper htmlHelper;

        [BindProperty]
        public Dept department { get; set; }
        public IEnumerable<SelectListItem> deptList { get; set; }
        public EditModel(IDepartment department,
            IHtmlHelper htmlHelper)
        {
            department1 = department;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int strDeptID)
        {
            deptList = htmlHelper.GetEnumSelectList<Deptartment>();
               department = department1.GetDeptByID(strDeptID);
            if (department == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            deptList = htmlHelper.GetEnumSelectList<Deptartment>();
            department = department1.UpdateDept(department);
            return Page();
        }
    }
}