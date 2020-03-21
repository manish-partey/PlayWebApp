using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BAL.Core
{
	public partial class Dept
	{
		public int DeptID { get; set; }
		[Required,StringLength(80)]
		public string  DeptName { get; set; }
		[Required, StringLength(80)]
		public string DeptHead { get; set; }
		public Deptartment deptartment { get; set; }
	}
}
