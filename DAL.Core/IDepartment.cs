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
		IEnumerable<Dept> GetDeptByName(string strDept);

		Dept GetDeptByID(int strDeptID);
	}

	public class GetDepartment : IDepartment
	{
	readonly	List<Dept> Depts;

		public GetDepartment()
		{
			Depts = new List<Dept>()
			{
				new Dept{DeptID=1, deptartment=Deptartment.Arts, DeptName="Arts", DeptHead="Manish"},
				new Dept{DeptID=2, deptartment=Deptartment.Commerce, DeptName="Commerce", DeptHead="Ashish" },
				new Dept{DeptID=3, deptartment=Deptartment.HR, DeptName="HR", DeptHead="Girish"},
				new Dept{DeptID=4, deptartment=Deptartment.Maths, DeptName="Maths", DeptHead="Suraj"},
				new Dept{DeptID=5, deptartment=Deptartment.Science, DeptName="Science", DeptHead="Sonu"}
			};
		}
		public IEnumerable<Dept> GetAll()
		{
			return from d in Depts
				   orderby d.DeptID
				   select d;
		}

		public Dept GetDeptByID(int strDeptID)
		{
			return Depts.SingleOrDefault(r => r.DeptID == strDeptID);
		}

		public IEnumerable<Dept> GetDeptByName(string strDept = null)
		{
			return from d in Depts
				   where string.IsNullOrEmpty(strDept) || d.DeptName.StartsWith(strDept)
				   orderby d.DeptID
				   select d;
		}
	}
}
