using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Core
{
	public partial class Dept
	{
		public int DeptID { get; set; }
		public string  DeptName { get; set; }
		public string DeptHead { get; set; }
		public Deptartment deptartment { get; set; }
	}
}
