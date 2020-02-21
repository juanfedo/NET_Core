using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices1.DataObjects
{
	public class oStudentGrade
	{
		public int EnrollmentID { get; set; }
		public int CourseID { get; set; }
		public int StudentID { get; set; }
		public decimal Grade { get; set; }

		public oStudentGrade(int EnrollmentID_, int CourseID_, int StudentID_, decimal Grade_)
		{
			this.EnrollmentID = EnrollmentID_;
			this.CourseID = CourseID_;
			this.StudentID = StudentID_;
			this.Grade = Grade_;
		}
	}
}
