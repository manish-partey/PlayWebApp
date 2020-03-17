using BAL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DAL.Core
{
	public interface IDepartment
	{
		IEnumerable<Dept> GetAll();
	}

	public class GetDepartment : IDepartment
	{
	readonly	List<Dept> Depts;

		public GetDepartment()
		{
			Depts = new List<Dept>()
			{
				new Dept{DeptID=1, deptartment=Dept.Deptartment.Arts, DeptName="Arts", DeptHead="Manish"},
				new Dept{DeptID=2, deptartment=Dept.Deptartment.Commerce, DeptName="Commerce", DeptHead="Manish" },
				new Dept{DeptID=3, deptartment=Dept.Deptartment.HR, DeptName="HR", DeptHead="Manish"},
				new Dept{DeptID=4, deptartment=Dept.Deptartment.Maths, DeptName="Maths", DeptHead="Manish"},
				new Dept{DeptID=5, deptartment=Dept.Deptartment.Science, DeptName="Science", DeptHead="Manish"}
			};
		}
		public IEnumerable<Dept> GetAll()
		{
			return from d in Depts
				   orderby d.DeptID
				   select d;
		}
	}
}
