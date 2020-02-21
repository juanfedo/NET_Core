using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices1.DataObjects
{
	public class oCourse
	{
		public int CourseID { get; set; }
		public string Title { get; set; }
		public int Credits { get; set; }
		public int DepartmentID { get; set; }
	}
}
