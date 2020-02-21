using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices1.DataObjects
{
    public interface IElement
    {
        public string Save();
        public List<oCourse> GetCourses();
        public List<oCourse> GetCourseByID(int id);
        public string Save(oCourse data);
    }
}
