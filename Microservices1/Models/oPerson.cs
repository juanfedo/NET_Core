using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices1.DataObjects
{
    public class oPerson
    {
		public int PersonID { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public DateTime HireDate { get; set; }
		public DateTime EnrollmentDate { get; set; }
		public string Discriminator { get; set; }
	}
}
